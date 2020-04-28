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
    /// </summary>
    public partial class EventDetailsWindow : Window
    {
        public EventDetailsWindow(Event ev)
        {
            InitializeComponent();
            this.DataContext = ev;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
