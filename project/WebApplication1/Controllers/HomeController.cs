using Microsoft.AspNetCore.Mvc;
namespace WebApplication1.Controllers;
public class HomeController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Login() => View();
    [HttpPost] public IActionResult Login(string login, string password) { if (login == "admin" && password == "college123") { HttpContext.Session.SetString("user", "Администратор"); return RedirectToAction("Index"); } ViewBag.Error = "Неверный логин или пароль."; return View(); }
    public IActionResult Logout() { HttpContext.Session.Clear(); return RedirectToAction("Index"); }
    public IActionResult Error() => Content("Произошла ошибка.");
}
