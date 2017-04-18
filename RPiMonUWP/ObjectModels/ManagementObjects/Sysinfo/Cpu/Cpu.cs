using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RPiMonUWP.ObjectModels.ManagementObjects.Sysinfo.Cpu
{
    public class Cpu
    {
        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("speed")]
        public string Speed { get; set; }

        [JsonProperty("cores")]
        public int Cores { get; set; }
    }

    public class RootObjectCpu
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("request_datetime")]
        public DateTime RequestDateTime { get; set; }

        [JsonProperty("cpu")]
        public Cpu Cpu { get; set; }
    }
}
