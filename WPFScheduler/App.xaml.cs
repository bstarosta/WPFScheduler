using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WeatherAPILibrary;
using WPFScheduler.Database;

namespace WPFScheduler
{
    /// <summary>
    /// Częsć klasy App zawierająca metodę wywoływaną przy starcie aplikacji
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Metoda inicializująca bazę danych oraz klienta API pogodowego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            ApplicationDatabaseData.InitializeDatabase();
            ApplicationDatabaseData.LoadDataFromDatabase();
            WeatherAPIHelper.InitializeClient();
        }
    }
}
