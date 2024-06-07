using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace prachi_exam_core.Models
{
    public class Emp
    {
        [Key]
        public Int64 EmpId {  get; set; }   
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address {  get; set; }
        public string EmailId {  get; set; }  
        public string MobileNumber { get; set; }
        public DateTime JoinDate { get; set; }
        public virtual List<EmpSalary> EmpSalaries { get; set; }
        public virtual List<SalayDeduction> SalariesDeductions { get; set; }
        public virtual List<SalaryAddition> SalariesAdditions { get; set; }


    }
}
