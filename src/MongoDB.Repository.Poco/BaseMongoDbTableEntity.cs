using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MongoDB.Repository.Poco
{
    //All of the poco object should derive from this base class
    public abstract class BaseMongoDbTableEntity
    {
        
        public object RowKey { get; set; }
        public object RowGuid { get; set; }
        public virtual bool CheckBaseType()
        {
            return this.GetType() == typeof(BaseMongoDbTableEntity);
        }
    }
}
