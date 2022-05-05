using Bookstore.Web.Econt;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Label = Bookstore.Web.Econt.Label;

namespace Bookstore.Web.Services
{
    public class EcontService
    {
        public HttpClient Client { get; set; }

        public EcontService(HttpClient client)
        {
            this.Client = client;
        }

        public async Task<LabelResponse> CreateLabel()
        {
            var label = new LabelRequest()
            {
                Mode = "create",
                Label = new Label()
                {
                    SenderClient = new ErClient()
                    {
                        Name = "Ivan Petrov",
                        Phones = new List<string>() { "0884244557" }
                    },
                    SenderAddress = new ErAddress()
                    {
                        City = new City()
                        {
                            Country = new Country()
                            {
                                Code3 = "BGR"
                            },
                            Name = "Sofia",
                            PostCode = 7012
                        },
                        Street = "ul. Orehova gora",
                        Num = 7
                    },
                    ReceiverClient = new ErClient()
                    {
                        Name = "Petar Mihov",
                        Phones = new List<string>() { "088352520" }
                    },
                    ReceiverAddress = new ErAddress()
                    {
                        City = new City()
                        {
                            Country = new Country()
                            {
                                Code3 = "BGR"
                            },
                            Name = "Jolio Kurie",
                            PostCode = 7010
                        },
                        Street = "Jolie Kurie",
                        Num = 115,
                        Other = "et. 12, ap. 172"
                    },
                    PackCount = 1,
                    ShipmentType = "PACK",
                    ShipmentDescription = "books",
                    Weight = 5
                }
            };

            var content = new StringContent(JsonConvert.SerializeObject(label), Encoding.UTF8, "application/json");

            var authString = Convert.ToBase64String(Encoding.ASCII.GetBytes("iasp-dev:iasp-dev"));
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authString);
            var response = await Client.PostAsync("Shipments/LabelService.createLabel.json", content);

            var labelResponse = await response.Content.ReadAsStringAsync();
            var econtResponse = JsonConvert.DeserializeObject<LabelResponse>(labelResponse);

            return econtResponse;
        }
    }
}
