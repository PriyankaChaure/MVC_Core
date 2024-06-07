using MVC_Core_Ex1.Models;

namespace MVC_Core_Ex1.Reposiratories
{
    public interface FacilityInterface
    {
        //List<Facility> GetAllFacilities();

        //Facility GetFacilityById(Int64 id);
        List<Facility> GetAll();
        void Add(Facility rec);
       Facility GetById(long id);

    }
}
