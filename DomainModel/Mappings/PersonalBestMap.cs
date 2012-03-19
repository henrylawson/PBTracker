using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModel.Entities;
using FluentNHibernate.Mapping;

namespace DomainModel.Mappings
{
    public class PersonalBestMap : ClassMap<PersonalBest>
    {
        public PersonalBestMap()
        {
            Id(x => x.Id);
            Map(x => x.PersonName);
            Map(x => x.EventName);
            Map(x => x.TimeTicks);
        }
    }
}
