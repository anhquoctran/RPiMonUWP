using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RPiMonUWP.ObjectModels.ManagementObjects.Sysinfo.OS
{
    public class OSInfo
    {
        [JsonProperty("platform")]
        public string Platform { get; set; }
        [JsonProperty("distro")]
        public string Distro { get; set; }
        [JsonProperty("release")]
        public string Release { get; set; }
        [JsonProperty("codename")]
        public string CodeName { get; set; }
        [JsonProperty("kernel")]
        public string Kernel { get; set; }
        [JsonProperty("arch")]
        public string Arch { get; set; }
        [JsonProperty("hostname")]
        public string Hostname { get; set; }
        [JsonProperty("logofile")]
        public string LogoFile { get; set; }
    }

    public class RootObjectOSInfo
    {
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("request_datetime")]
        public DateTime RequestDateTime { get; set; }
        [JsonProperty("osinfo")]
        public OSInfo OSInformation { get; set; }
    }
}
