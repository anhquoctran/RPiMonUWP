using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Authentication.Web.Provider;
using Newtonsoft.Json;

namespace RPiMonUWP.ObjectModels.ManagementObjects.Sysinfo.Memory
{
    public class Memory
    {
        [JsonProperty("total")]
        public double Total { get; set; }
        [JsonProperty("free")]
        public double Free { get; set; }
        [JsonProperty("used")]
        public double InUsed { get; set; }
        [JsonProperty("active")]
        public double Active { get; set; }
        [JsonProperty("available")]
        public double Available { get; set; }
        [JsonProperty("buffcache")]
        public double BufferCache { get; set; }
        [JsonProperty("swaptotal")]
        public double SwapTotal { get; set; }
        [JsonProperty("swapused")]
        public double SwapUsed { get; set; }
        [JsonProperty("swapfree")]
        public double SwapFree { get; set; }
    }

    public class RootObjectMemory
    {
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("request_datetime")]
        public DateTime RequestDateTime { get; set; }
        [JsonProperty("memory_properties")]
        public Memory MemoryProperties { get; set; }
    }
}
