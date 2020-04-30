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
    /// Logika interakcji dla klasy DateViewWindow.xaml.
    /// W tym oknie użytkownik może zarządzać listą wydarzeń dla wybranej daty
    /// </summary>
    public partial class DateViewWindow : Window
    {
        /// <summary>
        /// Konstruktor tworzący okno przeglądu wydarzeń dla danej daty
        /// </summary>
        /// <param name="selectedDate">Dara wybrana w kalendarzu</param>
        public DateViewWindow(DateTime selectedDate)
        {
            InitializeComponent();
            date = selectedDate;
            events = ApplicationDatabaseData.EventsAppData.Events.Where(x => x.Start.Date == selectedDate.Date).ToList();
            eventsListView.ItemsSource = events;
            eventsListView.SelectedItems.Clear();
        }

        ///<value> Lista wydarzeń przypisanych do danej daty </value>
        private List<Event> events;

        ///<value> Data dla jakiej wyświetlana jest lista wydarzeń </value>
        private DateTime date;

        /// <summary>
        /// Metoda wywoływana po wciśnięciu przycisku "Back"
        /// Zamyka okno przeglądu wydarzeń i otwiera okno kalendarza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            CalendarWindow calendarWindow = new CalendarWindow();
            calendarWindow.Show();
            this.Close();
        }


        /// <summary>
        /// Metoda wywoływana po kliknięciu przycisku "Details"
        /// Otwiera okno szczegółowych informacji o wydarzeniu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Metoda wywoływana po kliknięciu przycisku "Remove"
        /// Usuwa wybrane wydarzenie z listy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Event ev = (Event)eventsListView.SelectedItem;
                ApplicationDatabaseData.EventsAppData.Remove(ev);
                events.Remove(ev);
                eventsListView.Items.Refresh();
            }
            catch(ArgumentNullException)
            {
                MessageBox.Show("Select an event to remove");
            }
        }

        /// <summary>
        /// Metoda wywoływana po kliknięciu przycisku "Add"
        /// Otwiera okno dodawania wydarzeń oraz zamyka okno przeglądu wydarzeń
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            AddEventWindow addEventWindow = new AddEventWindow(date);
            addEventWindow.Show();
            this.Close();
        }
    }
}
