using DomainModel.Entities;

namespace DomainPresentation.PersonalBestPresentation
{
    public interface IPersonalBestPresenter
    {
        string Present(PersonalBest personalBest);
    }
}