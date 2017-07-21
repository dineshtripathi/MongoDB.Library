using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Repository.Library;

namespace MongoDB.Client.Library
{
    public class MongoDbRepositoryClient : IMongoDbRepositoryClient
    {
        public MongoDbRepositoryClient(IMongoDbRepository repositoryepository)
        {
        }

        public Task<IEnumerable<Account>> GetAllAccounts()
        {
            throw new NotImplementedException();
        }
    }
}