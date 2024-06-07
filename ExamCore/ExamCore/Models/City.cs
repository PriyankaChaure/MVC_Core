using System.ComponentModel.DataAnnotations;

namespace ExamCore.Models
{
    public class City
    {
        [Key]
        public Int64 CityId { get; set; }
        public string CityName { get; set; }
        public virtual List<Flights> Flights { get; set; }
       
    }
}
