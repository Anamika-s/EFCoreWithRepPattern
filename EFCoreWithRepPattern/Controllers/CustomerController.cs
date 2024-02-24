using EFCoreWithRepPattern.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreWithRepPattern.Controllers
{
    public class CustomerController : Controller
    {
        private IDataRepository<Customer> _repository;
        public CustomerController(IDataRepository<Customer> repository)
        {
            _repository = repository;
        }

        // GET: api/<controller>  
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Customer> customers = _repository.GetAll();
            return Ok(customers);
        }

        // GET api/<controller>/5  
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Customer customer = _repository.Get(id);

            if (customer == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }

            return Ok(customer);
        }
    }
}
