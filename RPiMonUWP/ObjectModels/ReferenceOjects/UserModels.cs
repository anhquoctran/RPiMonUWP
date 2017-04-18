using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RPiMonUWP.ObjectModels.ReferenceOjects
{
    public class UserModels
    {
        [JsonProperty("Id")]
        public object ObjectId { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("fullname")]
        public string Fullname { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("birthdate")]
        public DateTime Birthdate { get; set; }
        [JsonProperty("role")]
        public bool Role { get; set; }
    }

    public class RootUserModels
    {   [JsonProperty("token")]
        public string AccesToken { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("data")]
        public UserModels UserInfo { get; set; }
    }
}
