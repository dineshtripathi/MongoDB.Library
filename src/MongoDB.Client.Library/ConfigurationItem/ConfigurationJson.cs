using System;

namespace MongoDB.Client.Library
{
    [Serializable]
    public class ConfigurationJson
    {
        public string ConnectionString { get; set; }
        public bool IsHttps { get; set; }
    }
}