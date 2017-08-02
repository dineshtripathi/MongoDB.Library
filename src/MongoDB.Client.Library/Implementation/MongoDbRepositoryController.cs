using MongoDB.Client.Library.Interfaces;

namespace MongoDB.Client.Library.Implementation
{
    public class MongoDbRepositoryController<T> where T :IMongoDbRepositoryClient<IProvideConfiguration>
    {
        
    }
}