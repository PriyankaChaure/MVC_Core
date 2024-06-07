using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prachi_exam_core.Models
{
    public class SalaryAddition
    {
        [Key]
        public Int64 SalaryAdditionId {  get; set; }
        [ForeignKey("Emp")]
        public Int64 EmpId { get; set; }
        public virtual Emp Emp { get; set; }
        public string AdditionName {  get; set; }
        public decimal AdditionAmount {  get; set; }
    }
}
