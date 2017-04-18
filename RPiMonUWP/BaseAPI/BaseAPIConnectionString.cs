using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPiMonUWP.BaseAPI
{
    public static class BaseAPIConnectionString
    {

        public static string FetchAllUserConnUrl(string token)
        {
            return $"http://localhost:3000/api/oauth/user/fetchAll?access_token={token}";
        }

        public static string FetchUserByUserNameUrl(string token, string username)
        {
            return $"http://localhost:3000/api/oauth/user/fetch?access_token={token}&username={username}";
        }

        public static string LoginUrl(string token)
        {
            return $"http://localhost:3000/api/oauth/user/login?access_token={token}";
        }

        public static string UpdateUserUrl(string token)
        {
            return $"http://localhost:3000/api/oauth/user/update?access_token={token}";
        }

        public static string UpdateRole(string token)
        {
            return $"http://localhost:3000/api/oauth/user/update/role?access_token={token}";
        }

        public static string DeleteUserUrl(string token)
        {
            return $"http://localhost:3000/api/oauth/user/delete?access_token={token}";
        }

        public static string AddUserUrl(string token)
        {
            return $"http://localhost:3000/api/oauth/user/create?access_token={token}";
        }

        public static string GetCpuInfoUrl(string token)
        {
            return $"http://localhost:3000/api/oauth/sysinfo/cpuinfo?access_token={token}";
        }

        public static string GetCpuCacheUrl(string token)
        {
            return $"http://localhost:3000/api/oauth/sysinfo/cpucache?access_token={token}";
        }

        public static string GetCpuCurrentSpeedUrl(string token)
        {
            return $"http://localhost:3000/api/oauth/sysinfo/current_speed?access_token={token}";
        }

        public static string GetCpuFlagsUrl(string token)
        {
            return $"http://localhost:3000/api/oauth/sysinfo/cpu_flags?access_token={token}";
        }

        public static string GetCpuTempUrl(string token)
        {
            return $"http://localhost:3000/api/oauth/sysinfo/cpu_temp?access_token={token}";
        }

        public static string GetDockerUrl(string token)
        {
            return $"http://localhost:3000/api/oauth/sysinfo/docker?access_token={token}";
        }

        public static string GetDiskIOUrl(string token)
        {
            return $"http://localhost:3000/api/oauth/sysinfo/disk_io?access_token={token}";
        }

        public static string GetFileSystemSizeUrl(string token)
        {
            return $"http://localhost:3000/api/oauth/sysinfo/fs_size?access_token={token}";
        }

        public static string GetMemoryInfoUrl(string token)
        {
            return $"http://localhost:3000/api/oauth/sysinfo/mem_info?access_token={token}";
        }

        public static string GetOSInfoUrl(string token)
        {
            return $"http://localhost:3000/api/oauth/sysinfo/mem_info?access_token={token}";
        }

        public static string GetNetworkPropertiesUrl(string token)
        {
            return $"http://localhost:3000/api/oauth/sysinfo/network?access_token={token}";
        }

        public static string GetProcessesUrl(string token)
        {
            return $"http://localhost:3000/api/oauth/sysinfo/process?access_token={token}";
        }

        public static string GetProcessLoad(string token)
        {
            return $"http://localhost:3000/api/oauth/sysinfo/proc_load?access_token={token}";
        }

        public static string GetServicesUrl(string token)
        {
            return $"http://localhost:3000/api/oauth/sysinfo/service?access_token={token}";
        }

        public static string GetBlockDevices(string token)
        {
            return $"http://localhost:3000/api/oauth/sysinfo/block_device?access_token={token}";
        }
    }
}
