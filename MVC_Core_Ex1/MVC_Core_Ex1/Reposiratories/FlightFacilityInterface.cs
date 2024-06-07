using MVC_Core_Ex1.Models;

namespace MVC_Core_Ex1.Reposiratories
{
    public interface FlightFacilityInterface
    {
        //    List<FlightFacility> GetAllFacilities();
        //    List<FlightFacility> GetFlightId(Int64 flightid);
        //    List<FlightFacility> GetFacilityId(Int64 facilityid);

        //    FlightFacility GetFacilityById(Int64 id);
        //    void Add(FlightFacility rec);
        List<FlightFacility> GetAll();
        void Add(FlightFacility rec);
        FlightFacility GetById(long id);

    }
}
