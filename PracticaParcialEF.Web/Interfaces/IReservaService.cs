using PracticaParcialEF.Web.Models;

namespace PracticaParcialEF.Web.Interfaces;

public interface IReservaService
{
    void AgregarReserva(Reserva reserva);
    void ActualizarReserva(int id);
    List<Reserva> ObtenerReservasActivas();
}
