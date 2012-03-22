using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayerTest.Fixtures;
using DomainModel.Entities;
using DomainPresentation.PersonalBestPresentation;
using NUnit.Framework;
using StructureMap;

namespace DomainPresentationTest.PersonalBestPresentation
{
    [TestFixture]
    public class PersonalBestDisplayTest
    {
        private void ConfigureToUseString()
        {
            ObjectFactory.Initialize(x => {
                x.ForRequestedType<IPersonalBestPresenter>().TheDefaultIsConcreteType<PersonalBestStringPresenter>();
            });
        }

        [Test]
        public void ShouldDisplayMultiplePersonalBestsAsStrings()
        {
            ConfigureToUseString();
            var personalBests = new List<PersonalBest>();
            personalBests.Add(PersonalBestFixture.CreatePersonalBest());
            personalBests.Add(PersonalBestFixture.CreatePersonalBest());
            var personalBestDisplay = new PersonalBestDisplay(personalBests);
            Assert.AreEqual("Tony - 300m Free: 00:00:00.0000100\r\nTony - 300m Free: 00:00:00.0000100\r\n", personalBestDisplay.Render());
        }

        private void ConfigureToUseXml()
        {
            ObjectFactory.Initialize(x =>
            {
                x.ForRequestedType<IPersonalBestPresenter>().TheDefaultIsConcreteType<PersonalBestXmlPresenter>();
            });
        }

        [Test]
        public void ShouldDisplayMultiplePersonalBestsAsXml()
        {
            ConfigureToUseXml();
            var personalBests = new List<PersonalBest>();
            personalBests.Add(PersonalBestFixture.CreatePersonalBest());
            personalBests.Add(PersonalBestFixture.CreatePersonalBest());
            var personalBestDisplay = new PersonalBestDisplay(personalBests);
            Console.WriteLine(personalBestDisplay.Render());
            Assert.AreEqual("<personalBest><personName>Tony</personName><eventName>300m Free</eventName><time>00:00:00.0000100</time></personalBest>\r\n<personalBest><personName>Tony</personName><eventName>300m Free</eventName><time>00:00:00.0000100</time></personalBest>\r\n", personalBestDisplay.Render());
        }
    }
}
