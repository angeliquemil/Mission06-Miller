using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6.Models;
namespace Mission6.Controllers;

// Main controller
public class HomeController : Controller
{
    private MovieContext _context;
    
    public HomeController(MovieContext temp)
    {
        _context = temp;
    }
    
    // Home Page
    public IActionResult Index()
    {
        return View();
    }

    // Get to Know You Page
    public IActionResult Get2Know()
    {
        return View();
    }

    // Get and Post for the AddMovie View
    [HttpGet]
    public IActionResult AddMovie()
    {
        return View();
    }
    [HttpPost]
    public IActionResult AddMovie(Movie response)
    {
        _context.Movies.Add(response);
        _context.SaveChanges();
        // Pass the form info to the Confirmation view
        return View("Confirmation", response);
    }
}