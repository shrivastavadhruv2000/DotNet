using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StudentPortal.Models;
using System.Collections.Generic;
using BOL;
using web.BLL;

namespace StudentPortal.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }

    public IActionResult Students()
    {
        List<Student> list= new List<Student>();
        list = ProductManager.GetAll();
        ViewData["Students"] =list;
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
