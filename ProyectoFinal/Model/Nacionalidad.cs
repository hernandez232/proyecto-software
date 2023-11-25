using System;
using System.Collections.Generic;

namespace ProyectoFinal.Model;

public partial class Nacionalidad
{
    public int Id { get; set; }

    public string? Nacionalidad1 { get; set; }

    public virtual ICollection<Extranjero> Extranjeros { get; set; } = new List<Extranjero>();
}
