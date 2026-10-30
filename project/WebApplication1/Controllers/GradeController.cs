using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;
namespace WebApplication1.Controllers;
public class GradeController(CollegeRepository data) : Controller
{
 public IActionResult Index() { ViewBag.Students = data.Students; return View(data.Grades); }
 [HttpPost] public IActionResult Create(int studentId, string subject, int value) { try { data.AddGrade(studentId, subject, value); } catch(Exception e) { TempData["Error"] = e.Message; } return RedirectToAction(nameof(Index)); }
}
