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
    /// </summary>
    public partial class ToDoListWindow : Window
    {
        private SchedulerDbContext context = new SchedulerDbContext();
        public ToDoListWindow()
        {
            InitializeComponent();
            tasksToDoListView.ItemsSource = ApplicationDatabaseData.TasksToDo;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            AddTaskToDoWindow addTaskToDoWindow = new AddTaskToDoWindow();
            addTaskToDoWindow.ShowDialog();
            tasksToDoListView.Items.Refresh();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TaskToDo task = (TaskToDo)tasksToDoListView.SelectedItem;
                ApplicationDatabaseData.TasksToDo.Remove(task);
                context.TasksToDo.Attach(task);
                context.TasksToDo.Remove(task);
                context.SaveChanges();
                tasksToDoListView.Items.Refresh();
            }
            catch(ArgumentNullException)
            {
                MessageBox.Show("Select a task to remove");
            }
        }
    }
}
