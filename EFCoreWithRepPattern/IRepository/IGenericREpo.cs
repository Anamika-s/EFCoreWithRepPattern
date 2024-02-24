using EFCoreWithRepPattern.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreWithRepPattern.IRepository
{

    public class Customer
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }

    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        void Add(TEntity entity);
        void Change(TEntity dbEntity, TEntity entity);
        void Delete(TEntity entity);
    }

   
    // Repo Class 
    public class CustomerManager : IDataRepository<Customer>  
    {  
        readonly AmityDbContext _contextDb;  
        public CustomerManager(AmityDbContext context)  
        {  
            _contextDb = context;  
        }  
      
        public IEnumerable<Customer> GetAll()  
        {  
            return _contextDb.Customers.ToList();  
        }  
      
        public Customer Get(int id)  
        {  
            return _contextDb.Customers  
                  .FirstOrDefault(e => e.ID == id);  
        }  
      
        public void Add(Customer customer)  
        {  
            _contextDb.Customers.Add(customer);  
            _contextDb.SaveChanges();  
        }  
      
        public void Change(Customer customer, Customer entity)  
        {  
      
            customer.Name = entity.Name;  
            customer.Email = entity.Email;  
            customer.Mobile = entity.Mobile;  
      
               _contextDb.SaveChanges();  
        }  
      
        public void Delete(Customer customer)  
        {  
            _contextDb.Customers.Remove(customer);  
            _contextDb.SaveChanges();  
        }  
    }   
}
