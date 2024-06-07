using MVC_Core_Ex1.Models;

namespace MVC_Core_Ex1.Reposiratories
{
    public interface FlightsInterface
    {
        //List<Flights> GetAllFlights();
        //List<Flights> GetCityId(Int64 cityid);

        //Flights GetFlightById(Int64 id);
        //void Add(Flights rec);
        //public City GetCityById(Int64 id);
        List<Flights> GetAll();
        void Add(Flights rec);
        Flights GetById(long id);
    }
}
