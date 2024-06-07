using MultipleInput.Models;
namespace MultipleInput.Reposiratories
{
    public interface ISkill
    {
        List<Skill> GetAllSkill();
        List<Skill> GetSkillId(Int64 id);                                     
    }
}
