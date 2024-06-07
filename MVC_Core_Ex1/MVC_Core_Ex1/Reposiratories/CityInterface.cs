using MVC_Core_Ex1.Models;

namespace MVC_Core_Ex1.Reposiratories
{
    public interface CityInterface
    {
        //List<City> GetAllCities();
        //City GetCityById(Int64 id);
        List<City> GetAll();
        void Add(City rec);
        City GetById(long id);
    }
}
