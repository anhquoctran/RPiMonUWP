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
using RPiMonUWP.Commons;

namespace RPiMonUWP.ViewModels
{
    public class UserManagementViewModel
    {
        public UserManagementViewModel(string token)
        {
            _token = token;
        }

        private static string _token;
        private static Security sec = new Security();

        public async Task<UserModels> Login(string username, string password)
        {
            UserModels models;
            try
            {
                var http = new HttpClient();
                var requestUrl = BaseAPIConnectionString.LoginUrl();
                http.DefaultRequestHeaders.Accept.Add(new HttpMediaTypeWithQualityHeaderValue("application/json"));
                HttpRequestMessage requestMessage = new HttpRequestMessage();

                var passwordBytes = Encoding.UTF8.GetBytes(password);
                var encrypt = sec.Encrypt(passwordBytes);
                var a = Encoding.UTF8.GetString(encrypt);

                JObject objectlogin = new JObject(new LoginObject()
                {
                    Username = username,
                    Password = a
                });

                requestMessage.Content = new HttpStringContent(objectlogin.ToString(Formatting.Indented));
                requestMessage.Method = HttpMethod.Post;
                requestMessage.RequestUri = new Uri(requestUrl);

                var response = await http.SendRequestAsync(requestMessage);
                
                if (response.IsSuccessStatusCode)
                {
                    
                    var content = await response.Content.ReadAsStringAsync();
                    var root = JsonConvert.DeserializeObject<RootUserModels>(content);
                    models = root.UserInfo[0];
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

        public async Task<bool> AddUser(string username, string password, string email, string phone, string fullname,
            DateTime birthdate, bool isadmin = false)
        {
            bool res = false;
            try
            {
                var requestUrl = BaseAPIConnectionString.AddUserUrl(_token);
                var client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new HttpMediaTypeWithQualityHeaderValue("application/json"));
                HttpRequestMessage requestMessage = new HttpRequestMessage();
                requestMessage.Method = HttpMethod.Post;
                requestMessage.RequestUri = new Uri(requestUrl);
                JObject jobjadd = new JObject(new UserModels()
                {
                    Fullname = fullname,
                    Username = username,
                    Password = password,
                    Email = email,
                    Phone = phone,
                    Birthdate = birthdate,
                    Role = isadmin
                });

                requestMessage.Content = new HttpStringContent(jobjadd.ToString(Formatting.Indented));
                var response =  await client.SendRequestAsync(requestMessage);
                res = response.IsSuccessStatusCode;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return res;
        }

        public async Task<bool> DeleleUser(string username)
        {
            bool res;
            try
            {
                var requestUrl = BaseAPIConnectionString.DeleteUserUrl(_token);
                var client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new HttpMediaTypeWithQualityHeaderValue("application/json"));
                var response = await client.SendRequestAsync(new HttpRequestMessage()
                {
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri(requestUrl),
                    Content = new HttpStringContent(new JObject(new UserModels()
                    {
                        Username = username
                    }).ToString(Formatting.Indented))
                });
                res = response.IsSuccessStatusCode;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return res;
        }

        public async Task<bool> UpdateUser(string username, string fullname, DateTime birthdate, string phone,
            string email)
        {
            bool res;
            try
            {
                var requestUrl = BaseAPIConnectionString.UpdateUserUrl(_token);
                var client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new HttpMediaTypeWithQualityHeaderValue("application/json"));
                var response = await client.SendRequestAsync(new HttpRequestMessage()
                {
                    Method = HttpMethod.Put,
                    RequestUri = new Uri(requestUrl),
                    Content = new HttpStringContent(new JObject(new UserModels()
                    {
                        Username = username,
                        Fullname = fullname,
                        Phone = phone,
                        Birthdate = birthdate,
                        Email = email,
                    }).ToString(Formatting.Indented))
                });
                res = response.IsSuccessStatusCode;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return res;
        }

        public async Task<List<UserModels>> FetchAllUserAvailable()
        {
            var lst = new List<UserModels>();
            try
            {
                var requestUrl = BaseAPIConnectionString.FetchAllUserConnUrl(_token);
                var client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new HttpMediaTypeWithQualityHeaderValue("application/json"));
                var response = await client.GetAsync(new Uri(requestUrl));
                if (response.IsSuccessStatusCode)
                {
                    var rs = response.Content.ReadAsStringAsync();
                    var deserialize = JsonConvert.DeserializeObject<RootUserModels>(rs.GetResults());
                    lst = deserialize.UserInfo;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return lst;
        }
    }
}
