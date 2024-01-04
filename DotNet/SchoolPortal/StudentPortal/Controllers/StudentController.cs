using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StudentPortal.Models;
using BOL;
using BLL;
using DAL;

namespace StudentPortal.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }
  
    [HttpGet]
    public IActionResult DisplayAllStudent(){

        StudentManager sm= new StudentManager();
        List<Student> list= new List<Student>();
        list=sm.GetAllStudent();
        ViewData["Student"]=list;
        return View();

    }

    public IActionResult DeleteByID(int id){
        DBManager.DeleteById(id);
        return View();
    }
    [HttpGet]
     public IActionResult InsertData(){
        
        return View();
    }
[HttpPost]
    public IActionResult InsertData(int ID,string FirstName,string LastName,string DOB,string Email){
        DBManager.InsertData(ID,FirstName,LastName,DOB,Email);
        
        return View();
    }


    public IActionResult UpdateData(int ID,string FirstName,string LastName){
        DBManager.UpdateData(ID,FirstName,LastName);
        return View();
    }


    public IActionResult GetByStudentId(int ID){
        Student s=new Student();
        s=DBManager.GetById(ID);
        ViewData["ByID"]=s;
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

