namespace ExamCore.Models
{
    public class FlightVM
    {
        public Int64 FightNo { get; set; }
        public Int64 Fair { get; set; }
        public string TravelTime { get; set; }  
        public Int64 SourceCityId { get; set; }
        public Int64 DestinationCityId { get; set; }
        public bool IsDirect { get; set; }
        public List<City> cities { get; set; }
        public List<Int64> selectedfacilityid { get; set; }
        public List<Facility> facilities { get; set; }
    }
}
