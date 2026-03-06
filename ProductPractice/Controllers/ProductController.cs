using Microsoft.AspNetCore.Mvc;
using ProductPractice.Models;

namespace ProductPractice.Controllers;

public class ProductController : Controller
{
    DataAccessLayer _dl;

    public ProductController(DataAccessLayer dl)
    {
        _dl = dl;
    }
    
    // GET
    public IActionResult ProductIndex()
    {

        var result = _dl.FetchAll();
        return View(result);
    }
}