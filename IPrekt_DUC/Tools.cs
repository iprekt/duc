using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace IPrekt_DUC
{
    class Tools
    {
        public static WebClient getWebClient()
        {
            WebClient wc = new WebClient();
            
            // For some reason we get a speed boost when sending multiple GET requests, if Proxy is set to null.
            // More info : http://stackoverflow.com/questions/4415443/system-net-webclient-unreasonably-slow
            
            if (Properties.Settings.Default.Setting_useProxy == false)
                wc.Proxy = null; 

            return wc;
        }

        public static bool isValideIp(string ip)
        {
            System.Net.IPAddress ipAddress = null;
            return System.Net.IPAddress.TryParse(ip, out ipAddress);
        }

        public static string[] shuffleArray(string[] arr)
        {
            Random rnd = new Random();
            string[] randomArray = arr.OrderBy(x => rnd.Next()).ToArray();
            return randomArray;
        }
    }
}
