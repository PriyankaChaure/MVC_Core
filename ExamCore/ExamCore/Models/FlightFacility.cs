using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExamCore.Models
{
    public class FlightFacility
    {
        [Key]
        public Int64 FlightFeatureId { get; set; }

        [ForeignKey("Flights")]
        public Int64 FightId { get; set; }
        public virtual Flights Flights { get; set; }
        [ForeignKey("Facility")]
        public Int64 FacilityId { get; set; }
        public virtual Facility Facility { get; set; }
    }
}
