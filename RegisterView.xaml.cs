using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjectX_Frontend
{
    public partial class RegisterView : Window
    {
        public RegisterView()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            var username = txtRegisterUsername.Text;
            var password = txtRegisterPassword.Text;
            var bio = txtRegisterBio.Text;

            var data = Task.Run(() => RegisterUser(username, password, bio));
            System.Net.ServicePointManager.ServerCertificateValidationCallback = (senderX, certificate, chain, sslPolicyErrors) => { return true; };
            data.Wait();

            if (data.Result.Length > 0 && data.Result != "false")
            {
                MessageBox.Show("You are now registered!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Registration failed");
            }
        }

        static async Task<string> RegisterUser(string u, string p, string b)
        {
            string base_url = "https://localhost:7080/api";
            var response = string.Empty;
            var url = base_url + "/User";
            User objectUser = new User(u, p, b);

            var json = JsonConvert.SerializeObject(objectUser);
            var postData = new StringContent(json, Encoding.UTF8, "application/json");
            var client = new HttpClient();
            HttpResponseMessage result = await client.PostAsync(url, postData);
            response = await result.Content.ReadAsStringAsync();

            return response;
        }

        static async Task<string> UpdateUser(string u, string p, string b)
        {
            string base_url = "https://localhost:7080/api";
            var response = string.Empty;
            var url = base_url + "/User";
            User objectUser = new User(u, p, b);

            var json = JsonConvert.SerializeObject(objectUser);
            var postData = new StringContent(json, Encoding.UTF8, "application/json");
            var client = new HttpClient();
            HttpResponseMessage result = await client.PostAsync(url, postData);
            response = await result.Content.ReadAsStringAsync();

            return response;
        }
    }
}
