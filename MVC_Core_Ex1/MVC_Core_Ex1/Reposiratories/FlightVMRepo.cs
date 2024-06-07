using Castle.Core.Resource;
using MVC_Core_Ex1.Models;
using MVC_Core_Ex1.ViewModels;

namespace MVC_Core_Ex1.Reposiratories
{
    public class FlightVMRepo : FlightVMInterface
    {
        ClassContext cntx;
        public FlightVMRepo(ClassContext cntx)
        {
            this.cntx = cntx;
        }

        public void Add(FlightVM rec)
        {
            

            FlightFacility f1 = new FlightFacility();
            f1.FacilityId = rec.FacilityId; 
            

            Flights f = new Flights();
            f.FightNo = rec.FightNo;
            f.Fair = rec.Fair;
            f.TravelTime = rec.TravelTime;
            f.SourceCityId = rec.CityId;
            f.DestinationCityId = rec.CityId;
             
            f.FlightFacilities.Add(f1);
            this.cntx.Flights.Add(f);
            this.cntx.SaveChanges();

        }

       
        public List<FlightVM> GetAllFlightVM()
        {
            var v =  from t in this.cntx.Flights
                     join t1 in this.cntx.Cities
                     on t.SourceCityId  equals t1.CityId 
                     join t2 in this .cntx.Cities
                     on t.DestinationCityId equals t2.CityId
                     join t3 in this.cntx.FlightFacilities
                     on t .FightId equals t3.FightId
                     join t4 in this.cntx.Facilities
                     on t3.FacilityId equals t4.FacilityId  
                    select new FlightVM
                    {
                        FightNo = t.FightNo,
                        Fair = t.Fair,
                        TravelTime = t.TravelTime,
                        SourceCityId = t.SourceCityId,
                        CityName=t1.CityName,
                        DestinationCityId = t.DestinationCityId,
                        DestinationCity=t2.CityName,
                        IsDirect = t.IsDirect,
                        FlightFeatureId=t3.FlightFeatureId,
                         FacilityName=t4.FacilityName,
                    };
            return v.ToList();
                  
        }

        public List<Flights> GetAllFlightVM1()
        {
            return this.cntx.Flights.ToList();
        }
    }
}
