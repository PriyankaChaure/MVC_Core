using MVC_Core_Ex1.Models;
using System.Drawing.Drawing2D;

namespace MVC_Core_Ex1.Reposiratories
{
    public class CityRepo : CityInterface
    {
        ClassContext cntx;
        public CityRepo(ClassContext cntx)
        {
            this.cntx = cntx;
        }

        public void Add(City rec)
        {

            this.cntx.Cities.Add(rec);
            this.cntx.SaveChanges();
        }

        public City GetById(long id)
        {
            return this.cntx.Cities.Find(id);
        }
        public List<City> GetAll()
        {
            return this.cntx.Cities.ToList();
        }
        //public List<City> GetAllCities()
        //{
        //    return this.cc.Cities.ToList();
        //}

        //public City GetCityById(long id)
        //{
        //   return this.cc.Cities.Find(id);
        //}
    }
}
