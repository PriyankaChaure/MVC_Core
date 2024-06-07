using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_Exam.Models
{
    [Table("table_mfg")]
    public class MFG
    {
        [Key]
        public Int64 mfgid {  get; set; }
        public String mfgname { get; set;}
        public string address {  get; set;}
        public string emailid {  get; set;}
        public string mobileno {  get; set;}
        public virtual List<autoparts> autoparts { get; set; }
    }
}
