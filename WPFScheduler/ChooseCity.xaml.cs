using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Net;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WeatherAPILibrary;

namespace WPFScheduler
{
    /// <summary>
    /// Logika interakcji dla klasy ChooseCity.xaml
    /// </summary>
    public partial class ChooseCity : Window
    {
        public ChooseCity()
        {
            InitializeComponent();
        }

        private void chooseCityButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                WeatherAPIResponse response = WeatherProcessor.GetWeather(cityName.Text);
                WeatherWindow weatherWindow = new WeatherWindow(response);
                weatherWindow.Show();
                this.Close();
            }
            catch (Exception exception)
            {
                if (exception.Message == "Not Found")
                    MessageBox.Show("Incorrect city name");
                else
                    MessageBox.Show(exception.Message);
                cityName.Clear();
            }

        }
    }
}
