using GenericRepository.Context;
using GenericRepository.Models;
using GenericRepository.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GenericRepository.Controllers
{
    public class HomeController : Controller
    {
        public IUserService _userService;
        public HomeController(IUserService userservice)
        {
            _userService = userservice;

        }
        public IActionResult AddUser(User user) {
        
        
            _userService.AddUser(user);
            return Ok();

        }
        public IActionResult Index()
        {

            return View();

        }




    }
}