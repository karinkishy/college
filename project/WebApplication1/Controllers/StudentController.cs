using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;
namespace WebApplication1.Controllers;
public class StudentController(CollegeRepository data) : Controller
{
    public IActionResult Index() => View(data.Students);
    [HttpPost] public IActionResult Create(string name, string surname, int age, string group) { try { data.AddStudent(name, surname, age, group); } catch (Exception e) { TempData["Error"] = e.Message; } return RedirectToAction(nameof(Index)); }
}
