using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace RPiMonUWP.BaseAPI
{
    public static class BaseAPIConnectionString
    {
        private static string Host = "http://localhost";
        private static int Port = 3000;
        public static string FetchAllUserConnUrl(string token)
        {
            return $"{Host}:{Port}/api/oauth/user/fetchAll?access_token={token}";
        }

        public static string FetchUserByUserNameUrl(string token, string username)
        {
            return $"{Host}:{Port}/api/oauth/user/fetch?access_token={token}&username={username}";
        }

        public static string LoginUrl()
        {
            return $"{Host}:{Port}/api/oauth/user/login";
        }

        public static string UpdateUserUrl(string token)
        {
            return $"{Host}:{Port}/api/oauth/user/update?access_token={token}";
        }

        public static string UpdateRole(string token)
        {
            return $"{Host}:{Port}/api/oauth/user/update/role?access_token={token}";
        }

        public static string DeleteUserUrl(string token)
        {
            return $"{Host}:{Port}/api/oauth/user/delete?access_token={token}";
        }

        public static string AddUserUrl(string token)
        {
            return $"{Host}:{Port}/api/oauth/user/create?access_token={token}";
        }

        public static string GetCpuInfoUrl(string token)
        {
            return $"{Host}:{Port}/api/oauth/sysinfo/cpuinfo?access_token={token}";
        }

        public static string GetCpuCacheUrl(string token)
        {
            return $"{Host}:{Port}/api/oauth/sysinfo/cpucache?access_token={token}";
        }

        public static string GetCpuCurrentSpeedUrl(string token)
        {
            return $"{Host}:{Port}/api/oauth/sysinfo/current_speed?access_token={token}";
        }

        public static string GetCpuFlagsUrl(string token)
        {
            return $"{Host}:{Port}/api/oauth/sysinfo/cpu_flags?access_token={token}";
        }

        public static string GetCpuTempUrl(string token)
        {
            return $"{Host}:{Port}/api/oauth/sysinfo/cpu_temp?access_token={token}";
        }

        public static string GetDiskIOUrl(string token)
        {
            return $"{Host}:{Port}/api/oauth/sysinfo/disk_io?access_token={token}";
        }

        public static string GetFileSystemSizeUrl(string token)
        {
            return $"{Host}:{Port}/api/oauth/sysinfo/fs_size?access_token={token}";
        }

        public static string GetMemoryInfoUrl(string token)
        {
            return $"{Host}:{Port}/api/oauth/sysinfo/mem_info?access_token={token}";
        }

        public static string GetOSInfoUrl(string token)
        {
            return $"{Host}:{Port}/api/oauth/sysinfo/mem_info?access_token={token}";
        }

        public static string GetNetworkPropertiesUrl(string token)
        {
            return $"{Host}:{Port}/api/oauth/sysinfo/networkifaces?access_token={token}";
        }

        public static string GetNetworkConnectionsUrl(string token)
        {
            return $"{Host}:{Port}/api/oauth/sysinfo/networkconns?acces_token={token}";
        }

        public static string GetProcessesUrl(string token)
        {
            return $"{Host}:{Port}/api/oauth/sysinfo/process?access_token={token}";
        }

        public static string GetProcessLoadUrl(string token)
        {
            return $"{Host}:{Port}/api/oauth/sysinfo/proc_load?access_token={token}";
        }

        public static string GetServicesUrl(string token)
        {
            return $"{Host}:{Port}/api/oauth/sysinfo/services?access_token={token}";
        }

        public static string GetBlockDevicesUrl(string token)
        {
            return $"{Host}:{Port}/api/oauth/sysinfo/block_device?access_token={token}";
        }

        public static string GetSystemUserUrl(string token)
        {
            return $"{Host}:{Port}/api/oauth/sysinfo/sysuser?access_token={token}";
        }

        public static string GetSystemInfoUrl(string token)
        {
            return $"{Host}:{Port}/api/oauth/sysinfo/sysproperties?access_token={token}";
        }
    }
}
