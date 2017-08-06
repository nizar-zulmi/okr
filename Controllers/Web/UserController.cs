using System;
using Microsoft.AspNetCore.Mvc;
using okr.Models.Database;
using okr.Respositories;

namespace okr.Controllers
{
    public class UserController : Controller
    {
        private IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }        

        public IActionResult Index()
        {
            var data = _userRepository.GetAllUsers();
            return View(data);
        }

        // private readonly UserRepository _userRepository;
        // public UserController(DatabaseContext databaseContext)
        // {
        //     _userRepository = new UserRepository(databaseContext);
        // }

        // [HttpGet("/")]
        // public ActionResult Index()
        // {
        //     var email = "zulmimi@hotmail.com";
        //     var user = _userRepository.GetByEmail(email);
        //     var userViewModel = UserViewModelMapper.MapFrom(user);
        //     return View(userViewModel);
        // }
    }
}