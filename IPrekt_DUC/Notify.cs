using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace IPrekt_DUC
{
    class Notify
    {
        private static frmMain _frm = null;
        private static List<object[]> _queue = new List<object[]>();
        private static Thread _thread = null;

        public static void init(frmMain instance)
        {
            _frm = instance;

            _thread = new Thread(run);
            _thread.Start();
        }


        private static void run()
        {
            while(true)
            {
                Thread.Sleep(2000);

                object[] next = null;
                lock (_queue)
                {
                    if (_queue.Count < 1) continue;
                    next = _queue.First();
                    _queue.RemoveAt(0);
                }

                string title = next[0] as string;
                string message = next[1] as string;
                ToolTipIcon tti = (ToolTipIcon)next[2];

                _frm.Invoke(new Action(() =>
                {
                    try
                    {
                        NotifyIcon ctrl = _frm.getNotifyIcon();
                        ctrl.ShowBalloonTip(4000, title, message, tti);
                    }
                    catch (Exception) { }
                }));
            }
        }

        public static void notify(string title, string message)
        {
            notify(title, message, "");
        }


        public static void notify(string title, string message, string id)
        {
            ToolTipIcon tti = ToolTipIcon.None;

            switch (id)
            {
                case "notifyUpdateSuccess": tti = ToolTipIcon.Info; if (!Properties.Settings.Default.Setting_notifyUpdateSuccess) return; break;
                case "notifyUpdateFail": tti = ToolTipIcon.Warning; if (!Properties.Settings.Default.Setting_notifyUpdateFail) return; break;
            }

            lock (_queue)
            {
                _queue.Add(new object[] { title, message, tti });
            }
        }
    }
}
