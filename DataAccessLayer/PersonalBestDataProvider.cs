﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModel.Entities;
using NHibernate;
using StructureMap;

namespace DataAccessLayer
{
    public class PersonalBestDataProvider : DataProvider
    {
        public PersonalBest GetById(int personalBestId)
        {
            using (ISession session = CreateSessionFactory().OpenSession())
            {
                return session.Get<PersonalBest>(personalBestId);
            }
        }

        public void SaveOrUpdate(PersonalBest personalBest)
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

        public void DeleteById(int personalBestId)
        {
            using (ISession session = CreateSessionFactory().OpenSession())
            {
                session.Delete(GetById(personalBestId));
                session.Flush();
            }
        }
    }
}
