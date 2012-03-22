using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModel.Entities;
using StructureMap;

namespace DomainPresentation.PersonalBestPresentation
{
    public class PersonalBestDisplay
    {
        private readonly List<PersonalBest> _personalBests;
        private readonly IPersonalBestPresenter _presenter;

        public PersonalBestDisplay(List<PersonalBest> personalBests)
        {
            _personalBests = personalBests;
            _presenter = ObjectFactory.GetInstance<IPersonalBestPresenter>();
        }

        public string Render()
        {
            var stringBuilder = new StringBuilder();
            foreach(var personalBest in _personalBests)
            {
                stringBuilder.AppendLine(_presenter.Present(personalBest));
            }
            return stringBuilder.ToString();
        }
    }
}
