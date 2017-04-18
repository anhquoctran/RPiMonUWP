using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking;
using Windows.Web.Http;
using Windows.Web.Http.Headers;
using RPiMonUWP.BaseAPI;
using RPiMonUWP.ObjectModels.ReferenceOjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RPiMonUWP.ViewModels
{
    public class UserManagementViewModel
    {
        public UserManagementViewModel(string token)
        {
            _token = token;
        }

        private static string _token;

        public async Task<UserModels> Login(string username, string password)
        {
            UserModels models;
            try
            {
                var http = new HttpClient();
                var requestUrl = BaseAPIConnectionString.LoginUrl(_token);
                http.DefaultRequestHeaders.Accept.Add(new HttpMediaTypeWithQualityHeaderValue("application/json"));
                HttpRequestMessage requestMessage = new HttpRequestMessage();
                JObject objectlogin = new JObject(new LoginObject()
                {
                    Username = username,
                    Password = password
                });
                requestMessage.Content = new HttpStringContent(objectlogin.ToString(Formatting.Indented));
                requestMessage.Method = HttpMethod.Post;
                requestMessage.RequestUri = new Uri(requestUrl);

                var response = await http.SendRequestAsync(requestMessage);
                
                if (response.IsSuccessStatusCode)
                {
                    
                    var content = await response.Content.ReadAsStringAsync();
                    models = JsonConvert.DeserializeObject<UserModels>(content);
                }
                else
                {
                    models = null;
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return models;
        }

        
    }
}
