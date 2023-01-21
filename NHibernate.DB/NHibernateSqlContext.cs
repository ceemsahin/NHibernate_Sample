using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Mapping;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernate.DB
{
    public class NHibernateSqlContext
    {
        private static ISessionFactory session;


        private static ISessionFactory CreateSession()
        {
            if (session != null)
                return session;


            FluentConfiguration _config = Fluently.Configure().Database(MsSqlConfiguration.MsSql2012.ConnectionString(
                x => x.Server(@" :) ")
                .Username(" :) ")
                .Password(" :) ")
                .Database("NHibernateDB")))

                .Mappings(n => n.FluentMappings.AddFromAssemblyOf<UserExperienceMapping>())
                .Mappings(n => n.FluentMappings.AddFromAssemblyOf<UserMapping>())
                .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true));

            session = _config.BuildSessionFactory();

            return session;

           
        }
        public static ISession SessionOpen()
        {
            return CreateSession().OpenSession();
        }
    }
}
