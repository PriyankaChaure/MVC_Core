using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace assignment_pc.Models
{
    public class Areatbl
    {
        [Key]
        public Int64 AreaId { get; set; }
        public string AreaName { get; set; }
        [ForeignKey("city")]
        public Int64 CityId {  get; set; }
        public virtual citytbl city { get; set; }
    }
}