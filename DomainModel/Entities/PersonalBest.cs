using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StructureMap;

namespace DomainModel.Entities
{
    public class PersonalBest
    {
        public virtual int Id { get; set; }

        public virtual string PersonName { get; set; }
        
        public virtual string EventName { get; set; }
        
        public virtual int TimeTicks { get; set; }
        
        public virtual DateTime RecordedOn { get; set; }
        
        public virtual TimeSpan Time
        {
            get { return new TimeSpan(TimeTicks); }
        }
        
        public virtual bool AreAllPropertiesSet
        {
            get
            {
                return !String.IsNullOrEmpty(EventName) &&
                       !String.IsNullOrEmpty(PersonName) &&
                       !IsTimeAtZero();
            }
        }

        private bool IsTimeAtZero()
        {
            return Time.ToString().Equals("00:00:00");
        }
    }
}