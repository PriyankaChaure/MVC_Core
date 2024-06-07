using MVC_Core_Ex1.Models;
using System.Drawing.Drawing2D;

namespace MVC_Core_Ex1.Reposiratories
{
    public class FlightFacilityRepo : FlightFacilityInterface
    {
        ClassContext cntx;
        public FlightFacilityRepo(ClassContext cntx)
        {
            this.cntx = cntx;
        }

        public void Add(FlightFacility rec)
        {

            this.cntx.FlightFacilities.Add(rec);
            this.cntx.SaveChanges();
        }

        public FlightFacility GetById(long id)
        {
            return this.cntx.FlightFacilities.Find(id);
        }
        public List<FlightFacility> GetAll()
        {
            return this.cntx.FlightFacilities.ToList();
        }
        //public void Add(FlightFacility rec)
        //{
        //    this.cc.FlightFacilities.Add(rec);
        //    this.cc.SaveChanges();
        //}

        //public List<FlightFacility> GetAllFacilities()
        //{
        //    return this.cc.FlightFacilities.ToList(); 
        //}

        //public FlightFacility GetFacilityById(long id)
        //{
        //    return this.cc.FlightFacilities.Find(id);
        //}

        //public List<FlightFacility> GetFacilityId(long facilityid)
        //{
        //    if (facilityid == 0)
        //    {
        //        return this.cc.FlightFacilities.ToList();
        //    }
        //    else
        //    {
        //        return this.cc.FlightFacilities.Where(p => p.FacilityId == facilityid).ToList();
        //        // return (GetAllEmp().Where(p=>p.DeptId == DeptId).OrderBy(p=>p.EmpName).ToList());

        //    }
        //}

        //public List<FlightFacility> GetFlightId(long flightid)
        //{
        //    if (flightid == 0)
        //    {
        //        return this.cc.FlightFacilities.ToList();
        //    }
        //    else
        //    {
        //        return this.cc.FlightFacilities.Where(p => p.FightId == flightid).ToList();
        //        // return (GetAllEmp().Where(p=>p.DeptId == DeptId).OrderBy(p=>p.EmpName).ToList());

        //    }
        //}
    }
}
