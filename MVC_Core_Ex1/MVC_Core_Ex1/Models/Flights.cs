using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Core_Ex1.Models
{
    public class Flights
    {
        [Key]
        public Int64 FightId { get; set; }
        public Int64 FightNo { get; set; }
        [Display(Name ="Select Source")]
        [ForeignKey("City")]
        public Int64 SourceCityId {  get; set; }
        [Display(Name ="Select Destination")]
        [ForeignKey("City")]
        public Int64 DestinationCityId {  get; set; }
        public Int64 Fair {  get; set; }
        public string TravelTime { get; set; }
        public bool IsDirect {  get; set; }


        //public virtual City City2 { get; set; }
       // public virtual City City1 { get; set; }
        public virtual List<City> City { get; set; }

        //public virtual List<City> City1 { get; set; }
        public virtual List<FlightFacility> FlightFacilities { get; set; }
        public Flights()
        {
          //  City1 = new List<City>();
           City = new List<City>();
           //City2=new City();
            //City1=new City();
            FlightFacilities = new List<FlightFacility>();
        }
       
    }
}
