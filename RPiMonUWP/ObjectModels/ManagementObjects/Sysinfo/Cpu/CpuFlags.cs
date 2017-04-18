using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RPiMonUWP.ObjectModels.ManagementObjects.Sysinfo.Cpu
{

    public class RootObjectCpuFlags
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("request_datetime")]
        public DateTime RequestDateTime { get; set; }

        [JsonProperty("flags")]
        public IList<string> Flags { get; set; }
    }
}
