using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RPiMonUWP.ObjectModels.ManagementObjects.Sysinfo.User
{
    public class SystemUser
    {
        [JsonProperty("user")]
        public string Name { get; set; }
        [JsonProperty("tty")]
        public string Tty { get; set; }
        [JsonProperty("date")]
        public string Date { get; set; }
        [JsonProperty("time")]
        public string Time { get; set; }
        [JsonProperty("ip")]
        public string Ip { get; set; }
        [JsonProperty("command")]
        public string Command { get; set; }
    }

    public class RootObjectSystemUser
    {
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("request_datetime")]
        public DateTime RequestDateTime { get; set; }
        [JsonProperty("users")]
        public IList<SystemUser> Users { get; set; }
    }
}
