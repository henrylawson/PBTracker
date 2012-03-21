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
            var personalBest = new PersonalBest()
                                   {
                                       EventName = "300m Free", 
                                       PersonName = "Tony", 
                                       TimeTicks = 100
                                   };
            new PersonalBestDataProvider().SaveOrUpdatePersonalBest(personalBest);
            return personalBest;
        }
    }
}

