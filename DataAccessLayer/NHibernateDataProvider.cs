using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public class NHibernateDataProvider
    {
        public DomainModel.Domain.PersonalBest GetPersonalBestById(int personalBestId)
        {
            NHibernate.Cfg.Configuration config = new NHibernate.Cfg.Configuration();

            config.Configure();

            NHibernate.ISessionFactory sessionFactory = config.BuildSessionFactory();

            NHibernate.ISession session = sessionFactory.OpenSession();

            return session.Get<DomainModel.Domain.PersonalBest>(personalBestId);
        }
    }
}