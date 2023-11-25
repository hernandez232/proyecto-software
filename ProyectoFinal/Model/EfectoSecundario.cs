using System;
using System.Collections.Generic;

namespace ProyectoFinal.Model;

public partial class EfectoSecundario
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<AplicarVacuna> AplicarVacunas { get; set; } = new List<AplicarVacuna>();
}
