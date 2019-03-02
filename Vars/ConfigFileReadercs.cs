using System;
using System.Collections.Generic;
using System.IO;

namespace Radium_utxo_server
{
    public class ConfigFileReader
    {
        private Dictionary<string, string> options = new Dictionary<string, string>();

        public ConfigFileReader()
        {
            string path = Directory.GetCurrentDirectory().ToString() + "\\config.conf";

            if (!File.Exists(path))
                return;
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.Peek() >= 0)
                {
                    string line = null;
                    // Read the stream to a string and write the string to the console.
                    line = sr.ReadLine();
                    if (line.StartsWith("#"))
                        continue;
                    options.Add(line.Substring(0, line.IndexOf("=")), line.Remove(0, line.IndexOf("=") + 1));
                }
            }
        }

        public string lookup(string key)
        {
            if (!options.ContainsKey(key))
                throw new Exception("The key '" + key + "' was not set in the config: " + Directory.GetCurrentDirectory().ToString());
            return options[key];
        }

        public string lookup_or_default(string key)
        {
            if (!options.ContainsKey(key))
                return "";
            return options[key];
        }

        public bool haskey(string key)
        {
            return options.ContainsKey(key);
        }
    }
}