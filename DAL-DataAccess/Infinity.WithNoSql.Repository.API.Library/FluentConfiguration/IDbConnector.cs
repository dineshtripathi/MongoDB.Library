using MongoDB.Driver.Core.Authentication;

namespace Infinity.WithNoSql.Repository.API.Library.FluentConfiguration
{
    public interface IDbConnector
    {
        IDbConnector Configure();
        IDbConnector WithCredentials(UsernamePasswordCredential credential);
        IDbConnector ForDatabase(string databaseName);
        bool IsConnectionSucceeded();
    }
}