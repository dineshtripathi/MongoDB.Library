using System.Threading.Tasks;

namespace MongoDB.Client.Library.Interfaces
{
    public interface IProvideConfiguration
    {
        Task<IMongoDbRepositoryClient<Account>> Connect();
    }
}