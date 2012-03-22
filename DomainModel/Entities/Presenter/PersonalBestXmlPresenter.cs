using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel.Entities.Presenter
{
    public class PersonalBestXmlPresenter : IPersonalBestPresenter
    {
        public string Present(PersonalBest personalBest)
        {
            return
                String.Format(
                    "<personalBest><personName>{0}</personName><eventName>{1}</eventName><time>{2}</time></personalBest>",
                    personalBest.PersonName,
                    personalBest.EventName,
                    personalBest.Time);
        }
    }
}
