using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPrekt_DUC
{
    class AddressList
    {
        private static Dictionary<string, string> _list = new Dictionary<string, string>();

        

        public static bool add(string address, string password)
        {
            address = address.Trim().ToLower();
            if (!IPrektAPI.exists(address, password, true)) return false;

            lock (_list)
            {
                if (_list.ContainsKey(address))
                    _list.Remove(address);
                _list.Add(address, password);
            }
            save();
            return true;
        }

        public static bool remove(string address)
        {
            bool success = false;
            address = address.Trim().ToLower();
            lock (_list)
            {
                success = _list.Remove(address);            
            }
            if (success) save();
            return success;
        }

        public static void removeAll()
        {
            lock (_list) { _list.Clear(); }
            save();
        }


        private static void save()
        {
            string buffer = "";

            lock (_list)
            {
                foreach (KeyValuePair<string, string> e in _list)
                    buffer += e.Key + "|" + e.Value + "\r\n";
            }

            Properties.Settings.Default.AddressList = buffer;
            Properties.Settings.Default.Save();
        }

        private static void load()
        {
            lock (_list)
            {
                _list.Clear();
                string[] sett = Properties.Settings.Default.AddressList.Split(new char[] { '\r', '\n' });
                foreach (string line in sett)
                {
                    if (line.Trim().Length < 1) continue;
                    string[] st = line.Split(new char[] { '|' });
                    _list.Add(st[0], st[1]);
                }
            }
        }

        private static bool _alreadyInit = false;
        public static void init()
        {
            if (_alreadyInit) return; _alreadyInit = true;
            load();
        }

        public static Dictionary<string, string> getList()
        {
            lock (_list)
            {
                return new Dictionary<string, string>(_list);
            }
        }
    }
}
