using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RPiMonUWP.ObjectModels.ManagementObjects.Sysinfo.Cpu;
using RPiMonUWP.BaseAPI;
using RPiMonUWP.ObjectModels.ManagementObjects.Sysinfo.BlockDevice;
using RPiMonUWP.ObjectModels.ManagementObjects.Sysinfo.IO;
using RPiMonUWP.ObjectModels.ManagementObjects.Sysinfo.Memory;
using RPiMonUWP.ObjectModels.ManagementObjects.Sysinfo.Network;
using RPiMonUWP.ObjectModels.ManagementObjects.Sysinfo.OS;
using RPiMonUWP.ObjectModels.ManagementObjects.Sysinfo.Process;
using RPiMonUWP.ObjectModels.ManagementObjects.Sysinfo.System;
using RPiMonUWP.ObjectModels.ManagementObjects.Sysinfo.User;

namespace RPiMonUWP.ViewModels
{
    public class SysInfoViewModel 
    {
        public SysInfoViewModel(string token)
        {
            _token = token;
        }
        private static string _token;
        public async Task<Cpu> GetCpuInfoAsync()
        {
            
            Cpu result;
            try
            {
                var http = new HttpClient();
                var urlRequest = BaseAPIConnectionString.GetCpuInfoUrl(_token);

                var response = await http.GetAsync(urlRequest);
                var results = await response.Content.ReadAsStringAsync();
                var deserialize = JsonConvert.DeserializeObject<RootObjectCpu>(results);
                result = deserialize.Cpu;
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message);
            }

            return result;
        }

        public async Task<CpuCurrentSpeed> GetCpuCurrentSpeedAsync()
        {
            CpuCurrentSpeed result;
            try
            {
                var http = new HttpClient();
                var urlRequest = BaseAPIConnectionString.GetCpuCurrentSpeedUrl(_token);

                var response = await http.GetAsync(urlRequest);
                var results = await response.Content.ReadAsStringAsync();
                var deserialize = JsonConvert.DeserializeObject<RootObjectCpuCurrentSpeed>(results);
                result = deserialize.CpuCurrentSpeed;
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message);
            }
            return result;
        }

        public async Task<CpuCache> GetCpuCacheAsync()
        {
            CpuCache result;
            try
            {
                var http = new HttpClient();
                var urlRequest = BaseAPIConnectionString.GetCpuCacheUrl(_token);

                var response = await http.GetAsync(urlRequest);
                var results = await response.Content.ReadAsStringAsync();
                var deserialize = JsonConvert.DeserializeObject<RootObjectCpuCache>(results);
                result = deserialize.CpuCache;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return result;
        }

        public async Task<List<string>> GetCpuFlagsAsync()
        {
            List<string> result;
            try
            {
                var http = new HttpClient();
                var urlRequest = BaseAPIConnectionString.GetCpuFlagsUrl(_token);

                var response = await http.GetAsync(urlRequest);
                var results = await response.Content.ReadAsStringAsync();
                var deserialize = JsonConvert.DeserializeObject<RootObjectCpuFlags>(results);
                result = deserialize.Flags.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return result;
        }

        public async Task<Memory> GetMemoryAsync()
        {
            Memory result;
            try
            {
                var http = new HttpClient();
                var urlRequest = BaseAPIConnectionString.GetMemoryInfoUrl(_token);

                var response = await http.GetAsync(urlRequest);
                var results = await response.Content.ReadAsStringAsync();
                var deserialize = JsonConvert.DeserializeObject<RootObjectMemory>(results);

                result = deserialize.MemoryProperties;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return result;
        }

        public async Task<List<NetworkInterfaces>> GetNetworkInterfacesAsync()
        {
            List<NetworkInterfaces> result;
            try
            {
                var http = new HttpClient();
                var urlRequest = BaseAPIConnectionString.GetNetworkPropertiesUrl(_token);
                var response = await http.GetAsync(urlRequest);
                var results = await response.Content.ReadAsStringAsync();
                var deserialize = JsonConvert.DeserializeObject<RootObjectNetIfaces>(results);
                result = deserialize.NetIfaceList.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return result;
        }

        public async Task<List<NetworkConnections>> GetNetworkConnectionsAsync()
        {
            List<NetworkConnections> result;
            try
            {
                var http = new HttpClient();
                var urlRequest = BaseAPIConnectionString.GetNetworkConnectionsUrl(_token);

                var response = await http.GetAsync(urlRequest);
                var results = await response.Content.ReadAsStringAsync();
                var deserialize = JsonConvert.DeserializeObject<RootObjectNetConnections>(results);
                result = deserialize.ListConnections.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return result;
        }

        public async Task<List<Device>> GetDevicesAsync()
        {
            List<Device> result;
            try
            {
                var http = new HttpClient();
                var urlRequest = BaseAPIConnectionString.GetBlockDevicesUrl(_token);

                var response = await http.GetAsync(urlRequest);
                var results = await response.Content.ReadAsStringAsync();
                var deserialize = JsonConvert.DeserializeObject<RootObjectDevice>(results);

                result = deserialize.BlockDevices.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return result;
        }

        public async Task<List<SystemUser>> GetSystemUserAsync()
        {
            List<SystemUser> result;
            try
            {
                var http = new HttpClient();
                var urlRequest = BaseAPIConnectionString.GetSystemUserUrl(_token);

                var response = await http.GetAsync(urlRequest);
                var results = await response.Content.ReadAsStringAsync();
                var deserialize = JsonConvert.DeserializeObject<RootObjectSystemUser>(results);
                result = deserialize.Users.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return result;
        }

        public async Task<OSInfo> GetOSInfoAsync()
        {
            OSInfo result;
            try
            {
                var http = new HttpClient();
                var urlRequest = BaseAPIConnectionString.GetOSInfoUrl(_token);
                var response = await http.GetAsync(urlRequest);
                var results = await response.Content.ReadAsStringAsync();
                var deserialize = JsonConvert.DeserializeObject<RootObjectOSInfo>(results);
                result = deserialize.OSInformation;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return result;
        }

        public async Task<SystemInformation> GetSystemInformationAsync()
        {
            SystemInformation result;
            try
            {
                var http = new HttpClient();
                var urlRequest = BaseAPIConnectionString.GetSystemInfoUrl(_token);
                var response = await http.GetAsync(urlRequest);
                var results = await response.Content.ReadAsStringAsync();
                var deserialize = JsonConvert.DeserializeObject<RootObjectSi>(results);
                result = deserialize.Si;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return result;
        }

        public async Task<Processes> GetProcessesAsync()
        {
            Processes result;
            try
            {
                var http = new HttpClient();
                var urlRequest = BaseAPIConnectionString.GetProcessesUrl(_token);
                var response = await http.GetAsync(urlRequest);
                var results = await response.Content.ReadAsStringAsync();
                var deserialize = JsonConvert.DeserializeObject<RootObjectProcesses>(results);
                result = deserialize.ListProcess;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return result;
        }

        public async Task<DiskIo> GetDiskIoAsync()
        {
            DiskIo result;
            try
            {
                var http = new HttpClient();
                var urlRequest = BaseAPIConnectionString.GetDiskIOUrl(_token);
                var response = await http.GetAsync(urlRequest);
                var results = await response.Content.ReadAsStringAsync();
                var deserialize = JsonConvert.DeserializeObject<RootObjectDisk>(results);
                result = deserialize.Io;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return result;
        }
    }
}
