using MVC_Core_Ex1.Models;
using System.Drawing.Drawing2D;

namespace MVC_Core_Ex1.Reposiratories
{
    public class facilityRepo : FacilityInterface
    {
        ClassContext cntx;
        public facilityRepo(ClassContext cntx)
        {
            this.cntx = cntx;
        }

        public void Add(Facility rec)
        {

            this.cntx.Facilities.Add(rec);
            this.cntx.SaveChanges();
        }

        public Facility GetById(long id)
        {
            return this.cntx.Facilities.Find(id);
        }
        public List<Facility> GetAll()
        {
            return this.cntx.Facilities.ToList();
        }

        
    }
}
