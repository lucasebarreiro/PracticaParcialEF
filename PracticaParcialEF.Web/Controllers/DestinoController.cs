using Microsoft.AspNetCore.Mvc;
using PracticaParcialEF.Web.Interfaces;
using PracticaParcialEF.Web.Models;

namespace PracticaParcialEF.Web.Controllers;

public class DestinoController(IDestinoService _destinoService) : Controller
{
    public IActionResult Agregar()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Agregar(Destino destino)
    {
        if (ModelState.IsValid)
        {
            _destinoService.AgregarDestino(destino);
            return RedirectToAction("Listar");
        }
        return View(destino);
    }
    public IActionResult Listar()
    {
        var destinos = _destinoService.ObtenerDestinos();
        return View(destinos);
    }
}
