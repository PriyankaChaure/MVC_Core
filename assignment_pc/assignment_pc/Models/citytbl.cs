using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace assignment_pc.Models
{
    public class citytbl
    {
        [Key]
        public Int64 CityId {  get; set; }
        public string CityName { get; set; }
        public virtual List<Areatbl> Areatbls { get; set; }
    }
}