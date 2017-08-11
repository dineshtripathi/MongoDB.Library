using System;

namespace Infinity.WithNoSql.Repository.PocoJson.Model
{
    [Serializable]
    public class MongoDbTableEntityBase
    {
        
        public string RowKeyId { get; set; }
    }
}