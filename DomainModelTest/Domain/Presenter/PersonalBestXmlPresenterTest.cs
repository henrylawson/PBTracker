using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayerTest.Fixtures;
using DomainModel.Entities;
using DomainModel.Entities.Presenter;
using NUnit.Framework;

namespace DomainModelTest.Domain.Presenter
{
    [TestFixture]
    public class PersonalBestXmlPresenterTest
    {
        [Test]
        public void ShouldPresentThePersonalBestAsXml()
        {
            IPersonalBestPresenter presenter = new PersonalBestXmlPresenter();
            Assert.AreEqual("<personalBest><personName>Tony</personName><eventName>300m Free</eventName><time>00:00:00.0000100</time></personalBest>", presenter.Present(PersonalBestFixture.CreatePersonalBest()));
        }
    }
}
