using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Zing
{
    public partial class ZingService : ServiceBase
    {
        public ZingService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            var miner = new Miner();
        }

        protected override void OnStop()
        {
        }
    }
}
