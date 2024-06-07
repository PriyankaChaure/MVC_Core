using Custome_Authorization_Filter.Models;
using Custome_Authorization_Filter.ViewModels;

namespace Custome_Authorization_Filter.Reposiratories
{
    public class UserRepo : UserInterface
    {
        Context c;
        public UserRepo(Context c)
        {
            this.c = c;
        }
        public SignInResultVM SignIn(SignInVM rec)
        {
            SignInResultVM result= new SignInResultVM();
            var urec = this.c.Users.SingleOrDefault(p => (p.EmailId==rec.EmailId && p.Password==rec.Password));
            if(urec != null )
            {
                result.IsLoggedIn = true;
                result.LoginId = urec.UserId;
                result.UserName = urec.FullName;
            }
            else
            {
                result.IsLoggedIn=false;
                result.Message = "Invalid EmailId Or Password!!";
            }
            return result;
        }

        public void SignUp(User rec)
        {
            User u = new User();
            u.EmailId = rec.EmailId;
            u.Password = rec.Password;
            u.FirstName= rec.FirstName;
            u.LastName= rec.LastName;
            u.MobileNo= rec.MobileNo;
            this.c.Users.Add(u);
            this.c.SaveChanges();
        }
    }
}
