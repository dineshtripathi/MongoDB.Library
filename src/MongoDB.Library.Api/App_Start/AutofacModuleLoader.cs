using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Autofac.Configuration;
using Microsoft.Extensions.Configuration;

namespace MongoDB.Library.Api.App_Start
{
    public class AutofacModuleLoader
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        public static void Loader(ContainerBuilder builder)
        {
            var config = new ConfigurationBuilder();
            config.AddJsonFile("AutofacConfiguration.json");
            var module = new ConfigurationModule(config.Build());
            builder.RegisterModule(module);
        }
    }
}
