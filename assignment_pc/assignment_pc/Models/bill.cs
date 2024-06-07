using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace assignment_pc.Models
{
    public class bill
    {
        [Key]
        public Int64 BillId {  get; set; }
        public DateTime BillDate { get; set; }
        public Int64 BillNo {  get; set; }
        [ForeignKey("Customer")]
        public Int64 CustomerId {  get; set; }
        public virtual Customer Customer { get; set; }
        public decimal BillAmount {  get; set; }
        public virtual List<Payment> Payments { get; set; }
    }
}