using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModel.Entities;
using DomainModel.Entities.Presenter;
using NUnit.Framework;
using StructureMap;

namespace DomainModelTest.Domain
{
    [TestFixture]
    public class PersonalBestTest
    {
        private void ConfigureStringPresenter()
        {
            ObjectFactory.Initialize(x =>
            {
                x.ForRequestedType<IPersonalBestPresenter>().Use<PersonalBestStringPresenter>();
            });
        }

        [Test]
        public void ShouldHaveIncompleteToStringWithNoPropertiesUsingStringPresenter()
        {
            ConfigureStringPresenter();
            var personalBest = new PersonalBest();
            Assert.AreEqual("Incomplete record", personalBest.ToString());
        }

        [Test]
        public void ShouldHaveIncompleteToStringWithNoPersonNameUsingStringPresenter()
        {
            ConfigureStringPresenter();
            var personalBest = new PersonalBest()
            {
                EventName = "200m Freestyle",
                TimeTicks = unchecked((int)new TimeSpan(0, 0, 1, 47, 20).Ticks)
            };
            Assert.AreEqual("Incomplete record", personalBest.ToString());
        }

        [Test]
        public void ShouldHaveIncompleteToStringWithNoEventNameUsingStringPresenter()
        {
            ConfigureStringPresenter();
            var personalBest = new PersonalBest()
            {
                PersonName = "Jim Saunders",
                TimeTicks = unchecked((int)new TimeSpan(0, 0, 1, 47, 20).Ticks)
            };
            Assert.AreEqual("Incomplete record", personalBest.ToString());
        }

        [Test]
        public void ShouldHaveIncompleteToStringWithNoTimeUsingStringPresenter()
        {
            ConfigureStringPresenter();
            var personalBest = new PersonalBest()
            {
                PersonName = "Jim Saunders",
                EventName = "200m Sprint"
            };
            Assert.AreEqual("Incomplete record", personalBest.ToString());
        }

        [Test]
        public void ShouldHaveEventNameAndTimeInToStringUsingStringPresenter()
        {
            ConfigureStringPresenter();
            var personalBest = new PersonalBest()
            {
                PersonName = "Henry Lawson",
                EventName = "200m Freestyle",
                TimeTicks = unchecked((int)new TimeSpan(0, 0, 1, 47, 20).Ticks)
            };
            Assert.AreEqual("Henry Lawson - 200m Freestyle: 00:01:47.0200000", personalBest.ToString());
        }

        private void ConfigureXmlPresenter()
        {
            ObjectFactory.Initialize(x =>
            {
                x.ForRequestedType<IPersonalBestPresenter>().Use<PersonalBestXmlPresenter>();
            });
        }

        [Test]
        public void ShouldHaveEventNameAndTimeInToStringUsingXmlPresenter()
        {
            ConfigureXmlPresenter();
            var personalBest = new PersonalBest()
            {
                PersonName = "Henry Lawson",
                EventName = "200m Freestyle",
                TimeTicks = unchecked((int)new TimeSpan(0, 0, 1, 47, 20).Ticks)
            };
            Assert.AreEqual("<personalBest><personName>Henry Lawson</personName><eventName>200m Freestyle</eventName><time>00:01:47.0200000</time></personalBest>", personalBest.ToString());
        }
    }
}