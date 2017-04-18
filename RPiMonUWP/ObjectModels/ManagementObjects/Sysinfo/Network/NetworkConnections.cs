using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RPiMonUWP.ObjectModels.ManagementObjects.Sysinfo.Network
{
    public class NetworkConnections
    {
        [JsonProperty("protocol")]
        public string Protocol { get; set; }
        [JsonProperty("localaddress")]
        public string LocalAddress { get; set; }
        [JsonProperty("localport")]
        public string LocalPort { get; set; }
        [JsonProperty("peeraddress")]
        public string PeerAddress { get; set; }
        [JsonProperty("peerport")]
        public string PeerPort { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class RootObjectNetConnections
    {
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("request_datetime")]
        public DateTime RequestDateTime { get; set; }
        [JsonProperty("list_connection")]
        public IList<NetworkConnections> ListConnections { get; set; }
    }
}
