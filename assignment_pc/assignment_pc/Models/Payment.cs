using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace assignment_pc.Models
{
    public class Payment
    {
        [Key]
        public Int64 PaymentId {  get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal PaymentAmount {  get; set; }
        [ForeignKey("Bill")]
        public Int64 BillId { get; set; }
        public virtual bill Bill { get; set; }
    }
}