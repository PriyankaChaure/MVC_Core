using System.ComponentModel.DataAnnotations;

namespace ExamCore.Models
{
    public class Facility
    {
        [Key]
        public Int64 FacilityId { get; set; }
        public string FacilityName { get; set; }
        public string FacilityDescription { get; set; }
        public virtual List<FlightFacility> FlightFacilities { get; set; }
    }
}
