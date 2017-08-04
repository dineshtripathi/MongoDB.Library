using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Repository.Client.Library.Interfaces;
using MongoDB.Repository.JsonPoco.Model;

namespace MongoDB.Repository.Client.Library.Implementation
{
    public class MongoDbRepositoryClient<T> : IMongoDbRepositoryClient<UserTransaction> 
    {
        public MongoDbRepositoryClient(T repositoryepository) 
        {
        }


        public Task<IEnumerable<UserTransaction>> GetAll(UserTransaction input)
        {
            throw new NotImplementedException();
        }

        public Task DoInsertInBulk(Action<UserTransaction> callback)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserTransaction>> Query(Predicate<UserTransaction> predicate)
        {
            throw new NotImplementedException();
        }
    }
}