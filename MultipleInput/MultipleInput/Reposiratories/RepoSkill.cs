using MultipleInput.Models;

namespace MultipleInput.Reposiratories
{
    public class RepoSkill:ISkill
    {
        ContextClass cc;
        public RepoSkill(ContextClass cc)
        {
            this.cc=cc;
        }
        public List<Skill> GetAllSkill()
        {
            return this.cc.Skills.ToList();
        }

        public List<Skill> GetSkillId(long id)
        {
            return this.cc.Skills.Where(p => p.SkillId==id).ToList();
        }
    }
}
