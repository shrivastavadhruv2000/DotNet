using System.Diagnostics;
using BOL;
using DAL;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers;

public class CustomerController : Controller
{
    private readonly ILogger<CustomerController> _logger;

    public CustomerController(ILogger<CustomerController> logger)
    {
        _logger = logger;
    }
public IActionResult Register(string cname,string contact,string email,string password){
    Console.WriteLine(cname+email);
    Customer c=new Customer();
    c.cname=cname;
    c.contact=contact;
    c.email=email;
    c.password=password;
    DBManager.RegisterData(c);
return View();
}

public IActionResult Login(string email,string password){
   Console.WriteLine(email+password);
        List<Customer>cust=DBManager.GetAllCustomer();

        foreach (Customer item in cust)
        {
            Console.WriteLine(item.email+item.password);
            if((item.email.Equals(email))&&(item.password.Equals(password))){
                Console.WriteLine("true");
                Response.Redirect("/Product/Product");
            }
            
        }
        return View();
}
    
}
