using System.Threading.Tasks;
using MongoDB.Repository.Client.Library.ConfigurationItem;

namespace MongoDB.Repository.Client.Library.Interfaces
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