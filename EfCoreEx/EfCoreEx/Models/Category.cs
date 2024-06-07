using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreEx.Models
{
    [Table("categorytbl")]
    public class Category
    {
        [Key]
        public Int64 CategoryId {  get; set; }
        public string CategoryName { get; set; }
        public virtual List<Product> Products {  get; set; }

    }
}


