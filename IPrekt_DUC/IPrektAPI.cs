﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace IPrekt_DUC
{
    class IPrektAPI
    {
        private static string URL_UPDATE = "http://api.iprekt.com/?api=update&name=%n&pass=%p&format=bool";
        private static string URL_EXISTS = "http://api.iprekt.com/?api=exists&name=%n&format=bool";
        

        public static bool update(string address, string password)
        {
            try
            {
                WebClient wc = new WebClient(); wc.Proxy = null;

                string url = URL_UPDATE;
                url = url.Replace("%n", address);
                url = url.Replace("%p", password);

                return wc.DownloadString(url).Trim().Equals("1");
            }
            catch (Exception) { }
            return false;
        }

        public static bool exists(string address, string password)
        {
            try
            {
                WebClient wc = new WebClient(); wc.Proxy = null;

                string url = URL_EXISTS;
                url = url.Replace("%n", address);
                url = url.Replace("%p", password);

                return wc.DownloadString(url).Trim().Equals("1");
            }
            catch (Exception) { }
            return false;
        }


        
    }
}