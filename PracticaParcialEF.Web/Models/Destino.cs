using System;
using System.Collections.Generic;

namespace PracticaParcialEF.Web.Models;

public partial class Destino
{
    public int IdDestino { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
}
