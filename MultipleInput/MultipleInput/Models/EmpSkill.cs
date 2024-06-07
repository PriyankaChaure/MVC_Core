using System.ComponentModel.DataAnnotations.Schema;

namespace MultipleInput.Models
{
    public class EmpSkill
    {
        public Int64 EmpSkillId {  get; set; }
        [ForeignKey("Emp")]
        public Int64 EmpId { get; set; }
        public virtual Emp Emp {  get; set; }
        [ForeignKey("Skills")]
        public Int64 SkillId { get; set; }
        public virtual Skill Skills { get; set; }
        public int ExperienceInMonth {  get; set; }
        public string Remark {  get; set; }

    }
}
