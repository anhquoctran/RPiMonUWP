using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RPiMonUWP.ObjectModels.ManagementObjects.Sysinfo.FileSystem
{
    public class FsSize
    {
        [JsonProperty("fs")]
        public string Name { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("size")]
        public double Size { get; set; }
        [JsonProperty("used")]
        public double Used { get; set; }
        [JsonProperty("use")]
        public float Use { get; set; }
        [JsonProperty("mount")]
        public string Mount { get; set; }
    }

    public class RootObjectFsSize
    {
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("request_datetime")]
        public DateTime RequestDateTime { get; set; }
        [JsonProperty("fs_sizes")]
        public IList<FsSize> ListFileSystemSizes { get; set; }
    }
}
