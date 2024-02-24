using EFCoreWithRepPattern.Models;

namespace EFCoreWithRepPattern.IRepository
{
    public interface IRepo
    {
        public List<TbUser> GetUsers();
        public void AddUser(TbUser user);
        public void UpdateUser(int id, TbUser user);
        public void DeleteUser(int id);
        public TbUser GetUserById(int id);
    }
}
