using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_Exam.Models
{
    [Table("table_autoparts")]
    public class autoparts
    {
        [Key]
        public Int64 autopartsid {  get; set; }
        public string autopartname { get; set; }
        [ForeignKey("MFG")]
        public Int64 mfgid {  get; set; }
        public virtual MFG MFG { get; set; }
        public string partdesc {  get; set; }
        public virtual List<car> cars { get; set; }

    }
}
