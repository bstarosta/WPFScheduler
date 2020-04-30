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

namespace WPFScheduler
{
    /// <summary>
    /// Logika interakcji dla klasy EventDetailsWindow.xaml
    /// W tym oknie użytkownik ma dostęp do szczegółowych informacji
    /// o wybranym wydarzeniu
    /// </summary>
    public partial class EventDetailsWindow : Window
    {
        /// <summary>
        /// Konstruktor tworzący okno szczegółowych informacji o wydarzeniu
        /// wybranym z listy
        /// </summary>
        /// <param name="ev">Wydarzenie wybrane z listy</param>
        public EventDetailsWindow(Event ev)
        {
            InitializeComponent();
            this.DataContext = ev;
        }


        /// <summary>
        /// Metoda wywoływana po wcisnięciu przycisku "Close"
        /// Zamyka okno szczegółowych informacji o wydarzeniu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
