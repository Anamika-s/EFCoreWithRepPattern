using EFCoreWithRepPattern.IRepository;
using EFCoreWithRepPattern.Models;
using EFCoreWithRepPattern.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreWithRepPattern.Controllers
{
    public class UserController : Controller
    {
        IRepo _repo;
        public UserController(IRepo repo)
        {
            _repo = repo;
        }

        // GET: UserController
        public ActionResult Index()
        {
            return View(_repo.GetUsers());
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View(_repo.GetUserById(id));
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TbUser user)
        {
            try
            {
                _repo.AddUser(user);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
