using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RPiMonUWP.ObjectModels.ManagementObjects.Sysinfo.Network
{
    public class NetworkInterfaces
    {
        [JsonProperty("iface")]
        public string Name { get; set; }
        [JsonProperty("ip4")]
        public string IpV4 { get; set; }
        [JsonProperty("ip6")]
        public string IpV6 { get; set; }
        [JsonProperty("mac")]
        public string Mac { get; set; }
        [JsonProperty("internal")]
        public bool Internal { get; set; }
    }

    public class RootObjectNetIfaces
    {
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("request_datetime")]
        public DateTime RequestDateTime { get; set; }
        [JsonProperty("list_ifaces")]
        public IList<NetworkInterfaces> NetIfaceList { get; set; }
    }
}
