using PracticaParcialEF.Web.Models;

namespace PracticaParcialEF.Web.Interfaces;

public interface IDestinoRepository
{
    void AgregarDestino(Destino destino);
    List<Destino> ObtenerDestinos();


}
