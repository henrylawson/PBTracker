using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using DomainModel.Entities;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace DataAccessLayer
{
    public class DataProvider
    {
        private const string ConnectionStringKey = "DefaultDb";

        protected static ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(
                    MsSqlConfiguration.MsSql2008
                        .ConnectionString(c => c.FromConnectionStringWithKey(ConnectionStringKey))
                )
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<PersonalBest>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(false, false))
                .BuildSessionFactory();
        }

        protected void ClearAllRecordsForEntity(Type type)
        {
            using (ISession session = CreateSessionFactory().OpenSession())
            {
                session.Delete(String.Format("from {0} personalBest", type));
                session.Flush();
            }
        }
    }
}