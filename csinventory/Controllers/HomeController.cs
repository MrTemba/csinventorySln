using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using csinventory.Models;
using Microsoft.AspNetCore.Mvc;

namespace csinventory.Controllers
{
    public class HomeController : Controller
    {
        private IInventoryRepository repository;
        public HomeController(IInventoryRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index() => View(repository.Parts);
    }
}
