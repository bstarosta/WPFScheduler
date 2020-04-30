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
    /// Okno startowe aplikacji. Pozwala użytkownikowi przejść
    /// do kalendarza wydarzeń, listy zadań do wykonania lub
    /// informacji pogodowych
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Konstruktor tworzący okno startowe
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Metoda wywoływana po kliknięciu przycisku prognozy pogody
        /// Otwiera okno wyboru miasta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void weatherButton_Click(object sender, RoutedEventArgs e)
        {
            ChooseCity chooseCity = new ChooseCity();
            chooseCity.Show();
        }

        /// <summary>
        /// Metoda wywoływana po kliknięciu przycisku listy zadań.
        /// Otwiera okno listy zadań do wykonania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toDoListButton_Click(object sender, RoutedEventArgs e)
        {
            ToDoListWindow taskToDoWindow = new ToDoListWindow();
            taskToDoWindow.Show();
        }

        /// <summary>
        /// Metoda wywoływana po kliknięciu przycisku kalendarza
        /// Otwiera okno kalendarza wydarzeń
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calendarButton_Click(object sender, RoutedEventArgs e)
        {
            CalendarWindow calendarWindow = new CalendarWindow();
            calendarWindow.Show();
        }
    }
}
