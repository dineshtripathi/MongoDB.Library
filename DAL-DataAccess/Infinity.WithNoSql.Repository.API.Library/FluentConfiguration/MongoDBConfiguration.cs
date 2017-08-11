namespace Infinity.WithNoSql.Repository.API.Library.FluentConfiguration
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
