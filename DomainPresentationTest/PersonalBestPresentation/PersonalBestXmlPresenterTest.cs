using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayerTest.Fixtures;
using DomainModel.Entities;
using DomainPresentation.PersonalBestPresentation;
using NUnit.Framework;

namespace DomainPresentationTest.PersonalBestPresentation
{
    [TestFixture]
    public class PersonalBestXmlPresenterTest
    {
        private IPersonalBestPresenter _stringPresenter;

        [SetUp]
        public void SetUpStringPresenter()
        {
            _stringPresenter = new PersonalBestXmlPresenter();
        }

        [Test]
        public void ShouldHaveIncompleteToStringWithNoPropertiesUsingStringPresenter()
        {
            var personalBest = new PersonalBest();
            Assert.AreEqual("<personalBest />", _stringPresenter.Present(personalBest));
        }

        [Test]
        public void ShouldHaveIncompleteToStringWithNoPersonNameUsingStringPresenter()
        {
            var personalBest = new PersonalBest()
            {
                EventName = "200m Freestyle",
                TimeTicks = unchecked((int)new TimeSpan(0, 0, 1, 47, 20).Ticks)
            };
            Assert.AreEqual("<personalBest />", _stringPresenter.Present(personalBest));
        }

        [Test]
        public void ShouldHaveIncompleteToStringWithNoEventNameUsingStringPresenter()
        {
            var personalBest = new PersonalBest()
            {
                PersonName = "Jim Saunders",
                TimeTicks = unchecked((int)new TimeSpan(0, 0, 1, 47, 20).Ticks)
            };
            Assert.AreEqual("<personalBest />", _stringPresenter.Present(personalBest));
        }

        [Test]
        public void ShouldHaveIncompleteToStringWithNoTimeUsingStringPresenter()
        {
            var personalBest = new PersonalBest()
            {
                PersonName = "Jim Saunders",
                EventName = "200m Sprint"
            };
            Assert.AreEqual("<personalBest />", _stringPresenter.Present(personalBest));
        }

        [Test]
        public void ShouldHaveEventNameAndTimeInToStringUsingStringPresenter()
        {
            var personalBest = new PersonalBest()
            {
                PersonName = "Henry Lawson",
                EventName = "200m Freestyle",
                TimeTicks = unchecked((int)new TimeSpan(0, 0, 1, 47, 20).Ticks)
            };
            Assert.AreEqual("<personalBest><personName>Henry Lawson</personName><eventName>200m Freestyle</eventName><time>00:01:47.0200000</time></personalBest>", _stringPresenter.Present(personalBest));
        }
    }
}
