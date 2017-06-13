using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZingLib
{
    public class Nheqminer : IMiner
    {
        protected string ProcessFileName = @"C:\nheqminer\nheqminer.exe";

        public string PoolUrl = "zec-us-west1.nanopool.org";
        public int PoolPort = 6666;
        public string ZCashAddress = "t1VrxdseWo7a97XkcyyosnGREfW9rETVEaK";
        public string MachineName = "aphrodite";
        public string Email = "chrishoward91@gmail.com";

        public List<int> CudaDevices = new List<int>() { 0, 1 };
        public int Threads = 8;

        protected Process process;

        public void Start()
        {
            var cudaString = CudaDevices.Count > 0 ? $"-cd {String.Join(" ", CudaDevices)}" : "";
            var cpuString = Threads > 0 ? $"-t {Threads}" : "";

            var argumentString = $"-l {PoolUrl}:{PoolPort} -u {ZCashAddress}/{MachineName}/{Email} {cudaString} {cpuString}";

            process = new Process();
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.FileName = ProcessFileName;
            process.StartInfo.Arguments = argumentString;
            process.Start();
        }

        public void Stop()
        {
            process.Kill();
        }
    }
}
