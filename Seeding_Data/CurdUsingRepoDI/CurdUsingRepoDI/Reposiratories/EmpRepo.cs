using CurdUsingRepoDI.Models;

namespace CurdUsingRepoDI.Reposiratories
{
    public class EmpRepo : EmpInterface
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
            this.cc.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.cc.SaveChanges();
        }
        public void Delete(long id)
        {
            var rec = this.cc.Emps.Find(id);
            this.cc.Emps.Remove(rec);
            this.cc.SaveChanges();
        }
        public void Details(long id)
        {
            var rec = this.cc.Emps.Find(id);
        }

        public List<Emp> GetDeptId(long DeptId = 0)
        {
            if (DeptId == 0)
            {
                return this.cc.Emps.ToList();
            }
            else
            {
                return this.cc.Emps.Where(p => p.DeptId == DeptId).ToList();
                // return (GetAllEmp().Where(p=>p.DeptId == DeptId).OrderBy(p=>p.EmpName).ToList());

            }
        }

        public List<Emp> SearchByDsc()
        {

            return this.cc.Emps.OrderByDescending(p => p.EmpName).ToList();

        }

        public List<Emp> SearchByAsc()
        {
            return this.cc.Emps.OrderBy(p => p.EmpName).ToList();
        }

        public List<Emp> SearchByProperty(string prop = "", long sort = 0)
        {
           switch(prop)
            {
                case "EmpName":
                    if (sort==1)
                    {
                        var r1=this.cc.Emps.OrderBy(p => p.EmpName);
                        return r1.ToList();                                                      

                    }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
                    else if (sort == 2)
                    {
                      var r2=this.cc.Emps.OrderByDescending(p => p.EmpName);
                        return r2.ToList();
                        
                    }
                    break;
                case "EmpSalary":
                    if (sort==1)
                    {
                       var r3=this.cc.Emps.OrderBy(p => p.EmpSalary);
                        return r3.ToList();
                       
                    }
                    else if ( sort==2)
                    {
                     var r4=this.cc.Emps.OrderByDescending(p => p.EmpSalary);
                        return r4.ToList();
                        
                    }
                    break;
                case "DeptName":
                    if (sort==1)
                    {
                      var r5= this.cc.Emps.OrderBy(p => p.Dept.DeptName);
                        return r5.ToList();
                      
                    }
                    else if (sort==2)
                    {
                      var r6= this.cc.Emps.OrderByDescending(p => p.Dept.DeptName);
                        return r6.ToList();
                       
                    }
                    break;
                default:
                    {
                     var r7= this.cc.Emps.ToList();
                       return r7.ToList();
                    }
                    
                   
                  
            }
            return this.cc.Emps.ToList();
        }
    } 
}
