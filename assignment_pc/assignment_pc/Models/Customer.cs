using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace assignment_pc.Models
{
    public class Customer
    {
        [Key]
        public Int64 CustomerId {  get; set; }
        public string CustomerName { get; set; }
        [ForeignKey("Areatbl")]
        public Int64 AreaId {  get; set; }
        public virtual Areatbl Areatbl { get; set; }
        public virtual List<bill> Bills { get; set; }
    }
}