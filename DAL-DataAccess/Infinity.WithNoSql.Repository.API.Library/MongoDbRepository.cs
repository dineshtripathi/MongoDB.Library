using System;
using System.Threading.Tasks;
using Infinity.WithNoSql.Repository.API.Library.FluentConfiguration;
using Infinity.WithNoSql.Repository.PocoJson.Model;

namespace Infinity.WithNoSql.Repository.API.Library
{
    public class MongoDbRepository : IMongoDbRepository,IDisposable
    {
        private readonly IDbConnector _configuration;

        public MongoDbRepository(IDbConnector configuration)
        {
            _configuration = configuration;
        }
        public Task<IMongoDbRepository> Create(AccountModel account)
        {
            throw new NotImplementedException();
        }

        public Task<IMongoDbRepository> Update(AccountModel account)
        {
            throw new NotImplementedException();
        }

        public Task<IMongoDbRepository> Delete(AccountModel account)
        {
            throw new NotImplementedException();
        }

        public Task<IMongoDbRepository> Query(AccountModel account)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}