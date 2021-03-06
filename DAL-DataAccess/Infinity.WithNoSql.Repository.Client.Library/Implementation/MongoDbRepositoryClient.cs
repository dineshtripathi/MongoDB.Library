﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Infinity.WithNoSql.Repository.Client.Library.Interfaces;
using Infinity.WithNoSql.Repository.PocoJson.Model;

namespace Infinity.WithNoSql.Repository.Client.Library.Implementation
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