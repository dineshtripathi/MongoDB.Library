using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoDB.Client.Library
{
    public interface IMongoDbRepositoryClient
    {
        Task<IEnumerable<Account>> GetAllAccounts();
    }
}