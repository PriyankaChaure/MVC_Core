using System.ComponentModel.DataAnnotations;

namespace MVC_Core_Ex1.Models
{
    public class Facility
    {
        [Key]
        public Int64 FacilityId {  get; set; }
        public string FacilityName { get; set; }
        public string FacilityDescription { get; set; }
        public virtual List<FlightFacility> FlightFacilities { get; set; }
    }
}
