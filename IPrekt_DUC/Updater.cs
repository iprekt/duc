using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.NetworkInformation;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace IPrekt_DUC
{
    public class Updater
    {
        private bool _alive = false;
        private Thread _thread = null;
        private string _publicIp = "";

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
            // Update logic.
            // TODO: Listen for network events, for an even faster IP-change detection.

            _publicIp = getPublicIp();
            updateAllAddresses();

            while (true)
            {
                waitNextRefreshRate();
                if (weHaveAddressesToUpdate() && publicIpChanged())
                {
                    updateAllAddresses();
                }
            }
        }

        private bool weHaveAddressesToUpdate()
        {
            return AddressList.getList().Count > 0;
        }


        public void updateAllAddresses()
        {
            List<string> successList = new List<string>();
            List<string> failList = new List<string>();

            foreach (KeyValuePair<string, string> entry in AddressList.getList())
            {
                string address = entry.Key;
                string password = entry.Value;

                bool ok = IPrektAPI.update(address, password);

                (ok ? successList : failList).Add(address);
            }

            if (successList.Count> 0)   Notify.notify("Update success", successList.Count   + " addresse(s) updated !", "notifyUpdateSuccess");
            if (failList.Count > 0)     Notify.notify("Update failed",  failList.Count      + " addresse(s) failed to update !", "notifyUpdateFail");
        }

        private bool publicIpChanged()
        {
            string curIP = getPublicIp();
            bool changed = _publicIp != curIP;
            if (changed) _publicIp = curIP;
            return changed;
        }


        private void waitNextRefreshRate()
        {
            // This makes sure the loop can instantlu exit in-
            // case the user lowers the delay in the settings.

            int t = Environment.TickCount;
            while ((Environment.TickCount-t) < Properties.Settings.Default.Setting_refreshRate * 60 * 1000)
            {
                Thread.Sleep(1000);
            }
        }

        private static string getPublicIp()
        {
            try
            {
                // Trying third party services to balance the load :

                string data = Settings.get("Setting_ipServiceList", "");
                string[] sett = data.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                sett = Tools.shuffleArray(sett);

                foreach (string line in sett)
                {
                    if (!line.Contains("|")) continue;

                    string[] st = line.Split(new char[]{'|'}, 2);
                    string url = st[0].Trim(); if (url.Length < 1) continue;
                    string regex = st[1].Trim(); if (regex.Length < 1) continue;

                    try
                    {
                        WebClient wc = Tools.getWebClient();
                        string html = wc.DownloadString(url);

                        string ip = Regex.Match(html, regex).Groups[1].Value;
                        if (Tools.isValideIp(ip)) return ip;
                    }
                    catch (Exception) {};
                }

                // If all fails, use the official API :

                return IPrektAPI.getIp();
            }
            catch (Exception) { }
            throw new Exception("Could not get the public IP.");
        }

    }
}
