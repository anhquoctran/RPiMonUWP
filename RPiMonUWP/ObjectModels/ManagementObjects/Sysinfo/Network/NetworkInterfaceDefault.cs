using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPiMonUWP.ObjectModels.ManagementObjects.Sysinfo.Network
{
    public class NetworkInterfaceDefault
    {
        public string IfaceName { get; set; }
        
    }

    public class RootObjectNetIfaceDefault
    {
        public string Token { get; set; }
        public DateTime RequestDateTime { get; set; }
        public NetworkInterfaceDefault NetIfaceDefault { get; set; }
    }
}
