using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Core;
using Newtonsoft.Json;

namespace RPiMonUWP.ObjectModels.ManagementObjects.Sysinfo.IO
{
    public class DiskIo
    {
        [JsonProperty("rio")]
        public int ReadIO { get; set; }

        [JsonProperty("wio")]
        public int WriteIO { get; set; }

        [JsonProperty("tio")]
        public int T_IO { get; set; }

        [JsonProperty("rio_sec")]
        public float ReadIOPerSec { get; set; }

        [JsonProperty("wio_sec")]
        public float WriteIOPerSec { get; set; }

        [JsonProperty("tio_sec")]
        public float T_IO_PerSec { get; set; }

        [JsonProperty("ms")]
        public float Ms { get; set; }
    }

    public class RootObjectDisk
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("request_datetime")]
        public DateTime RequestDateTime { get; set; }

        [JsonProperty("io")]
        public DiskIo Io { get; set; }
    }
}
