using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using DataAccessLayerTest.Fixtures;
using DomainModel.Entities;
using NUnit.Framework;

namespace DataAccessLayerTest
{
    [TestFixture]
    public class PersonalBestDataProviderTest
    {
        private PersonalBestDataProvider _personalBestDataProvider;

        [SetUp]
        public void ClearAllDatabaseRecords()
        {
            _personalBestDataProvider.ClearAllRecords();
        }

        [SetUp]
        public void SetUpDataProvider()
        {
            _personalBestDataProvider = new PersonalBestDataProvider();
        }

        [Test]
        public void ShouldBeAbleToSavePersonalBest()
        {
            var personalBest = PersonalBestFixture.CreatePersonalBest();
            Assert.AreEqual(0, personalBest.Id);
            _personalBestDataProvider.SaveOrUpdate(personalBest);
            Assert.AreNotEqual(0, personalBest.Id);
        }

        [Test]
        public void ShouldBeAbleToGetPersonalBestById()
        {
            var personalBestDbRecord = PersonalBestFixture.CreatePersonalBestDbRecord();
            var personalBest = _personalBestDataProvider.GetById(personalBestDbRecord.Id);
            Assert.NotNull(personalBest);
            Assert.AreEqual(personalBestDbRecord.PersonName, personalBest.PersonName);
            Assert.AreEqual(personalBestDbRecord.EventName, personalBest.EventName);
            Assert.AreEqual(personalBestDbRecord.Time, personalBest.Time);
        }

        [Test]
        public void ShouldBeAbleToDeletePersonalBestById()
        {
            var personalBestDbRecord = PersonalBestFixture.CreatePersonalBestDbRecord();
            Console.WriteLine(personalBestDbRecord.Id);
            _personalBestDataProvider.DeleteById(personalBestDbRecord.Id);
            Assert.IsNull(_personalBestDataProvider.GetById(personalBestDbRecord.Id));
        }
    }
}