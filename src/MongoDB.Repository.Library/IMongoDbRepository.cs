using System.Threading.Tasks;
using MongoDB.Repository.Poco;

namespace MongoDB.Repository.Library
{
    public interface IMongoDbRepository
    {
        Task<IMongoDbRepository> Create(Account account);
        Task<IMongoDbRepository> Update(Account account);
        Task<IMongoDbRepository> Delete(Account account);
        Task<IMongoDbRepository> Query(Account account);
    }
}