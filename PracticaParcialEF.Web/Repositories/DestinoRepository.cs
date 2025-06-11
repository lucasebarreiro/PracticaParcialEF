using PracticaParcialEF.Web.Interfaces;
using PracticaParcialEF.Web.Models;

namespace PracticaParcialEF.Web.Repositories;

public class DestinoRepository(ReservasViajesContext _context) : IDestinoRepository
{
    public void AgregarDestino(Destino destino)
    {
        _context.Destinos.Add(destino);
        _context.SaveChanges();
    }
    public List<Destino> ObtenerDestinos()
    {
        return _context.Destinos.ToList();
    }
}
