using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModel.Domain;
using NUnit.Framework;

namespace DomainModelTest.Domain
{
    [TestFixture]
    public class PersonalBestTest
    {
        [Test]
        public void ShouldHaveIncompleteToStringWithNoProperties()
        {
            var personalBest = new PersonalBest();
            Assert.AreEqual("Incomplete record", personalBest.ToString());
        }

        [Test]
        public void ShouldHaveIncompleteToStringWithNoPersonName()
        {
            var personalBest = new PersonalBest()
            {
                EventName = "200m Freestyle",
                Time = new TimeSpan(0, 0, 1, 47, 20)
            };
            Assert.AreEqual("Incomplete record", personalBest.ToString());
        }

        [Test]
        public void ShouldHaveIncompleteToStringWithNoEventName()
        {
            var personalBest = new PersonalBest()
            {
                PersonName = "Jim Saunders",
                Time = new TimeSpan(0, 0, 1, 47, 20)
            };
            Assert.AreEqual("Incomplete record", personalBest.ToString());
        }

        [Test]
        public void ShouldHaveIncompleteToStringWithNoTime()
        {
            var personalBest = new PersonalBest()
            {
                PersonName = "Jim Saunders",
                EventName = "200m Sprint"
            };
            Assert.AreEqual("Incomplete record", personalBest.ToString());
        }

        [Test]
        public void ShouldHaveEventNameAndTimeInToString()
        {
            var personalBest = new PersonalBest()
                                   {
                                       PersonName = "Henry Lawson",
                                       EventName = "200m Freestyle",
                                       Time = new TimeSpan(0, 0, 1, 47, 20)
                                   };
            Assert.AreEqual("Henry Lawson - 200m Freestyle: 00:01:47.0200000", personalBest.ToString());
        }
    }
}