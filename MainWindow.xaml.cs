using ProjectX_Frontend.ViewModels;
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
using static System.Net.Mime.MediaTypeNames;
using ProjectX_Frontend;

namespace ProjectX_Frontend
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainViewModel();
            menuHome.Visibility = Visibility.Collapsed;
            menuAccount.Visibility = Visibility.Collapsed;
            menuCat.Visibility = Visibility.Collapsed;
        }

        public void ShowMenu()
        {

            // BLLIB-message toimii mutta ei visibility? TSEKKAA TÄÄ MAINWINDOW

            var mainWindow = App.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (mainWindow != null)
                mainWindow.menuHome.Visibility = Visibility.Visible;
                mainWindow.menuAccount.Visibility = Visibility.Visible;
                mainWindow.menuCat.Visibility = Visibility.Visible;
        }
        private void menuHome_MouseEnter(object sender, MouseEventArgs e)
        {
            menuHome.Background = new SolidColorBrush(Color.FromArgb(255, 34, 52, 82));
        }
        private void menuHome_MouseLeave(object sender, MouseEventArgs e)
        {
            menuHome.Background = new SolidColorBrush(Color.FromArgb(255, 44, 125, 255));
        }
        private void menuAccount_MouseEnter(object sender, MouseEventArgs e)
        {
            menuAccount.Background = new SolidColorBrush(Color.FromArgb(255, 34, 52, 82));
        }
        private void menuAccount_MouseLeave(object sender, MouseEventArgs e)
        {
            menuAccount.Background = new SolidColorBrush(Color.FromArgb(255, 44, 125, 255));
        }
        private void menuCat_MouseEnter(object sender, MouseEventArgs e)
        {
            menuCat.Background = new SolidColorBrush(Color.FromArgb(255, 34, 52, 82));
        }
        private void menuCat_MouseLeave(object sender, MouseEventArgs e)
        {
            menuCat.Background = new SolidColorBrush(Color.FromArgb(255, 44, 125, 255));
        }

        private void menuAccount_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
