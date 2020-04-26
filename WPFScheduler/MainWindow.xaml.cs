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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WeatherAPILibrary;
using WPFScheduler.Database;

namespace WPFScheduler
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            using (var context = new SchedulerDbContext())
            {
                context.Database.CreateIfNotExists();
                ApplicationDatabaseData.Events = context.Events.ToList();
                ApplicationDatabaseData.TasksToDo = context.TasksToDo.ToList();
            }
            InitializeComponent();
            WeatherAPIHelper.InitializeClient();

        }


        private void weatherButton_Click(object sender, RoutedEventArgs e)
        {
            ChooseCity chooseCity = new ChooseCity();
            chooseCity.Show();
        }

        private void toDoListButton_Click(object sender, RoutedEventArgs e)
        {
            ToDoListWindow taskToDoWindow = new ToDoListWindow();
            taskToDoWindow.Show();
            this.Close();
        }

        private void calendarButton_Click(object sender, RoutedEventArgs e)
        {
            CalendarWindow calendarWindow = new CalendarWindow();
            calendarWindow.Show();
            this.Close();
        }
    }
}
