namespace MultipleInput.Models
{
    public class Emp
    {
        public Int64 EmpId {  get; set; }
        public string EmpName {  get; set; }
        public string Address {  get; set; }         
        public string EmailId {  get; set; }
        public string PhoneNumber { get; set; }
        public virtual List<EmpSkill> EmpSkills { get; set; }
        public Emp()
        {
            EmpSkills = new List<EmpSkill>();
        }
    }
}
