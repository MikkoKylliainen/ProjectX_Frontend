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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjectX_Frontend.Views
{
    public partial class CatView : UserControl
    {
        public CatView()
        {
            InitializeComponent();
            GetCat();
        }

        public void GetCat()
        {
            var data = Task.Run(() => GetCatFromAPI());
            System.Net.ServicePointManager.ServerCertificateValidationCallback = (senderX, certificate, chain, sslPolicyErrors) => { return true; };
            data.Wait();

            if (data.Result.Length > 0 && data.Result != "false")
            {
                var jsonResult = data.Result.TrimStart(new char[] { '[' }).TrimEnd(new char[] { ']' });
                JObject j = JObject.Parse(jsonResult);
                var catURL = j["url"].ToString();

                CatImage.Source = new BitmapImage(new Uri(@catURL));
            }
            else
            {
                MessageBox.Show("Error with the connection or the API");
            }
        }
        static async Task<string> GetCatFromAPI()
        {
            var url = "https://api.thecatapi.com/v1/images/search";
            var client = new HttpClient();
            HttpResponseMessage result = await client.GetAsync(url);
            var response = await result.Content.ReadAsStringAsync();

            return response;
        }

        private void btn_GetCat_Click(object sender, RoutedEventArgs e)
        {
            GetCat();
        }
    }
}
