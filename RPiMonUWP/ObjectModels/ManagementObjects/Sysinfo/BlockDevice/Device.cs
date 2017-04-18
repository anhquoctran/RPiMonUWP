using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Authentication.Web.Provider;
using Newtonsoft.Json;

namespace RPiMonUWP.ObjectModels.ManagementObjects.Sysinfo.BlockDevice
{
    public class Device
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("fstype")]
        public string FsType { get; set; }
        [JsonProperty("mount")]
        public string Mount { get; set; }
        [JsonProperty("size")]
        public double Size { get; set; }
        [JsonProperty("uuid")]
        public string Uuid { get; set; }
        [JsonProperty("label")]
        public string Label { get; set; }
        [JsonProperty("model")]
        public string Model { get; set; }
        [JsonProperty("serial")]
        public string Serial { get; set; }
        [JsonProperty("removable")]
        public bool Removable { get; set; }
        [JsonProperty("protocol")]
        public string Protocol { get; set; }
    }

    public class RootObjectDevice
    {
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("request_datetime")]
        public DateTime RequestDateTime { get; set; }
        [JsonProperty("block_list")]
        public IList<Device> BlockDevices { get; set; }
    }
}
