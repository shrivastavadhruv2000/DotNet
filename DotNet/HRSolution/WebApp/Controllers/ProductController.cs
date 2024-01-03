using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using BLL;
using BOL;
using DAL;
using System.Security.Cryptography.X509Certificates;

namespace WebApp.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }
    public IActionResult Product(){
        ProductManager pm=new ProductManager();
        List<Product>pro=pm.DisplayProduct();
         ViewData["product"]=pro;

        return View();
    }
public IActionResult Insert(){
    return View();
}
    [HttpPost]
    public IActionResult Insert(int pid,string pname,int quantity,double price){
       
        Product p=new Product();
        Console.WriteLine(pid+pname);
        p.pid=pid;
        p.pname=pname;
        p.quantity=quantity;
        p.price=price;
        DBManager.InsertData(p);
        return View();
    } 
public IActionResult Delete(int pid){
    Console.WriteLine(pid);
    DBManager.DeleteData(pid);
    return View();

}
public IActionResult Update(int pid,string pname,int quantity,double price){
    Product p=new Product();
        Console.WriteLine(pid+pname);
        p.pid=pid;
        p.pname=pname;
        p.quantity=quantity;
        p.price=price;
        DBManager.UpdateData(p);
        return View();
}
}
