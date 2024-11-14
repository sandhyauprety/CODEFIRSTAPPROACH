using Microsoft.AspNetCore.Mvc;

namespace codefirstapproach.Controllers;

public class TodoController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
