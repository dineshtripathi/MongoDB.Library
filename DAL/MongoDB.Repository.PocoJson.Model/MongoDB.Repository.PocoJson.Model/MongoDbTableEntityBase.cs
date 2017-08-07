using System;

namespace MongoDB.Repository.JsonPoco.Model
{
    [Serializable]
    public class MongoDbTableEntityBase
    {
        
        public string RowKeyId { get; set; }
    }
}