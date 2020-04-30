using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Logika interakcji dla klasy AddEventWindow.xaml.
    /// W tym oknie użytkownik może dodać wydarzenie dla wybranej w oknie kalendarza daty
    /// </summary>
    public partial class AddEventWindow : Window
    {
        /// <summary>
        /// Konstruktor tworzący okno zawierające wydarzenia dla podanej daty
        /// </summary>
        /// <param name="date">Data wybrana przez użytkownika w kalendarzu</param>
        public AddEventWindow(DateTime date)
        {
            InitializeComponent();
            eventType.ItemsSource = eventTypes;
            eventDate = date;
        }

        /// <value>Lista zawierająca typy wydarzeń</value>
        List<string> eventTypes =new List<string>() {"Meeting", "Party", "Travel", "Cultural", "Business", "Other" };

        /// <value>Data wydarzenia</value>
        private DateTime eventDate;

        /// <summary>
        /// Metoda wywoływana po kliknięciu przycisku "Cancel"
        /// Zamyka okno dodawnia wydarzeń
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metoda wywoływana po kliknięciu przycisku "Save"
        /// Przetwarza wpisane przez użytkownika dane do postaci, w której
        /// można z nich utworzyć obiekt <c>Event</c> a następnie zapisuje utworzony obiekt
        /// do danych lokalnych oraz do bazy danych.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                checkForEmptyFields();
                DateTime startDate = DateTimeHelper.addTimeToDate(eventDate, startHour.Text, startMinute.Text);
                DateTime endDate = DateTimeHelper.addTimeToDate(eventDate, endHour.Text, endMinute.Text);
                if (DateTime.Compare(startDate, endDate) > 0)
                    throw new FormatException("An event can't end before it starts");
                Event ev = new Event(startDate, endDate, eventName.Text, eventType.SelectedItem.ToString(), eventDescription.Text);
                ApplicationDatabaseData.EventsAppData.Save(ev);
                this.Close();
            }
            catch(MissingFieldException)
            {
                MessageBox.Show("Fields are missing");
            }
            catch(FormatException)
            {
                MessageBox.Show("Incorrect time");
            }
            
        }

        /// <summary>
        /// Metoda pomocnicza sprawdzająca czy wymagane do zapisania wydarzenia pola
        /// nie są puste.
        /// <exception cref="MissingFieldException">Wyjątek rzucany w przypadku gdy wymagane pola są puste</exception>
        /// </summary>
        private void checkForEmptyFields()
        {
            if (string.IsNullOrWhiteSpace(eventName.Text))
                throw new MissingFieldException();
            if (string.IsNullOrWhiteSpace(startHour.Text))
                throw new MissingFieldException();
            if (string.IsNullOrWhiteSpace(startMinute.Text))
                throw new MissingFieldException();
            if (string.IsNullOrWhiteSpace(endHour.Text))
                throw new MissingFieldException();
            if (string.IsNullOrWhiteSpace(endMinute.Text))
                throw new MissingFieldException();
        }

        /// <summary>
        /// Metoda wywoływana podczas zamknięcia okna dodawania wydarzeń
        /// Otwiera poprzednie okno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DateViewWindow dateViewWindow = new DateViewWindow(eventDate.Date);
            dateViewWindow.Show();
        }
    }
}
