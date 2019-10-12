using TestIService;

namespace TestService
{
    public class UserService : IUserService
    {
        public bool CheckLogin(string username, string pwd)
        {
            return true;
        }

        public bool CheckUsernameExt(string username)
        {
            return false;
        }
    }
}