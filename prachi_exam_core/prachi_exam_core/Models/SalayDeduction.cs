using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prachi_exam_core.Models
{
    public class SalayDeduction
    {
        [Key]
        public Int64 SalaryDeductionId {  get; set; }
        [ForeignKey("Emp")]
        public Int64 EmpId { get; set; }
        public virtual Emp Emp { get; set; }
        public string DeductionName {  get; set; }
        public decimal DeductionAmount { get; set; }

    }
}
