using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel.Entities.Presenter
{
    public class PersonalBestStringPresenter : IPersonalBestPresenter
    {
        public string Present(PersonalBest personalBest)
        {
            return personalBest.AreAllPropertiesSet ? String.Format("{0} - {1}: {2}", 
                personalBest.PersonName, personalBest.EventName, personalBest.Time) : "Incomplete record";
        }
    }
}
