using System;
using System.Collections.Generic;

namespace ProyectoFinal.Model;

public partial class Establecimiento
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Citum> Cita { get; set; } = new List<Citum>();
}
