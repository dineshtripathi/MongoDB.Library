using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoDB.Client.Library.Interfaces
{
    public interface IMongoDbRepositoryClient<TInVariant>
    {
        Task<IEnumerable<TInVariant>> GetAll(TInVariant input);
        Task DoInsertInBulk(Action<TInVariant> callback);
        Task<IEnumerable<TInVariant>> Query(Predicate<TInVariant> predicate);
    }
}