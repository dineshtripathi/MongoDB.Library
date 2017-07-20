using MongoDB.Driver.Core.Authentication;

namespace MongoDBApplicaiton.FluentConfiguration
{
    public interface IDbConnector
    {
        IDbConnector Configure();
        IDbConnector WithCredentials(UsernamePasswordCredential credential);
        IDbConnector ForDatabase(string databaseName);
        bool IsConnectionSucceeded();
    }
}