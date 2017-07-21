using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MongoDB.Repository.Poco
{
    public abstract class BaseMongoDbTableEntity
    {
        
        public object RowKey { get; set; }
        public object RowGuid { get; set; }
    }

    public class Account : BaseMongoDbTableEntity ,IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
