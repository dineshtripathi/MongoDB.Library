using System;
using System.Threading.Tasks;
using MongoDB.Repository.Library.FluentConfiguration;
using MongoDB.Repository.Poco;

namespace MongoDB.Repository.Library
{
    public class MongoDbRepository : IMongoDbRepository,IDisposable
    {
        private readonly IDbConnector _configuration;

        public MongoDbRepository(IDbConnector configuration)
        {
            _configuration = configuration;
        }
        public Task<IMongoDbRepository> Create(Account account)
        {
            throw new NotImplementedException();
        }

        public Task<IMongoDbRepository> Update(Account account)
        {
            throw new NotImplementedException();
        }

        public Task<IMongoDbRepository> Delete(Account account)
        {
            throw new NotImplementedException();
        }

        public Task<IMongoDbRepository> Query(Account account)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}