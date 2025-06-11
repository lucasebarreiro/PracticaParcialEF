using PracticaParcialEF.Web.Interfaces;
using PracticaParcialEF.Web.Models;

namespace PracticaParcialEF.Web.Services;

public class DestinoService(IDestinoRepository _destinoRepository) : IDestinoService
{
    public void AgregarDestino(Destino destino)
    {
        _destinoRepository.AgregarDestino(destino);
    }
    public List<Destino> ObtenerDestinos()
    {
        return _destinoRepository.ObtenerDestinos();
    }
}
