﻿using System;

namespace Infinity.WithNoSql.MetaData.Repository.Poco
{
    [Serializable]
    public class Account : BaseMongoDbTableEntity 
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
      
    }
}