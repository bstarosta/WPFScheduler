using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
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
    /// Logika interakcji dla klasy DateViewWindow.xaml
    /// </summary>
    public partial class DateViewWindow : Window
    {
        public DateViewWindow(DateTime selectedDate)
        {
            InitializeComponent();
            date = selectedDate;
            events = ApplicationDatabaseData.Events.Where(x => x.Start.Date == selectedDate.Date).ToList();
            eventsListView.ItemsSource = events;
            eventsListView.SelectedItems.Clear();
        }

        private List<Event> events;
        private DateTime date;

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            CalendarWindow calendarWindow = new CalendarWindow();
            calendarWindow.Show();
            this.Close();
        }

        private void detailsButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (eventsListView.SelectedItems.Count == 0)
                    throw new ArgumentNullException();
                EventDetailsWindow eventDetailsWindow = new EventDetailsWindow((Event)eventsListView.SelectedItem);
                eventDetailsWindow.Show();
            }
            catch(ArgumentNullException)
            {
                MessageBox.Show("Select an event");
            }
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Event ev = (Event)eventsListView.SelectedItem;
                ApplicationDatabaseData.Events.Remove(ev);
                events.Remove(ev);
                using (var context = new SchedulerDbContext())
                {
                    context.Events.Attach(ev);
                    context.Events.Remove(ev);
                    context.SaveChanges();
                }
                eventsListView.Items.Refresh();
            }
            catch(ArgumentNullException)
            {
                MessageBox.Show("Select an event to remove");
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            AddEventWindow addEventWindow = new AddEventWindow(date);
            addEventWindow.Show();
            this.Close();
        }
    }
}
