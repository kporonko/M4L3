using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OfficeEntity
{
    internal class Services
    {
        public ConnectionString Deserialization()
        {
            string path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).FullName).FullName).FullName + "\\config.json";
            var configFile = File.ReadAllText(path, Encoding.UTF8);
            var config = JsonConvert.DeserializeObject<ConnectionString>(configFile);
            return config;
        }
    }
}
