namespace SecondApp;

using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class HomeController : Controller
{

    private readonly DatabaseConnection _context;

    public HomeController(DatabaseConnection context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Calculate(double number1, double number2)
    {
        // Continue HERE
        double result = num  
    }
}