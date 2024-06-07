using System;

namespace prachi_exam_core.Models
{
    public class Emp_sal_dedu_Add_VM
    {
        public Int64 EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string EmailId { get; set; }
        public string MobileNumber { get; set; }
        public DateTime JoinDate { get; set; }
        public Int64 EmpSalaryId { get; set; }
        public decimal BasicSalary { get; set; }
        public Int64 SalaryAdditionId { get; set; }
        public string AdditionName { get; set; }
        public decimal AdditionAmount { get; set; }
        public Int64 SalaryDeductionId { get; set; }
        public string DeductionName { get; set; }
        public decimal DeductionAmount { get; set; }
        public decimal? BasicAmount { get; set; }
        public decimal? TotalDeduction {  get; set; }
        public decimal? TotalAdditions { get; set; }
        public decimal? TotalSalary { get; set; }   

    }
}
