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
        }

        private List<Event> events;
        private DateTime date;

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void detailsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
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

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            AddEventWindow addEventWindow = new AddEventWindow(date);
            addEventWindow.Show();
            this.Close();
        }
    }
}
