using Getri_LoginService.EntityFramework;
using Getri_LoginService.Models;

namespace Getri_LoginService.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext applicationDbontext;

        public UserRepository(ApplicationDbContext _applicationDbontext)
        {
            applicationDbontext = _applicationDbontext;
        }

        public int CreateUser(User user)
        {
            try
            {
                applicationDbontext.Add(user);
                applicationDbontext.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public bool LoginValidate(string username, string password)
        {
            var temp = applicationDbontext.Users.Where(x => x.Username == username && x.Password == password).FirstOrDefault();

            if (temp == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
