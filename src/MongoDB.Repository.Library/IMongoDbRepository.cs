using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using MongoDB.Repository.Poco;

namespace MongoDBApplicaiton
{
    public interface IMongoDbRepository
    {
        Task<IMongoDbRepository> Create(Account account);
        Task<IMongoDbRepository> Update(Account account);
        Task<IMongoDbRepository> Delete(Account account);
        Task<IMongoDbRepository> Query(Account account);
    }
}