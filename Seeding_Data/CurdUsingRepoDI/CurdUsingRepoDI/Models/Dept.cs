using System.ComponentModel.DataAnnotations;

namespace CurdUsingRepoDI.Models
{
    public class Dept
    {
        [Key]
        public Int64 DeptId {  get; set; }
        public string DeptName { get; set; }
        public virtual List<Emp> Emps { get; set; }
    }
}
