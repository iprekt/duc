using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.NetworkInformation;

namespace IPrekt_DUC
{
    class Updater
    {
        private bool _alive = false;
        private Thread _thread = null;

        public void start()
        {
            if (_alive) throw new Exception("Already running.");
            _thread = new Thread(run);
            _thread.Start();
        }

        private void run()
        {
            if (_alive) return;
            try
            {
                _alive = true;
                updateLoop();
            }
            finally
            {
                _alive = false;
            }
        }

        private void updateLoop()
        {
            // TODO: Update logic here.
        }

        private void waitForIpChange()
        {
            
        }

    }
}
