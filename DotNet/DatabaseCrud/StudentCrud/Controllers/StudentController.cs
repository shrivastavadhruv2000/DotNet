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
<<<<<<< HEAD
   Console.WriteLine(id+email);
        List<Student>stud=DBManager.GetAllStudents();

        foreach (Student item in stud)
=======
        List<Student> log=DBManager.GetAllStudents();

        foreach (Student item in log)
>>>>>>> e8b45f68237e1e022bf6d13a7aa10c2666e4f91a
        {
            Console.WriteLine(item.ID+item.Email);
            if((item.ID.Equals(id))&&(item.Email.Equals(email))){
                Console.WriteLine("true");
<<<<<<< HEAD
                Response.Redirect("/Student/Data");
=======
                Response.Redirect("/Student/Student");
>>>>>>> e8b45f68237e1e022bf6d13a7aa10c2666e4f91a
            }
            
        }
        return View();
<<<<<<< HEAD
}
=======

    }
>>>>>>> e8b45f68237e1e022bf6d13a7aa10c2666e4f91a

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
