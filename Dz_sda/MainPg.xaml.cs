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

namespace Dz_sda
{
    /// <summary>
    /// Логика взаимодействия для MainPg.xaml
    /// </summary>
    public partial class MainPg : Page
    {
        public MainPg()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new NavTe()); 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Heroes());
        }
    }
}
