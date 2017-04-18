using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RPiMonUWP.ObjectModels.ManagementObjects.Sysinfo.Cpu
{
    public class CpuCache
    {
        [JsonProperty("l1d")]
        public int L1D { get; set; }
        [JsonProperty("l1i")]
        public int L1I { get; set; }
        [JsonProperty("l2")]
        public int L2 { get; set; }
        [JsonProperty("l3")]
        public int L3 { get; set; }
    }

    public class RootObjectCpuCache
    {
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("request_datetime")]
        public DateTime RequestDateTime { get; set; }
        [JsonProperty("cpu_cache")]
        public CpuCache CpuCache { get; set; }
    }
}
