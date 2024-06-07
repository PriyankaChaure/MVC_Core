using CurdUsingRepoDI.Models;

namespace CurdUsingRepoDI.Reposiratories
{
    public class EmpRepo:EmpInterface
    {
        ClassContext cc;
        public EmpRepo(ClassContext cc)
        {
            this.cc = cc;
        }
        public List<Emp> GetAllEmp()
        {
            return this.cc.Emps.ToList();
        }
        public Emp GetEmpById(Int64 id)
        {
            return this.cc.Emps.Find(id);
        }
        public void Add(Emp rec)
        {
            this.cc.Emps.Add(rec);
            this.cc.SaveChanges();
        }
        public void Edit(Emp rec)
        {
            this.cc.Entry(rec).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.cc.SaveChanges();
        }
        public void Delete(long id)
        {
            var rec=this.cc.Emps.Find(id);
            this.cc.Emps.Remove(rec);
            this.cc.SaveChanges();
        }
        public void Details(long id)
        {
            var rec = this.cc.Emps.Find(id);
        }

        public List<Emp> GetDeptId(long DeptId=0)
        {
           if(DeptId==0)
            {
                return this.cc.Emps.ToList();
            }
            else
            {
              // return this.cc.Emps.Where(p => p.DeptId == DeptId).ToList();
              return GetAllEmp().Where(p=>p.DeptId == DeptId).ToList();
               
            }
        }

        public List<Emp> SearchAscending( )
        {
               return GetAllEmp().OrderBy(p=>p.EmpName).ToList();
        }
    }
}
