using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayerTest.Fixtures;
using DomainModel.Entities.Presenter;
using NUnit.Framework;

namespace DomainModelTest.Domain.Presenter
{
    [TestFixture]
    public class PersonalBestStringPresenterTest
    {
        [Test]
        public void ShouldPrintDetailsAsAPrettyString()
        {
            IPersonalBestPresenter personalBestPresenter = new PersonalBestStringPresenter();
            var personalBestString = personalBestPresenter.Present(PersonalBestFixture.CreatePersonalBest());
            Assert.AreEqual("Tony - 300m Free: 00:00:00.0000100", personalBestString);
        }
    }
}
