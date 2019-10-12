using TestIService;

namespace WebApplication1
{
    public class Person
    {
        public IUserService UserService { get; set; }

        public bool SayHello()
        {
            return UserService.CheckLogin("abc", "dasd");
        }
    }
}