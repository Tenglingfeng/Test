namespace MyIBLL
{
    public interface IUserBll
    {
        void AddNew(string username, string password);

        bool Check(string username);
    }
}