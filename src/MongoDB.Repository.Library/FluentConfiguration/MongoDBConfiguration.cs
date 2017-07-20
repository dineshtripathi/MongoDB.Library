using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace MongoDBApplicaiton.FluentConfiguration
{
    public class MongoDbConfiguration
    {
        public ConnectionString ConnectionString { get; set; }
        public Database Database { get; set; }
        public Credentials Credentials { get; set; }
        public bool IsClustered { get; set; }
        public bool IsGeoReplicated { get; set; }
    }
}
