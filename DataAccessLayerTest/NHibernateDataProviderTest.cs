﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using DomainModel.Domain;
using NUnit.Framework;

namespace DataAccessLayerTest
{
    [TestFixture]
    public class NHibernateDataProviderTest
    {
        [Test]
        public void ShouldBeAbleToGetPersonalBestById()
        {
            NHibernateDataProvider nHibernateDataProvider = new NHibernateDataProvider();
            PersonalBest personalBest = nHibernateDataProvider.GetPersonalBestById(1);
            Assert.AreEqual("Henry", personalBest.PersonName);
            Assert.AreEqual("200m Free", personalBest.EventName);
        }
    }
}