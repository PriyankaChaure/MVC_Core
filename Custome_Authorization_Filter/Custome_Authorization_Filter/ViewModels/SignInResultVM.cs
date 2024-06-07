namespace Custome_Authorization_Filter.ViewModels
{
    public class SignInResultVM
    {
        public string Message {  get; set; }
        public bool IsLoggedIn {  get; set; }
        public Int64 LoginId {  get; set; }
        public string UserName { get; set; }
    }
}
