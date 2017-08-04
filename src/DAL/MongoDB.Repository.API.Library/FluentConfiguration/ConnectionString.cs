using System.Collections.Generic;

namespace MongoDB.Repository.API.Library.FluentConfiguration
{
    public class ConnectionString
    {
        public string IpAddress { get; set; }
        public string PortNumber { get; set; }
        public bool IsAuthorized { get; set; }
    }

    public class Credentials
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string JWTToken { get; set; }
    }

    public class Database
    {
        public string LocalDBPath { get; set; }
        public string DatabaseName { get; set; }
        public ConnectionString ConnectionString { get; set; }
        public Credentials Credentials { get; set; }
    }

    public class Group
    {
        public Database Database { get; set; }
    }

    public class MongoDbSettings
    {
        public List<Group> Group { get; set; }
        public bool IsClustered { get; set; }
        public bool IsGeoReplicated { get; set; }
    }
}