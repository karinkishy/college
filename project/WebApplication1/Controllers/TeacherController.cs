using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;
namespace WebApplication1.Controllers;
public class TeacherController(CollegeRepository data) : Controller { public IActionResult Index() => View(data.Teachers); }
