using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_Exam.Models
{
    [Table("table_brand")]
    public class brand
    {
        [Key]
        public Int64 brandid {  get; set; }
        public string brandname {  get; set; }
        public string brandaddress {  get; set; }
        public virtual List<car> cars { get; set; }
    }
}
