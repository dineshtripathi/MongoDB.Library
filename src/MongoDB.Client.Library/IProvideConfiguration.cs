using System.Threading.Tasks;

namespace MongoDB.Client.Library
{
    public interface IProvideConfiguration
    {
        Task<IMongoDbRepositoryClient<Account>> Connect();
    }
}