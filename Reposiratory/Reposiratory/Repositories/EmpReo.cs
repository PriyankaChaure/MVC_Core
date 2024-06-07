using Reposiratory.Models;
using System.Collections.Generic;
using System.Linq;


namespace Reposiratory.Repositories
{
    public class EmpReo:EmpInterface
    {
        private List<Employee> emp;
        public EmpReo()
        {
            emp = new List<Employee>();
            emp.Add(new Employee() { EmpId=1,EmpName="priyanka",EmpAddress="pune",EmpEmailid="priya2gmail.com",EmpDept="computer",EmpMobileNo="111111",EmpSalary=78990});
            emp.Add(new Employee() { EmpId = 2, EmpName = "sweety", EmpAddress = "mumbai", EmpEmailid = "sweety2gmail.com", EmpDept = "mechanical", EmpMobileNo = "222222", EmpSalary = 68990 });
            emp.Add(new Employee() { EmpId = 3, EmpName = "guddi", EmpAddress = "nashik", EmpEmailid = "guddi2gmail.com", EmpDept = "civil", EmpMobileNo = "333333", EmpSalary = 58990 });
            emp.Add(new Employee() { EmpId = 4, EmpName = "vishakha", EmpAddress = "nagpur", EmpEmailid = "vishaka2gmail.com", EmpDept = "It", EmpMobileNo = "444444", EmpSalary = 48990 });
            emp.Add(new Employee() { EmpId = 5, EmpName = "nishu", EmpAddress = "goa", EmpEmailid = "nishu2gmail.com", EmpDept = "Entc", EmpMobileNo = "55555", EmpSalary = 38990 });
        }
        public List<Employee> getemployee()
        {
            return emp;
        }
        public void addemployee(Employee ep)
        {
            long max = 0;
            max = emp.Max(p => p.EmpId);
            max++;
            ep.EmpId = max;
            emp.Add(ep);
        }
        public void search(Employee es)
        {
           
            
            
        }
    }
}
