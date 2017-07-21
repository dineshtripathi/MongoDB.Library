using System;
using System.Threading.Tasks;
using MongoDB.Repository.Poco;
using MongoDBApplicaiton.FluentConfiguration;

namespace MongoDBApplicaiton
{
    public class MongoDbRepository : IMongoDbRepository
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
    }
}