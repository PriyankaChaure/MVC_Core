namespace MultipleInput.Models
{
    public class Skill
    {
        public Int64 SkillId { get; set; }  
        public string SkillName { get; set; }
        public virtual List<EmpSkill> EmpSkills { get; set; }
    }
}
