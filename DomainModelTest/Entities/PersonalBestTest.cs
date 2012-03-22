using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayerTest.Fixtures;
using DomainModel.Entities;
using DomainPresentation.PersonalBestPresentation;
using NUnit.Framework;
using StructureMap;

namespace DomainModelTest.Entities
{
    [TestFixture]
    public class PersonalBestTest
    {
        [Test]
        public void AreAllPropertiesSetShouldBeFalseIfEventNameNotSet()
        {
            var personalBest = PersonalBestFixture.CreatePersonalBest();
            personalBest.EventName = "";
            Assert.IsFalse(personalBest.AreAllPropertiesSet);
        }

        [Test]
        public void AreAllPropertiesSetShouldBeFalseIfPersonNameNotSet()
        {
            var personalBest = PersonalBestFixture.CreatePersonalBest();
            personalBest.PersonName = "";
            Assert.IsFalse(personalBest.AreAllPropertiesSet);
        }

        [Test]
        public void AreAllPropertiesSetShouldBeFalseIfTimeIsZero()
        {
            var personalBest = PersonalBestFixture.CreatePersonalBest();
            personalBest.TimeTicks = 0;
            Assert.IsFalse(personalBest.AreAllPropertiesSet);
        }
    }
}