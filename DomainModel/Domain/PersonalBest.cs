using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel.Domain
{
    public class PersonalBest
    {
        public string PersonName { get; set; }
        public string EventName { get; set; }
        public TimeSpan Time { get; set; }

        public new string ToString()
        {
            return AreAllPropertiesSet() ? String.Format("{0} - {1}: {2}", PersonName, EventName, Time) : "Incomplete record";
        }

        private bool AreAllPropertiesSet()
        {
            return !String.IsNullOrEmpty(EventName) &&
                   !String.IsNullOrEmpty(PersonName) &&
                   !IsTimeAtZero();
        }

        private bool IsTimeAtZero()
        {
            return Time.ToString().Equals("00:00:00");
        }
    }
}