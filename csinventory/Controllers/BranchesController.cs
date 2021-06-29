using csinventory.Models;
using csinventory.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csinventory.Controllers
{
    public class BranchesController : Controller
    {
        private IInventoryRepository repository;

        public BranchesController(IInventoryRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index()
        {
            return View(
                new BranchesListViewModel{
                    Branches = repository.Branches.OrderBy(it=>it.BranchID)
                }
            );
        }
    }
}
