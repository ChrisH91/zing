using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using ZingLib;

namespace Zing
{
    public partial class ZingService : ServiceBase
    {
        IMiner miner;

        public ZingService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {

            miner = new Nheqminer();
            miner.Start();
        }

        protected override void OnStop()
        {
            miner.Stop();
        }
    }
}
