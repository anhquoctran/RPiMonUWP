using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RPiMonUWP.ObjectModels.ManagementObjects.Sysinfo.Cpu
{
    public class CpuCurrentSpeed
    {
        [JsonProperty("min")]
        public decimal Min { get; set; }

        [JsonProperty("max")]
        public decimal Max { get; set; }

        [JsonProperty("avg")]
        public decimal Average { get; set; }
    }

    public class RootObjectCpuCurrentSpeed
    {
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("request_datetime")]
        public DateTime RequestDateTime { get; set; }
        [JsonProperty("cpu_currentSpeed")]
        public CpuCurrentSpeed CpuCurrentSpeed { get; set; }
    }
}
