using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace PracticaParcialEF.Web.Models;

public partial class Reserva
{
    public int IdReserva { get; set; }

    public int CantidadPasajeros { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaFin { get; set; }

    public int IdDestino { get; set; }

    public bool? Eliminado { get; set; }
    [ValidateNever]
    public virtual Destino IdDestinoNavigation { get; set; } = null!;
}
