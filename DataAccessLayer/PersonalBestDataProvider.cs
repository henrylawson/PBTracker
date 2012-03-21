using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModel.Entities;
using NHibernate;

namespace DataAccessLayer
{
    public class PersonalBestDataProvider : DataProvider
    {

        public PersonalBest GetPersonalBestById(int personalBestId)
        {
            ISessionFactory sessionFactory = CreateSessionFactory();
            ISession session = sessionFactory.OpenSession();
            return session.Get<PersonalBest>(personalBestId);
        }

        public void SaveOrUpdatePersonalBest(PersonalBest personalBest)
        {
            using (ISession session = CreateSessionFactory().OpenSession())
            {
                session.SaveOrUpdate(personalBest);
                session.Flush();
            }
        }

        public void ClearAllRecords()
        {
            ClearAllRecordsForEntity(typeof(PersonalBest));
        }
    }
}
