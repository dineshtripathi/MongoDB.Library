using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Repository.JsonPoco.Model;

namespace MongoDB.Repository.Client.Library.Interfaces
{
    public interface IMongoDbRepositoryClient<TInVariant> where TInVariant: MongoDbTableEntityBase 
    {
        Task<IEnumerable<TInVariant>> GetAll(TInVariant input);
        Task DoInsertInBulk(Action<TInVariant> callback);
        Task<IEnumerable<TInVariant>> Query(Predicate<TInVariant> predicate);
    }
}