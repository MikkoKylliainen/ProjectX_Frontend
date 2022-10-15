using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjectX_Frontend.Views
{
    public partial class AccountView : UserControl
    {
        public AccountView()
        {
            InitializeComponent();

            Singleton userData = Singleton.Instance;
            Console.WriteLine("Hiho: " + userData.Bio);

            txtEditUsername.Text = userData.Username;
            txtEditBio.Text = userData.Bio;
        }

        private void btnSaveChanges_Click(object sender, RoutedEventArgs e)
        {
            //Send user update
        }
    }
}
