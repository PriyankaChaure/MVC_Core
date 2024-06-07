using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CurdUsingRepoDI.Models
{
    public class Emp
    {
        [Key]
        public Int64 EmpId {  get; set; }
        [Required(ErrorMessage ="Emp Name Require!!!")]
        public string EmpName {  get; set; }
        [Required(ErrorMessage ="Emp Address Require!!!")]
        public string EmpAddress {  get; set; }
        [Required(ErrorMessage ="Email Id Require!!!")]
        [EmailAddress(ErrorMessage ="Invalid Email Id!!")]
        public string EmpEmailId {  get; set; }
        [Required(ErrorMessage ="Mobile No require!")]
        [RegularExpression("^\\d{10}$")]
       // [RegularExpression(@"^d{10}$")]
        public string EmpMobileNo { get; set; }
        [Required(ErrorMessage ="Salary Required!!")]
        [Range(1000,maximum:10000,ErrorMessage ="Salary Out Of range!!!")]
        public decimal EmpSalary {  get; set; }
        [ForeignKey("Dept")]
        public Int64 DeptId { get; set; }
        public virtual Dept Dept { get; set; }

    }
}
