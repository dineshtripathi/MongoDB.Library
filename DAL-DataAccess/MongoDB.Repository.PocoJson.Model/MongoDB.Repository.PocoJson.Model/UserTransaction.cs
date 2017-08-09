using System;

namespace MongoDB.Repository.JsonPoco.Model
{
    [Serializable]
    public class UserTransaction : MongoDbTableEntityBase
    {
        public string GuidTransactionId { get; set; }
        public string TransactionGivenName { get; set; }
        public string TransactionReference { get; set; }
        public string TransactionType { get; set; }
        public string TransactionDateTime { get; set; }
        
    }
}
