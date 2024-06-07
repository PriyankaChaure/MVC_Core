using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreEx.Models
{
    [Table("producttbl")]
    public class Product
    {
        [Key]
        public Int64 ProductId {  get; set; }
        [Required(ErrorMessage ="Product Name Required!")]
        [StringLength(10,MinimumLength =5,ErrorMessage = "Product name Out Of Range!")]
        public string Productname {  get; set; }
        [Required(ErrorMessage = "MFG Name Required!")]
        public string MfgName {  get; set; }
        [Required(ErrorMessage = "Price Required!")]
        [Range(100,1000,ErrorMessage ="price Out Of Range!")]
        public decimal Price {  get; set; }
        [ForeignKey("Category")]
        public Int64 CategoryId {  get; set; }
        public virtual Category Category { get; set; }
    }
}
