using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;
namespace WebApplication1.Controllers;
public class AttendanceController(CollegeRepository data) : Controller
{
 public IActionResult Index() { ViewBag.Students = data.Students; ViewBag.Records = data.Attendance.GetRecords(); return View(); }
 [HttpPost] public IActionResult Mark(int studentId, DateOnly date, bool present) { data.Attendance.Add(studentId, date, present); return RedirectToAction(nameof(Index)); }
}
