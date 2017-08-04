using System;

namespace MongoDB.Repository.Client.Library.ConfigurationItem
{
    
    public class ConfigurationJson
    {
        public string ConnectionString { get; set; }
        public bool IsHttps { get; set; }
    }
}