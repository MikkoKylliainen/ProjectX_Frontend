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

namespace ProjectX_Frontend
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            DataContext = new MainViewModel();
            // btnLogin.Visibility = Visibility.Collapsed;

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
        private void menuLogin_MouseEnter(object sender, MouseEventArgs e)
        {
            menuLogin.Background = new SolidColorBrush(Color.FromArgb(255, 34, 52, 82));
        }
        private void menuLogin_MouseLeave(object sender, MouseEventArgs e)
        {
            menuLogin.Background = new SolidColorBrush(Color.FromArgb(255, 44, 125, 255));
        }
    }
}
