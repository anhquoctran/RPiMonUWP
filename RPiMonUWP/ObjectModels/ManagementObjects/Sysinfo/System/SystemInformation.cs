using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RPiMonUWP.ObjectModels.ManagementObjects.Sysinfo.System
{
    public class SystemInformation
    {
        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }
        [JsonProperty("model")]
        public string Model { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("serial")]
        public string Serial { get; set; }
        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    public class RootObjectSi
    {
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("request_datetime")]
        public DateTime RequestDateTime { get; set; }
        [JsonProperty("system_properties")]
        public SystemInformation Si { get; set; }
    }
}
