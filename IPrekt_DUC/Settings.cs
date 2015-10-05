using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPrekt_DUC
{
    class Settings
    {

        public static string get(string key, string default_value)
        {
            try { return (string)Properties.Settings.Default[key]; }
            catch (Exception) { return default_value; }
        }
        public static int get(string key, int default_value)
        {
            try { return (int)Properties.Settings.Default[key]; }
            catch (Exception) { return default_value; }
        }
        public static bool get(string key, bool default_value)
        {
            try { return (bool)Properties.Settings.Default[key]; }
            catch (Exception) { return default_value; }
        }



        public static void set(string key, string value)
        {
            Properties.Settings.Default[key] = value;
            Properties.Settings.Default.Save();
        }
        public static void set(string key, int value)
        {
            Properties.Settings.Default[key] = value;
            Properties.Settings.Default.Save();
        }
        public static void set(string key, bool value)
        {
            Properties.Settings.Default[key] = value;
            Properties.Settings.Default.Save();
        }

    }
}
