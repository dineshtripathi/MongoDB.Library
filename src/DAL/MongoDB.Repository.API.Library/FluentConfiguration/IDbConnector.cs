using MongoDB.Driver.Core.Authentication;

namespace MongoDB.Repository.API.Library.FluentConfiguration
{
    public interface IDbConnector
    {
        IDbConnector Configure();
        IDbConnector WithCredentials(UsernamePasswordCredential credential);
        IDbConnector ForDatabase(string databaseName);
        bool IsConnectionSucceeded();
    }
}