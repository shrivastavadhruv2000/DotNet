using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StudentCrud.Models;
using System.Collections.Generic;
using BLL;
using BOL;
using Org.BouncyCastle.Asn1.Iana;
using DAL;


namespace StudentCrud.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }

    public IActionResult Data()
    {
        CataLogManager cm=new CataLogManager();
        
        List<Student> list=new List<Student>();
        list=cm.GetAllStudents();
        ViewData["Student"]=list;
        return View();
    }

    // public IActionResult Register(){
    //     return View();
    // }

    public IActionResult Register(int id,string namefirst,string namelast, string dob,string email ){
    DBManager.insertStudent(id,namefirst,namelast,dob,email);
    
        
        return View();
    }

    public IActionResult Login(int id,string email){
        List<Student> log=DBManager.GetAllStudents();

        foreach (Student item in log)
        {
            Console.WriteLine(item.ID+item.Email);
            if((item.ID.Equals(id))&&(item.Email.Equals(email))){
                Console.WriteLine("true");
                Response.Redirect("/Student/Student");
            }
            
        }
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
