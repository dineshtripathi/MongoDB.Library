using System.Threading.Tasks;
using Infinity.WithNoSql.Repository.Client.Library.ConfigurationItem;

namespace Infinity.WithNoSql.Repository.Client.Library.Interfaces
{
    public interface IProvideFluentApi
    {
        Task<IProvideConfiguration> Configure(ConfigurationJson configurationJson);
    }

    public class ProvideFluentApi : IProvideFluentApi
    {
        public Task<IProvideConfiguration> Configure(ConfigurationJson configurationJson)
        {
            throw new System.NotImplementedException();
        }
    }
}