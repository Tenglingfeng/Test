namespace TestIService
{
    public interface IUserService
    {
        bool CheckLogin(string username, string pwd);

        bool CheckUsernameExt(string username);
    }
}