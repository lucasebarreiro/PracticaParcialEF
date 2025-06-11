using Microsoft.EntityFrameworkCore;
using PracticaParcialEF.Web.Interfaces;
using PracticaParcialEF.Web.Models;

namespace PracticaParcialEF.Web.Repositories;

public class ReservaRepository(ReservasViajesContext _context) : IReservaRepository
{
    public void AgregarReserva(Reserva reserva)
    {
        reserva.Eliminado = false;
        _context.Reservas.Add(reserva);
        _context.SaveChanges();
    }
    public void ActualizarReserva(int id)
    {
        var reserva = _context.Reservas.Find(id);
        if (reserva != null)
        {
            reserva.Eliminado = true;
            _context.Reservas.Update(reserva);
            _context.SaveChanges();
        }

    }
    public List<Reserva> ObtenerReservasActivas()
    {
        return _context.Reservas
            .Where(r => r.Eliminado == false)
            .Include(r => r.IdDestinoNavigation)
            .ToList();
    }
}
