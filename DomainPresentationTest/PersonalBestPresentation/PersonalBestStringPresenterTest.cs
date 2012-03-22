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
    public class PersonalBestStringPresenterTest
    {
        private IPersonalBestPresenter _stringPresenter;

        [SetUp]
        public void SetUpStringPresenter()
        {
            _stringPresenter = new PersonalBestStringPresenter();
        }

        [Test]
        public void ShouldHaveIncompleteToStringWithNoPropertiesUsingStringPresenter()
        {
            var personalBest = new PersonalBest();
            Assert.AreEqual("Incomplete record", _stringPresenter.Present(personalBest));
        }

        [Test]
        public void ShouldHaveIncompleteToStringWithNoPersonNameUsingStringPresenter()
        {
            var personalBest = new PersonalBest()
            {
                EventName = "200m Freestyle",
                TimeTicks = unchecked((int)new TimeSpan(0, 0, 1, 47, 20).Ticks)
            };
            Assert.AreEqual("Incomplete record", _stringPresenter.Present(personalBest));
        }

        [Test]
        public void ShouldHaveIncompleteToStringWithNoEventNameUsingStringPresenter()
        {
            var personalBest = new PersonalBest()
            {
                PersonName = "Jim Saunders",
                TimeTicks = unchecked((int)new TimeSpan(0, 0, 1, 47, 20).Ticks)
            };
            Assert.AreEqual("Incomplete record", _stringPresenter.Present(personalBest));
        }

        [Test]
        public void ShouldHaveIncompleteToStringWithNoTimeUsingStringPresenter()
        {
            var personalBest = new PersonalBest()
            {
                PersonName = "Jim Saunders",
                EventName = "200m Sprint"
            };
            Assert.AreEqual("Incomplete record", _stringPresenter.Present(personalBest));
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
            Assert.AreEqual("Henry Lawson - 200m Freestyle: 00:01:47.0200000", _stringPresenter.Present(personalBest));
        }
    }
}
