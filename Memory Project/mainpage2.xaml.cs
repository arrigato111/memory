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

namespace Memory_Project
{
    /// <summary>
    /// Interaction logic for mainpage2.xaml
    /// </summary>
    public partial class mainpage2 : Page
    {
        public mainpage2()
        {
            InitializeComponent();
        }
        private void StartGame(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new mainpage());
        }
    }
}
