using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using DomainModel.Entities;

namespace DataAccessLayerTest.Fixtures
{
    public class PersonalBestFixture
    {
        public static PersonalBest CreatePersonalBestDbRecord()
        {
            var personalBest = CreatePersonalBest();
            new PersonalBestDataProvider().SaveOrUpdate(personalBest);
            return personalBest;
        }

        public static PersonalBest CreatePersonalBest()
        {
            return new PersonalBest()
                       {
                           EventName = "300m Free", 
                           PersonName = "Tony",
                           TimeTicks = 100,
                           RecordedOn = DateTime.Today
                       };
        }
    }
}

