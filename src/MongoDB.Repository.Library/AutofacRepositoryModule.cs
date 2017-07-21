using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac;
using AutoMapper;
namespace MongoDBApplicaiton
{
    public class AutofacRepositoryModule :Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MongoDbRepository>().AsImplementedInterfaces().InstancePerRequest();
            builder.RegisterType<MongoDbRepository>().PropertiesAutowired();
            //register automapper profiles
            var profileTypes =typeof(AutofacRepositoryModule).GetTypeInfo().Assembly.GetTypes().Where(x => typeof(Profile).IsAssignableFrom(x)).ToArray();
            builder.RegisterTypes(profileTypes).As<Profile>();

            //register configuration as a single instance
            builder.Register(c => new MapperConfiguration(cfg =>
            {
                //add your profiles (either resolve from container or however else you acquire them)
                var profiles = c.Resolve<IEnumerable<Profile>>();
                foreach (var profile in profiles)
                {
                    cfg.AddProfile(profile);
                }
            })).AsSelf().SingleInstance();

            //register mapper
            builder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve)).As<IMapper>().InstancePerLifetimeScope();


        }
    }
}
