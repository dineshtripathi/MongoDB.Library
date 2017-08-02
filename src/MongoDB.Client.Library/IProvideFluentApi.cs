using System.Threading.Tasks;

namespace MongoDB.Client.Library
{
    public interface IProvideFluentApi
    {
        Task<IProvideConfiguration> Configure(ConfigurationJson configurationJson);
    }
}