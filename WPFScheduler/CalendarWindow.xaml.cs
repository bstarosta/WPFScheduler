using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPFScheduler.Database;

namespace WPFScheduler
{
    /// <summary>
    /// Logika interakcji dla klasy CalendarWindow.xaml
    /// </summary>
    public partial class CalendarWindow : Window
    {
        public CalendarWindow()
        {
            InitializeComponent();
            eventDates = new List<DateTime>();
            foreach (var ev in ApplicationDatabaseData.Events)
                eventDates.Add(ev.Start.Date);

        }

        private List<DateTime> eventDates;

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void selectButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateViewWindow dateViewWindow = new DateViewWindow(eventCalendar.SelectedDate.Value);
                dateViewWindow.Show();
                this.Close();
            }
            catch(InvalidOperationException)
            {
                MessageBox.Show("Select a date first");
            }
        }

        private void eventCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            Mouse.Capture(null);
        }

        private void CalendarDayButton_Loaded(object sender, RoutedEventArgs e)
        {
            CalendarDayButton button = (CalendarDayButton)sender;
            DateTime date = (DateTime)button.DataContext;
            highlightDay(button, date);
            button.DataContextChanged += new DependencyPropertyChangedEventHandler(calendarButton_DataContextChanged);
        }

        private void highlightDay(CalendarDayButton button, DateTime date)
        {

            if (eventDates.Contains(date))
                button.Background = Brushes.LightBlue;
            else if (date != DateTime.Today)
                button.Background = Brushes.White;
            else
                button.Background = Brushes.Gray;
        }

        private void calendarButton_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            CalendarDayButton button = (CalendarDayButton)sender;
            DateTime date = (DateTime)button.DataContext;
            highlightDay(button, date);
        }
    }
}
