using MongoDB.Driver.Core.Authentication;

namespace Infinity.WithNoSql.Repository.API.Library.FluentConfiguration
{
    public class DbConnector : IDbConnector
    {
        public IDbConnector Configure()
        {
            throw new System.NotImplementedException();
        }

        public IDbConnector WithCredentials(UsernamePasswordCredential credential)
        {
            throw new System.NotImplementedException();
        }

        public IDbConnector ForDatabase(string databaseName)
        {
            throw new System.NotImplementedException();
        }

        public bool IsConnectionSucceeded()
        {
            throw new System.NotImplementedException();
        }
    }
}