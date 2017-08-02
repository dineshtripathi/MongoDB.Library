using System.Threading.Tasks;

namespace MongoDB.Client.Library.Interfaces
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