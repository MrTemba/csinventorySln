using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using csinventory.Models;
using csinventory.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace csinventory.Controllers
{
    public class PartsController : Controller
    {
        private IInventoryRepository repository;
        public int PageSize = 20;
        public PartsController(IInventoryRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index(bool? category = null, int partPage = 1) => View(
            new PartsListViewModel { 
            Parts = repository.Parts
            .Where(p => category == null || p.ReWorkable == category)
            .OrderBy(p=>p.PartID)
            .Skip((partPage-1)*PageSize)
            .Take(PageSize),
            PagingInfo = new PagingInfo
            {
                CurrentPage = partPage,
                ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                        repository.Parts.Count() :
                        repository.Parts.Where(e =>
                            e.ReWorkable == category).Count()
            },
            CurrentCategory = category.ToString()
            });
    }
}
