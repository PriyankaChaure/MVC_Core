using CurdUsingRepoDI.Models;

namespace CurdUsingRepoDI.Reposiratories
{
    public class DeptRepo:DeptInterface
    {
        ClassContext cc;
        public DeptRepo(ClassContext cc)
        {
            this.cc = cc;
        }
     
        public List<Dept> GetAllDept()
        {
           return this.cc.Depts.ToList();
        }
    }
}
