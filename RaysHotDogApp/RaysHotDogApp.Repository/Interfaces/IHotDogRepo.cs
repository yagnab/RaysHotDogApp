using RaysHotDogApp.Repository.Entities;
using System.Collections.Generic;

namespace RaysHotDogApp.Repository.Interfaces
{
    public interface IHotDogRepo
    {
        IEnumerable<HotDog> GetFavouriteHotDogs();
    }
}
