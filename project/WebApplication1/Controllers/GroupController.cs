using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;
namespace WebApplication1.Controllers;
public class GroupController(CollegeRepository data) : Controller { public IActionResult Index() => View(data.Groups); }
