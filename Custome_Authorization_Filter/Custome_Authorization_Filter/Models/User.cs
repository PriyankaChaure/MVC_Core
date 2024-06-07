using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Custome_Authorization_Filter.Models
{
    public class User
    {
        public Int64 UserId { get; set; }
        [Required(ErrorMessage ="First Name Require!!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name Require!!")]
        public String LastName { get; set; }
        [Required(ErrorMessage = "Email Id Require!!")]
        [EmailAddress(ErrorMessage ="Invali Email ID!!")]
        public string EmailId { get; set; }
        [Required(ErrorMessage = "Mobile No Require!!")]
       
        public string MobileNo { get; set; }
        [Required(ErrorMessage = "Password  Require!!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [NotMapped]
        public string FullName
        {
            get
            {
                 return FirstName + "" + LastName;
               }
        }
        
    }
}
