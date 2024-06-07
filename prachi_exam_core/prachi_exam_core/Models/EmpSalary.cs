using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prachi_exam_core.Models
{
    public class EmpSalary
    {
        [Key]
        public Int64 EmpSalaryId {  get; set; }
        public decimal BasicSalary {  get; set; }
        [ForeignKey("Emp")]
        public Int64 EmpId { get; set; }
        public virtual Emp Emp { get; set; }
    }
}
