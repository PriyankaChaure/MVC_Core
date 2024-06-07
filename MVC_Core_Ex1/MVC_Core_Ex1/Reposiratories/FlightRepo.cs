using MVC_Core_Ex1.Models;
using MVC_Core_Ex1.ViewModels;

namespace MVC_Core_Ex1.Reposiratories
{
    public class FlightRepo : FlightsInterface
    {
        ClassContext cntx;
        public FlightRepo(ClassContext cntx)
        {
            this.cntx = cntx;
        }

        public void Add(Flights rec)
        {

            this.cntx.Flights.Add(rec);
            this.cntx.SaveChanges();
        }

        public Flights GetById(long id)
        {
            return this.cntx.Flights.Find(id);
        }
        public List<Flights> GetAll()
        {
            return this.cntx.Flights.ToList();
        }

        //public void Add(Flights rec)
        //{
        //    this.cc.Flights.Add(rec);
        //    this.cc.SaveChanges();
        //}

        //public List<Flights> GetAllFlights()
        //{
        //    return this.cc.Flights.ToList();
        //}

        //public List<Flights> GetCityId(long cityid)
        //{
        //    if (cityid == 0)
        //    {
        //        return this.cc.Flights.ToList();
        //    }
        //    else
        //    {
        //        return this.cc.Flights.Where(p => p.CityId == cityid).ToList();
        //        // return (GetAllEmp().Where(p=>p.DeptId == DeptId).OrderBy(p=>p.EmpName).ToList());

        //    }
        //}

        //public Flights GetFlightById(long id)
        //{
        //    return this.cc.Flights.Find(id);
        //}
        //public City GetCityById(long id)
        //{
        //    return this.cc.Cities.Find(id);
        //}
    }
}
