using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_Exam.Models
{
    [Table("table_car")]
    public class car
    {
        [Key]
        public Int64 carid {  get; set; }
        [ForeignKey("brand")]
        public Int64 brandid {  get; set; }
        public virtual brand brand {  get; set; }
        [ForeignKey("autoparts")]
        public Int64 autopartsid { get; set; }
        public virtual autoparts autoparts { get; set; }
        public decimal partprice {  get; set; }
        public decimal qty {  get; set; }
    }
}
