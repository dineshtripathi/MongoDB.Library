using System.Threading.Tasks;
using MongoDB.Repository.JsonPoco.Model;

namespace MongoDB.Repository.Client.Library.Interfaces
{
    public interface IProvideConfiguration
    {
        Task<IMongoDbRepositoryClient<AccountModel>> Connect();
    }
}