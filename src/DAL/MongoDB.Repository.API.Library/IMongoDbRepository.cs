using System.Threading.Tasks;
using MongoDB.Repository.JsonPoco.Model;

namespace MongoDB.Repository.API.Library
{
    public interface IMongoDbRepository
    {
        Task<IMongoDbRepository> Create(AccountModel account);
        Task<IMongoDbRepository> Update(AccountModel account);
        Task<IMongoDbRepository> Delete(AccountModel account);
        Task<IMongoDbRepository> Query(AccountModel account);
    }
}