using MultipleInput.Models;

namespace MultipleInput.Reposiratories
{
    public class RepoEmp : IEmp
    {
        ContextClass cc;
        public RepoEmp(ContextClass cc) 
        {
            this.cc=cc;
        }
        public List<Emp> GetAll()
        {
            return this.cc.Emps.ToList();
        }

        public EmpSkillVM GetCreate(EmpSkillVM rec)
        {
           Emp e=new Emp();
            e.EmpName=rec.EmpName;
            e.Address=rec.Address;
            e.PhoneNumber=rec.PhoneNumber;
            e.EmailId=rec.EmailId;
            for(int i=0;i<rec.SkillId.Count();i++)
            {
                EmpSkill es=new EmpSkill();
                es.SkillId=rec.SkillId[i];
                es.Remark=rec.Remark[i];
                es.ExperienceInMonth=rec.Experience[i];
                e.EmpSkills.Add(es);
            }
            this.cc.Emps.Add(e);
            this.cc.SaveChanges();
            return null;
        }

        public List<Emp> GetEmpId(long id)
        {
           return this.cc.Emps.Where(p=>p.EmpId==id).ToList();
        }
    }
}
