using EFCoreWithRepPattern.IRepository;
using EFCoreWithRepPattern.Models;

namespace EFCoreWithRepPattern.Repository
{
    public class Repo : IRepo
    {
        AmityDbContext _context;
        public Repo(AmityDbContext context)
        {
            _context = context;
        }
        public void AddUser(TbUser user)
        {
            _context.TbUsers.Add(user);
            _context.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            TbUser user = _context.TbUsers.FirstOrDefault(x => x.Id == id);
            if(user != null)
            {
                _context.TbUsers.Remove(user);
                _context.SaveChanges();
            }
        }

        public TbUser GetUserById(int id)
        {
            return _context.TbUsers.FirstOrDefault(x => x.Id == id);
        }

        public List<TbUser> GetUsers()
        {
            return _context.TbUsers.ToList();
        }

        public void UpdateUser(int id, TbUser user)
        {
          
        }
    }
}
