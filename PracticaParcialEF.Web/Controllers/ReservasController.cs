using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PracticaParcialEF.Web.Interfaces;
using PracticaParcialEF.Web.Models;

namespace PracticaParcialEF.Web.Controllers;

public class ReservasController(IReservaService _reservaService, IDestinoService _destinoService) : Controller
{
    public IActionResult Agregar()
    {
        var destinos = _destinoService.ObtenerDestinos();
        ViewBag.Destinos = new SelectList(destinos, "IdDestino", "Nombre");
        return View();
    }
    [HttpPost]
    public IActionResult Agregar(Reserva reserva)
    {
        if (ModelState.IsValid)
        {
            _reservaService.AgregarReserva(reserva);
            return RedirectToAction("Listar");
        }
        var destinos = _destinoService.ObtenerDestinos();
        ViewBag.Destinos = new SelectList(destinos, "IdDestino", "Nombre");
        return View(reserva);
    }
    public IActionResult Listar()
    {
        var destinos = _destinoService.ObtenerDestinos();
        ViewBag.Destinos = new SelectList(destinos, "IdDestino", "Nombre");
        var reservas = _reservaService.ObtenerReservasActivas();
        return View(reservas);
    }

    public IActionResult Eliminar(int id)
    {
        _reservaService.ActualizarReserva(id);
        return RedirectToAction("Listar");
    }

}
