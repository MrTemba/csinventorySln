using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using csinventory.Models;

namespace csinventory.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IInventoryRepository repository;

        public NavigationMenuViewComponent(IInventoryRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Parts
            .Select(x => x.ReWorkable)
            .Distinct()
            .OrderBy(x => x));
        }
    }
}
