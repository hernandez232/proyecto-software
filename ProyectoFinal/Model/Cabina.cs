using System;
using System.Collections.Generic;

namespace ProyectoFinal.Model;

public partial class Cabina
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string CorreoElectronico { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public virtual ICollection<InicioSesion> InicioSesions { get; set; } = new List<InicioSesion>();
}
