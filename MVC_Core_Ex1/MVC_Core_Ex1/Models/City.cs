using System.ComponentModel.DataAnnotations;

namespace MVC_Core_Ex1.Models
{
    public class City
    {
        [Key]
        public Int64 CityId {  get; set; }
        public string CityName { get; set; }

        public virtual List<Flights> Fights { get; set; }
        //  public virtual List<Flights> Fights1 { get; set; }
        //public virtual Flights Fights { get; set; }
        //public virtual Flights Fights1 { get; set; }
    }
}
