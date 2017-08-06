using System;
using Microsoft.AspNetCore.Mvc;
using okr.Models.Database;
using okr.Respositories;

namespace okr.Controllers
{
    public class ObjectiveController : Controller
    {
        public ObjectiveController()
        {
        }        

        public IActionResult Index()
        {
            return View();
        }
    }
}