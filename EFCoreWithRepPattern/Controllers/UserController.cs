using EFCoreWithRepPattern.IRepository;
using EFCoreWithRepPattern.Models;
using EFCoreWithRepPattern.Repository;
using log4net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
using System.Collections.Generic;

namespace EFCoreWithRepPattern.Controllers
{
    public class UserController : Controller
    {
        IRepo _repo;
        private readonly ILog _logger;

        public UserController(IRepo repo )
        {
           
            _repo = repo;
            //_logger = logger ?? throw new ArgumentNullException(nameof(logger));

        }

        // GET: UserController
        public ActionResult Index()
        {
            var _logger = log4net.LogManager.GetLogger(typeof(UserController));
           

            _logger.Info("This is info ");
            _logger.Error("ERror");
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
