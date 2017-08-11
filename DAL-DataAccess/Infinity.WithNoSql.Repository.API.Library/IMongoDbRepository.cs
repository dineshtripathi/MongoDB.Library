using Infinity.WithNoSql.Repository.PocoJson.Model;
using System.Threading.Tasks;

namespace Infinity.WithNoSql.Repository.API.Library
{
    public interface IMongoDbRepository
    {
        Task<IMongoDbRepository> Create(AccountModel account);
        Task<IMongoDbRepository> Update(AccountModel account);
        Task<IMongoDbRepository> Delete(AccountModel account);
        Task<IMongoDbRepository> Query(AccountModel account);
    }
}