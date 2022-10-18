using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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
using System.Windows.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Markup;
using ProjectX_Frontend;
using ProjectX_Frontend.Commands;
using ProjectX_Frontend.ViewModels;
using ProjectX_Frontend.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ProjectX_Frontend.Views
{
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        public void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            var data = Task.Run(() => LoginUser(username, password));
            System.Net.ServicePointManager.ServerCertificateValidationCallback = (senderX, certificate, chain, sslPolicyErrors) => { return true; };
            data.Wait();

            if (data.Result.Length > 0 && data.Result != "false")
            {
                // Login accepted

                JObject j = JObject.Parse(data.Result);
                var resUsername = j["username"].ToString();

                MainWindow MainWindow = new MainWindow();
                MainWindow.ShowMenu();

                Singleton singObject = Singleton.Instance;
                singObject.Username = j["username"].ToString();
                singObject.Password = j["password"].ToString();
                singObject.Bio = j["bio"].ToString();

                Singleton userData = Singleton.Instance;
            }
            else
            {
                // Login failed

                MessageBox.Show("Login failed");

            }
}

        static async Task<string> LoginUser(string u, string p)
        {
            string base_url = "https://localhost:7080/api";
            var response = string.Empty;
            var url = base_url + "/Login";
            User objectUser = new User(u, p, "");

            var json = JsonConvert.SerializeObject(objectUser);
            var postData = new StringContent(json, Encoding.UTF8, "application/json");
            var client = new HttpClient();
            HttpResponseMessage result = await client.PostAsync(url, postData);
            response = await result.Content.ReadAsStringAsync();

            return response;
        }

        private void btnRegisterWindowClick(object sender, RoutedEventArgs e)
        {
            RegisterView objectRegisterView = new RegisterView();
            objectRegisterView.ShowDialog();
        }
    }
}
