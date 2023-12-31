using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Product.Models;
using System.Collections.Generic;
using BLL;
using BOL;
using DAL;



namespace Product.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult All(){
        ProductManager pm= new ProductManager();
         List<ProductDetail> list=new List<ProductDetail>();
         list=pm.GetProducts();
         ViewData["Products"]=list;
         return View();
                  
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
