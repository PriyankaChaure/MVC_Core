 
using CurdUsingRepoDI.Models;

namespace CurdUsingRepoDI.Reposiratories
{
    public interface EmpInterface
    {
        List<Emp> GetAllEmp();
        List<Emp> GetDeptId(Int64 deptid);
        List<Emp> SearchByDsc();
        List<Emp> SearchByAsc();
       List<Emp> SearchByProperty( string prop="", Int64 sort = 0);
        Emp GetEmpById(Int64 id);
        void Add(Emp rec);
        void Edit(Emp rec);
        void Delete(long id);
        void Details(long id);
    }
}
