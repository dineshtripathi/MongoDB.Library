using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using MongoDB.Repository.Library;

namespace MongoDB.Client.Library
{
    public class MongoDbRepositoryClient<T> : IMongoDbRepositoryClient 
    {
        public MongoDbRepositoryClient(T repositoryepository) 
        {
        }

        public Task<IEnumerable<T>> GetAll<T>() where T : class, new()
        {
            throw new NotImplementedException();
        }
    }
}