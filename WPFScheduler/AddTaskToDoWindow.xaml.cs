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
    /// W tym oknie użytkownik może wpisać dane swojego zadania do wykonania
    /// oraz zapisać je na swojej liście
    /// </summary>
    public partial class AddTaskToDoWindow : Window
    {
        /// <summary>
        /// Konstruktor tworzący okno dodawana zadań do wykonania
        /// </summary>
        public AddTaskToDoWindow()
        {
            InitializeComponent();
            taskType.ItemsSource = types;
        }

        List<string> types = new List<string> { "Home", "School", "Job", "Other" };

        /// <summary>
        /// Metoda wykonywana po kliknięciu przycisku "Save". Przetwarza wpisane przez użytkownika dane
        /// do postaci, w której można z nich utworzyć obiekt <c>TaskToDo</c>, a następnie zapisuje
        /// utworzony obiekt do danych lokalnych oraz do bazy danych. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            string dateString = $"{taskDeadlineYear.Text}/{taskDeadlineMonth.Text}/{taskDeadlineDay.Text} {taskDeadlineHour.Text}:{taskDeadlineMinute.Text}";
            try
            {
                if (string.IsNullOrWhiteSpace(taskName.Text))
                    throw new ArgumentNullException("Name your task");
                DateTime deadline = Convert.ToDateTime(dateString, new CultureInfo("pl-PL"));
                TaskToDo task = new TaskToDo(taskName.Text, taskType.SelectedItem.ToString(), deadline);
                ApplicationDatabaseData.TasksToDoAppData.Save(task);
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

        /// <summary>
        /// Metoda wywoływana po kliknięciu przycisku "Cancel"
        /// Zamyka okno dodawania zadań
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
