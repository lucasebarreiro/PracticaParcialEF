using PracticaParcialEF.Web.Interfaces;
using PracticaParcialEF.Web.Models;

namespace PracticaParcialEF.Web.Services;

public class ReservaService(IReservaRepository _reservaRepository) : IReservaService
{
    public void AgregarReserva(Reserva reserva)
    {
        _reservaRepository.AgregarReserva(reserva);
    }
    public void ActualizarReserva(int id)
    {
        _reservaRepository.ActualizarReserva(id);
    }
    public List<Reserva> ObtenerReservasActivas()
    {
        return _reservaRepository.ObtenerReservasActivas();
    }
}
