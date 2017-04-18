using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPiMonUWP.ObjectModels.ManagementObjects.Sysinfo.Cpu
{
    public class CpuTemperature
    {
    }

    public class RootObjectCpuTemperature
    {
        public string Token { get; set; }
        public DateTime RequestDateTime { get; set; }
        public CpuTemperature CpuTemperature { get; set; }
    }
}
