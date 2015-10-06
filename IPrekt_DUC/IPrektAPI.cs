using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace IPrekt_DUC
{
    class IPrektAPI
    {
        private static string URL_UPDATE    = "http://api.iprekt.com/?api=update&name=%n&pass=%p&format=bool&from=duc";
        private static string URL_EXISTS    = "http://api.iprekt.com/?api=exists&name=%n&pass=%p&format=bool&from=duc";
        private static string URL_GETIP     = "http://api.iprekt.com/?api=getip&from=duc";

        public static bool update(string address, string password)
        {
            try
            {
                WebClient wc = Tools.getWebClient();

                string url = URL_UPDATE;
                url = url.Replace("%n", Uri.EscapeDataString(address));
                url = url.Replace("%p", Uri.EscapeDataString(password));

                return wc.DownloadString(url).Trim().Equals("1");
            }
            catch (Exception) { }
            return false;
        }

        public static bool exists(string address, string password)
        {
            try
            {
                WebClient wc = Tools.getWebClient();

                string url = URL_EXISTS;
                url = url.Replace("%n", Uri.EscapeDataString(address));
                url = url.Replace("%p", Uri.EscapeDataString(password));

                return wc.DownloadString(url).Trim().Equals("1");
            }
            catch (Exception) { }
            return false;
        }

        public static string getIp()
        {
            try
            {
                WebClient wc = Tools.getWebClient();
                string ip = wc.DownloadString(URL_GETIP).Trim();
                
                if (!Tools.isValideIp(ip)) throw new Exception("Invalid response.");

                return ip;
            }
            catch (Exception) { }
            throw new Exception("Could not get the IP through IPrekt API system.");
        }


        
    }
}
