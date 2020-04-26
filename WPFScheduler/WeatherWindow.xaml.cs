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
using WeatherAPILibrary;

namespace WPFScheduler
{
    /// <summary>
    /// Logika interakcji dla klasy WeatherWindow.xaml
    /// </summary>
    public partial class WeatherWindow : Window
    {
        public WeatherWindow(WeatherAPIResponse response)
        {
            InitializeComponent();
            this.DataContext = response;
            LoadImage(response.Weather[0].Icon);
        }

        private void LoadImage(string imageCode)
        {
            string source = $"http://openweathermap.org/img/wn/{imageCode}@2x.png";
            var uriSource = new Uri(source, UriKind.Absolute);
            weatherIcon.Source = new BitmapImage(uriSource);
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void anotherCityButton_Click(object sender, RoutedEventArgs e)
        {
            ChooseCity chooseCity = new ChooseCity();
            chooseCity.Show();
            this.Close();
        }
    }
}
