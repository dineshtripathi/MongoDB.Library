using System.Threading.Tasks;
using Infinity.WithNoSql.Repository.PocoJson.Model;

namespace Infinity.WithNoSql.Repository.Client.Library.Interfaces
{
    public interface IProvideConfiguration
    {
        Task<IMongoDbRepositoryClient<AccountModel>> Connect();
    }
}