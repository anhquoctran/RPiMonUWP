using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Input;
using Newtonsoft.Json;

namespace RPiMonUWP.ObjectModels.ManagementObjects.Sysinfo.Process
{
    public class Processes
    {
        [JsonProperty("all")]
        public int All { get; set; }

        [JsonProperty("running")]
        public int Running { get; set; }

        [JsonProperty("blocked")]
        public int Blocked { get; set; }
        
        [JsonProperty("sleeping")]
        public int Sleeping { get; set; }

        [JsonProperty("processes")]
        public IList<Process> ListProcess { get; set; }
    }

    public class Process
    {
        [JsonProperty("pid")]
        public int Pid { get; set; }

        [JsonProperty("pcpu")]
        public double Pcpu { get; set; }

        [JsonProperty("pcpuu")]
        public double Pcpuu { get; set; }

        [JsonProperty("pmem")]
        public double Pmem { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("mem_vsz")]
        public double MemVsz { get; set; }

        [JsonProperty("mem_rss")]
        public double MemRss { get; set; }

        [JsonProperty("nice")]
        public double Nice { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("tty")]
        public string Tty { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("command")]
        public string Command { get; set; }
    }

    public class RootObjectProcesses
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("request_datetime")]
        public DateTime RequestDateTime { get; set; }

        [JsonProperty("list_process")]
        public Processes ListProcess { get; set; }
    }
}
