using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel.Domain
{
    public class PersonalBest
    {
        private string _eventName;

        public string EventName
        {
            get { return String.IsNullOrEmpty(_eventName) ? "Unknown" : _eventName; }
            set { _eventName = value; }
        }

        public TimeSpan Time { get; set; }

        public PersonalBest()
        {
        }

        public PersonalBest(string eventName, TimeSpan time)
        {
            EventName = eventName;
            Time = time;
        }

        public new string ToString()
        {
            return String.Format("{0}: {1}", EventName, Time.ToString());
        }
    }
}