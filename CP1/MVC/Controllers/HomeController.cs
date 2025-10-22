using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        ViewBag.Valid = false;  //Error: Inicializar valores en el controlador
        return View(new TheModel());
    }

    [HttpPost]
    public IActionResult Index(TheModel model)
    {
        var valid = ModelState.IsValid; // Error
        ViewBag.Valid = valid;           

        if (valid)
        {   //https://chat.deepseek.com/share/toweona8vta01zog3o
            var charsNoSpaces = model.Phrase!.Where(c => c != ' '); // Improvement: Eliminar los espacios
            model.Counts!.Clear();
            model.Lower = string.Empty;
            model.Upper = string.Empty;

            foreach (var c in charsNoSpaces)
            {
                if (!model.Counts.ContainsKey(c))
                {
                    model.Counts[c] = 0;
                }
                model.Counts[c]++;
                model.Lower += char.ToLowerInvariant(c);
                model.Upper += char.ToUpperInvariant(c);
            }
        }
        return View(model);
    }
}
