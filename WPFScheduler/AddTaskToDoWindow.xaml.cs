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
    /// Logika interakcji dla klasy AddTaskToDoWindow.xaml
    /// </summary>
    public partial class AddTaskToDoWindow : Window
    {
        public AddTaskToDoWindow()
        {
            InitializeComponent();
            List<string> types = new List<string> { "Home", "School", "Job", "Other" };
            taskType.ItemsSource = types;
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            string dateString = $"{taskDeadlineYear.Text}/{taskDeadlineMonth.Text}/{taskDeadlineDay.Text} {taskDeadlineHour.Text}:{taskDeadlineMinute.Text}";
            try
            {
                if (string.IsNullOrWhiteSpace(taskName.Text))
                    throw new ArgumentNullException("Name your task");
                DateTime deadline = Convert.ToDateTime(dateString, new CultureInfo("pl-PL"));
                TaskToDo task = new TaskToDo(taskName.Text, taskType.SelectedItem.ToString(), deadline);
                using (var context = new SchedulerDbContext())
                {
                    context.TasksToDo.Add(task);
                    context.SaveChanges();
                }
                ApplicationDatabaseData.TasksToDo.Add(task);
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid date format");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Name your task");
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
