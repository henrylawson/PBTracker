using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModel.Entities;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace DataAccessLayer
{
    public class NHibernateDataProvider
    {
        private static ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(
                    MsSqlConfiguration.MsSql2008
                        .ConnectionString("Data Source=WHITMORE;Initial Catalog=PBTracker;Integrated Security=True;Pooling=False")
                )
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<PersonalBest>())
                .BuildSessionFactory();
        }

        public PersonalBest GetPersonalBestById(int personalBestId)
        {
            ISessionFactory sessionFactory = CreateSessionFactory();
            ISession session = sessionFactory.OpenSession();
            return session.Get<PersonalBest>(personalBestId);
        }
    }
}