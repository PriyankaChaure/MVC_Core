using MultipleInput.Models;

namespace MultipleInput.Reposiratories
{
    public interface IEmp
    {
        List<Emp> GetAll();
        List<Emp> GetEmpId(Int64 id);
        EmpSkillVM GetCreate(EmpSkillVM rec);
    }
}
