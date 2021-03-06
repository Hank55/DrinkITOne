﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkItOne.Models.Repositories;
using DrinkItOne.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DrinkItOne
{
    public class GuestController : Controller
    {
        TestRepository repository = new TestRepository();
        AccountRepository accountRepository;

        public GuestController(AccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }

        [Route("")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(new GuestIndexVM());
        }

        //[Route("")]
        //[HttpPost]
        //public async Task<IActionResult> Index(SearchVM homeIndexVM)
        //{
        //    var valueOf = Request.Form["SearchParameter"];

        //    GuestResultVM[] drinks;
        //    if (String.IsNullOrWhiteSpace(homeIndexVM.SearchItem))
        //    {


        //        if (HttpContext.User.Identity.IsAuthenticated)
        //        {
        //            return RedirectToAction(nameof(UserController.Home), "User");
        //        }
        //        else
        //            return View(new GuestIndexVM());
        //    }

        //    if (valueOf == "Drink")
        //    {
        //        drinks = await repository.SearchResultDrinkName(homeIndexVM.SearchItem);
        //    }
        //    else
        //        drinks = await repository.SearchResultIngredient(homeIndexVM.SearchItem);

        //    return RedirectToAction(nameof(SearchResult));
        //}



        //[Route("SearchResult")]
        //public async Task<IActionResult> SearchResult()
        //{
        //    var drinks = repository.GetLastSearchResult();
        //    if (drinks[0].DrinkName == "NoSearchResult")
        //    {
        //        var user = HttpContext.User;

        //        if (user.Identity.IsAuthenticated)
        //        {
        //            return RedirectToAction(nameof(UserController.Home), "User");
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }

        //    return View(drinks);

        //}
        //[Route("RandomDrink")]
        //public async Task<IActionResult> RandomDrink()
        //{
        //    var drink = await repository.GetRandomDrink();

        //    return RedirectToAction("Recipe", "User", new { id = drink.idDrink });
        //}


        //[Route("Test")]
        //[HttpGet]
        //public async Task<IActionResult> Test()
        //{
        //    accountRepository.removeDrinkFromList(15, "11000");
        //    return View();
        //}


        //[Route("AboutUs")]
        //[HttpGet]
        //public IActionResult AboutUs()
        //{
        //    return View();
        //}
    }
}
