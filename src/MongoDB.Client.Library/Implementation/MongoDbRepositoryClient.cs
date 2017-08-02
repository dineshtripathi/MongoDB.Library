using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Client.Library.Interfaces;

namespace MongoDB.Client.Library.Implementation
{
    public class MongoDbRepositoryClient<T> : IMongoDbRepositoryClient<IProvideFluentApi> 
    {
        public MongoDbRepositoryClient(T repositoryepository) 
        {
        }

        public Task<IEnumerable<IProvideFluentApi>> GetAll(IProvideFluentApi input)
        {
            throw new NotImplementedException();
        }

        public Task DoInsertInBulk(Action<IProvideFluentApi> callback)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IProvideFluentApi>> Query(Predicate<IProvideFluentApi> predicate)
        {
            throw new NotImplementedException();
        }
    }
}