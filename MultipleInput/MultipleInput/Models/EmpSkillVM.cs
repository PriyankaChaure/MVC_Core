namespace MultipleInput.Models
{
    public class EmpSkillVM
    {
        public Int64 EmpId { get; set; }
        public string EmpName { get; set; }
        public string Address { get; set; }
        public string EmailId { get; set; }
        public string PhoneNumber { get; set; }
        public List<Int64> SkillId  { get; set; }
        public List<int> Experience {  get; set; }
        public List<string> Remark { get; set; }
        public EmpSkillVM()
        {
            SkillId=new List<Int64>();
            Experience=new List<int>();
            Remark=new List<string>();
        }
    }
}
