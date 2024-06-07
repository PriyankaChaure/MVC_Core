using System.ComponentModel.DataAnnotations;

namespace Custome_ActionFilter.Models
{
    public class ActionLog
    {
        [Key]
        public Int64 ActionLogId {  get; set; }
        public DateTime ActionLogDate { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set;}
    }
}
