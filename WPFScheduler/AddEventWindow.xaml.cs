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
    /// Logika interakcji dla klasy AddEventWindow.xaml
    /// </summary>
    public partial class AddEventWindow : Window
    {
        public AddEventWindow(DateTime date)
        {
            InitializeComponent();
            eventType.ItemsSource = eventTypes;
            eventDate = date;
        }

        List<string> eventTypes =new List<string>() {"Meeting", "Party", "Travel", "Cultural", "Other" };
        private DateTime eventDate;

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

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
                ApplicationDatabaseData.Events.Add(ev);
                using (var context = new SchedulerDbContext())
                {
                    context.Events.Add(ev);
                    context.SaveChanges();
                }
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

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DateViewWindow dateViewWindow = new DateViewWindow(eventDate.Date);
            dateViewWindow.Show();
        }
    }
}
