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
    /// Interaction logic for mainpage.xaml
    /// </summary>
    public partial class mainpage : Page
    {
        public mainpage()
        {
            InitializeComponent();
        }
        private void StartGame(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Play());
        }
        private void Scores(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Scores());
        }

        private void openSaves(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Saves());
        }

        private void openThema(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Theme());
        }
        private void Stoppen(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        }
}
