using Getri_LoginService.Models;

namespace Getri_LoginService.Repository
{
    public interface IUserRepository
    {
        int CreateUser(User user);

        bool LoginValidate(string username, string password);
    }
}
