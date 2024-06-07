using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExamCore.Models
{
    public class Flights
    {
        [Key]
        public Int64 FightId { get; set; }
        public Int64 FightNo { get; set; }


        [ForeignKey("SourceCity")]
        public Int64 SourceCityId { get; set; }
        public virtual City SourceCity { get; set; }



        [ForeignKey("DestinationCity")]
        public Int64 DestinationCityId { get; set; }
        public virtual City DestinationCity { get; set; }

        public virtual City City { get; set; }
        public Int64 Fair { get; set; }
        public string TravelTime { get; set; }
        public bool IsDirect { get; set; }

        public virtual List<FlightFacility> FlightFacilities { get; set; }

    }
}
