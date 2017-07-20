using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBApplicaiton
{
    public interface IDbConnector
    {

        IDbConnector Configure();
    }

}