using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RPiMonUWP.ObjectModels.ManagementObjects.Sysinfo.Process
{
    public class ProcessLoad
    {
        [JsonProperty("pid")]
        public int Pid { get; set; }
        [JsonProperty("cpu")]
        public double Cpu { get; set; }
        [JsonProperty("mem")]
        public double Mem { get; set; }
    }

    public class RootObjectProcessLoad
    {
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("request_datatime")]
        public DateTime RequestDateTime { get; set; }
        [JsonProperty("processload")]
        public ProcessLoad Pl { get; set; }
    }
}
