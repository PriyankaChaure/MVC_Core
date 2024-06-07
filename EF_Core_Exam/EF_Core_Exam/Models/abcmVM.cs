using System;

namespace EF_Core_Exam.Models
{
    public class abcmVM
    {
        public Int64 mfgid { get; set; }
        public String mfgname { get; set; }
        public string address { get; set; }
        public string emailid { get; set; }
        public string mobileno { get; set; }
        public Int64 autopartsid { get; set; }
        public string autopartname { get; set; }
        public string partdesc { get; set; }
        public Int64 brandid { get; set; }
        public string brandname { get; set; }
        public string brandaddress { get; set; }
        public Int64 carid { get; set; }
        public decimal partprice { get; set; }
        public decimal qty { get; set; }
        public decimal? TotalNoOfParts { get; set; }
        public decimal? TotalPartAmount { get; set; }
        public decimal? MinimumPrice { get; set; }
        public decimal? MaximumPrice { get; set; }
        public Int64 SrNo {  get; set; }
        public decimal? value { get; set; }
    }
}
