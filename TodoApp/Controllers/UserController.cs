using Microsoft.AspNetCore.Mvc;
using TodoApp.Models;
using TodoApp.Repository;
using TodoApp.Repository.InMemory;
using TodoApp.Repository.MsSQL;
using TodoApp.ViewModels;

namespace TodoApp.Controllers
{
    public class UserController : Controller
    {

        IUserRepository _repo;
        public UserController(IUserRepository repo)
        {
            this._repo = repo;
        }
        public IActionResult GetAllUsers()
        {
            var userlist = _repo.GetAllUsers();
            return View(userlist);
        }
        public IActionResult Details(int userId)
        {
            var user = _repo.GetUserById(userId);
            return View(user);
        }
        public IActionResult Delete(int userId)
        {
            var userlist = _repo.DeleteUser(userId);
            return RedirectToAction(controllerName: "User", actionName: "GetAllUsers");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User newUser)
        {
            if (ModelState.IsValid)
            {
                var user = _repo.AddUser(newUser);
                return RedirectToAction("GetAllUsers");
            }

            ViewData["Message"] = "Data is not valid to create the User";
            return View();

        }

        [HttpGet]
        public IActionResult Update(int userId)
        {
            var oldUser = _repo.GetUserById(userId);
            return View(oldUser);
        }

        [HttpPost]
        public IActionResult Update(User newUser)
        {
            var oldUser = _repo.UpdateUser(newUser.Id, newUser);
            return RedirectToAction("GetAllUsers");
        }

    }
}
