using ecommerceflyout.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ecommerceflyout.Services
{
    public class APIService
    {
        private HttpClient httpClient;
        public ObservableCollection<User> Users { get; set; }
        public String WebAPIUrl { get; set; }
        public APIService()
        {
            this.httpClient = new HttpClient();
        }

        public async Task<ObservableCollection<User>> RefreshAsyncData()
        {
            WebAPIUrl = "https://jsonplaceholder.typicode.com/users"; // Set your REST API url here
            var uri = new Uri(WebAPIUrl);
            Users = new ObservableCollection<User>();
            try
            {
                var response = await httpClient.GetAsync(uri);

                var content = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Verify.....................");
                //Console.WriteLine(content);
                
                //parsing
                JArray jarray=JArray.Parse(content);
                foreach(Object obj in jarray)
                {
                    JObject jobj = JObject.Parse(obj.ToString());

                    User user = JsonConvert.DeserializeObject<User>(jobj.ToString());
                   Users.Add(user);
                    Console.WriteLine(user.Name);
                }
                return Users;
            }
            catch (Exception ex)
            {

            }
            return null;
        }

    }
}
