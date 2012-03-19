using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModel;
using NUnit.Framework;

namespace DomainModelTest
{
    [TestFixture]
    public class PersonalBestTest
    {
        [Test]
        public void ShouldHaveDefaultToStringWithNoEventNameAndTime()
        {
            var personalBest = new PersonalBest();
            Assert.AreEqual("Unknown: 00:00:00", personalBest.ToString());
        }

        [Test]
        public void ShouldHaveEventNameAndTimeInToString()
        {
            var personalBest = new PersonalBest("200m Freestyle", new TimeSpan(0, 0, 1, 47, 20));
            Assert.AreEqual("200m Freestyle: 00:01:47.0200000", personalBest.ToString());
        }
    }
}