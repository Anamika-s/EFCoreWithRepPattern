using EFCoreWithRepPattern.IRepository;
using EFCoreWithRepPattern.Models;

namespace EFCoreWithRepPattern.Repository
{
    public class RepoUsingADO : IRepo
    {
        public void AddUser(TbUser user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public TbUser GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public List<TbUser> GetUsers()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(int id, TbUser user)
        {
            throw new NotImplementedException();
        }
    }
}
