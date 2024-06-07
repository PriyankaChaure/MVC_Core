using Custome_Authorization_Filter.Models;
using Custome_Authorization_Filter.ViewModels;

namespace Custome_Authorization_Filter.Reposiratories
{
    public interface UserInterface
    {
        void SignUp(User rec);
        SignInResultVM SignIn(SignInVM rec);
    }
}
