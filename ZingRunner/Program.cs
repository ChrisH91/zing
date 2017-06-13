using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZingLib;

namespace ZingRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var miner = new Nheqminer();
            miner.Start();
        }
    }
}
