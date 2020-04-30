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
    /// Logika interakcji dla klasy ToDoListWindow.xaml
    /// W tym oknie użytkownik może zarządzać listą zadań do wykonania
    /// </summary>
    public partial class ToDoListWindow : Window
    {
        /// <summary>
        /// Konstruktor tworzący okno listy zadań do wykonania
        /// </summary>
        public ToDoListWindow()
        {
            InitializeComponent();
            tasksToDoListView.ItemsSource = ApplicationDatabaseData.TasksToDoAppData.TasksToDo;
        }

        /// <summary>
        /// Metoda wywoływana po kliknięciu przycisku "Add"
        /// Otwiera okno dodawania zadań do listy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            AddTaskToDoWindow addTaskToDoWindow = new AddTaskToDoWindow();
            addTaskToDoWindow.ShowDialog();
            tasksToDoListView.Items.Refresh();
        }

        /// <summary>
        /// Metoda wywoływana po kliknięciu przycisku "Back"
        /// Zamyka okno listy zadań do wykonania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Metoda wywoływana po kliknięciu przycisku "Remove"
        /// Usuwa wybrane zadanie z listy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TaskToDo task = (TaskToDo)tasksToDoListView.SelectedItem;
                ApplicationDatabaseData.TasksToDoAppData.Remove(task);
                tasksToDoListView.Items.Refresh();
            }
            catch(ArgumentNullException)
            {
                MessageBox.Show("Select a task to remove");
            }
        }
    }
}
