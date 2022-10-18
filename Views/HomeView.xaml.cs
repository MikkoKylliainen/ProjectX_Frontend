using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjectX_Frontend.Views
{
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
            GetSnookerTournaments();
        }

        public void GetSnookerTournaments() {
        
            var data = Task.Run(() => GetTournamentsFromAPI());
            System.Net.ServicePointManager.ServerCertificateValidationCallback = (senderX, certificate, chain, sslPolicyErrors) => { return true; };
            data.Wait();

            if (data.Result.Length > 0 && data.Result != "false")
            {
                var jsonResult = data.Result;
                var st = JsonConvert.DeserializeObject<List<Tournament>>(data.Result);
                
                foreach (var sTournament in st)
                {
                    var sName = sTournament.Name;
                    var sType = sTournament.Type;

                    if (sType != "Ranking") { continue; }

                    TournamentList.Items.Add(sName);
                }
            }
            else
            {
                MessageBox.Show("Error with the connection or the API");
            }   
        }

        public class Tournament
        {
            public string Name { get; set; }
            public string Type { get; set; }
        }

        static async Task<string> GetTournamentsFromAPI()
        {
            var url = "http://api.snooker.org/?t=5&s=2022";
            var client = new HttpClient();
            HttpResponseMessage result = await client.GetAsync(url);
            var response = await result.Content.ReadAsStringAsync();

            return response;
        }
    }
}
