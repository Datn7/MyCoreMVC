using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCoreMVC.Models;
using MyCoreMVC.ViewModels;

namespace MyCoreMVC.Controllers
{
    public class BagController : Controller
    {
        private readonly IBagRepo bagRepo;
        private readonly ICategoryRepo categoryRepo;

        public BagController(IBagRepo bagRepo, ICategoryRepo categoryRepo)
        {
            this.bagRepo = bagRepo;
            this.categoryRepo = categoryRepo;
        }

        public ViewResult List()
        {
            BagListViewModel bagListViewModel = new BagListViewModel();
            bagListViewModel.Bags = bagRepo.AllBags;
            bagListViewModel.CurrentCategory = "ბეყე";

            return View(bagListViewModel);
        }

        public IActionResult Details(int id)
        {
            var bag = bagRepo.GetBagById(id);

            if (bag == null)
                return NotFound();
            return View(bag);
        }

    }
}