using MVC_Core_Ex1.Models;

namespace MVC_Core_Ex1.ViewModels
{
    public class FlightVM
    {
        public Int64 CityId { get; set; }
        public string CityName { get; set; }
        public Int64 FacilityId { get; set; }
        public string FacilityName { get; set; }
        public string FacilityDescription { get; set; }
        public Int64 FightId { get; set; }
        public Int64 FightNo { get; set; }
        public Int64 SourceCityId { get; set; }
        public Int64 DestinationCityId { get; set; }
        public Int64? selectfeature {  get; set; }
        public string?  SourceCity{ get; set; }
        public string? DestinationCity { get; set; }
        public Int64 Fair { get; set; }
        public string TravelTime { get; set; }
        public bool IsDirect { get; set; }
        public Int64 FlightFeatureId { get; set; }
        public string FlightFeatures { get;set; }
        public List<City> cities { get; set; }
    }
}
