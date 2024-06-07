using Castle.Core.Resource;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Core_Ex1.Models
{
    public class FlightFacility
    {
        [Key]
        public Int64 FlightFeatureId {  get; set; }

        [ForeignKey("Flights")]
        public Int64 FightId { get; set; }
        public virtual Flights Flights { get; set; }
        [ForeignKey("Facility")]
        public Int64 FacilityId { get; set; }
        public virtual Facility Facility { get; set; }
       
    }
}
