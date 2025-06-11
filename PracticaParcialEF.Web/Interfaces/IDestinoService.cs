using PracticaParcialEF.Web.Models;

namespace PracticaParcialEF.Web.Interfaces;

public interface IDestinoService
{
    void AgregarDestino(Destino destino);
    List<Destino> ObtenerDestinos();
}
