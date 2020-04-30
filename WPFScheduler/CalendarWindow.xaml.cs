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
    /// Logika interakcji dla klasy CalendarWindow.xaml.
    /// W tym oknie użytkownik ma dostęp do kalendarza, z którego może
    /// wybrać datę, aby przejrzeć przypisane do niej wydarzenia
    /// </summary>
    public partial class CalendarWindow : Window
    {
        /// <summary>
        /// Konstruktor tworzący okno kalendarza
        /// </summary>
        public CalendarWindow()
        {
            InitializeComponent();
            eventDates = new List<DateTime>();
            foreach (var ev in ApplicationDatabaseData.EventsAppData.Events)
                eventDates.Add(ev.Start.Date);

        }

        ///<value> Lista dat, do któtych przypisane są wydarzenia </value>
        private List<DateTime> eventDates;

        /// <summary>
        /// Metoda wywoływana po wciśnięciu klawisza "Back"
        /// Zamyka okno kalendarza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metoda wywoływana po wciśnięciu klawisza "Select"
        /// Otwiera okno przeglądu wydarzeń dla wybranej daty oraz
        /// zamyka okno kalendarza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Metoda pomocnicza resetująca focus myszki po wyborze daty w kalendarzu
        /// </summary>
        /// <remarks>
        /// Wprowadzona aby nie było konieczności dwukrotnego klikania przycisków po
        /// wyborze daty.
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eventCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            Mouse.Capture(null);
        }

        /// <summary>
        /// Metoda wywoływana po załadowaniu przycisków reprezentujących dni w kalendarzu
        /// Wyróznia przyciski kalendarza, których daty znajdują się na liście
        /// dat przypisanych do wydarzeń
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalendarDayButton_Loaded(object sender, RoutedEventArgs e)
        {
            CalendarDayButton button = (CalendarDayButton)sender;
            DateTime date = (DateTime)button.DataContext;
            highlightDay(button, date);
            button.DataContextChanged += new DependencyPropertyChangedEventHandler(calendarButton_DataContextChanged);
        }


        /// <summary>
        /// Metoda pomocnicza, która zmienia tło przycisku kalendarza jeżeli przypisana do niego data
        /// znajduje sie na liście dat przypisanych do wydarzeń
        /// </summary>
        /// <param name="button">Przycisk kalendarza</param>
        /// <param name="date">Data przypisana do przycisku</param>
        private void highlightDay(CalendarDayButton button, DateTime date)
        {

            if (eventDates.Contains(date))
                button.Background = Brushes.LightBlue;
            else if (date != DateTime.Today)
                button.Background = Brushes.White;
            else
                button.Background = Brushes.Gray;
        }

        /// <summary>
        /// Metoda wywoływana po zmianie miesięcy w kontrolce kalendarza. Aktualizuje
        /// przyciski kalendarza po zmianie miesiąca
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calendarButton_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            CalendarDayButton button = (CalendarDayButton)sender;
            DateTime date = (DateTime)button.DataContext;
            highlightDay(button, date);
        }
    }
}
