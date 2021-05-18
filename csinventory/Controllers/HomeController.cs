using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using csinventory.Models;
using csinventory.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace csinventory.Controllers
{
    public class HomeController : Controller
    {
        private IInventoryRepository repository;
        public int PageSize = 20;
        public HomeController(IInventoryRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index(int partPage = 1) => View(
            new PartsListViewModel { 
            Parts = repository.Parts
            .OrderBy(p=>p.PartID)
            .Skip((partPage-1)*PageSize)
            .Take(PageSize),
            PagingInfo = new PagingInfo
            {
                CurrentPage = partPage,
                ItemsPerPage = PageSize,
                TotalItems = repository.Parts.Count()
            }
            });
    }
}
