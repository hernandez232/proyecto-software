using System;
using System.Collections.Generic;

namespace ProyectoFinal.Model;

public partial class Vacunador
{
    public int Id { get; set; }

    public string Dui { get; set; } = null!;

    public string FechaDeNacimiento { get; set; } = null!;

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string CorreoInstitucional { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public int IdDiscapacidad { get; set; }

    public int IdComorbilidad { get; set; }

    public int IdGenero { get; set; }

    public virtual ICollection<AplicarVacuna> AplicarVacunas { get; set; } = new List<AplicarVacuna>();

    public virtual Comorbilidad IdComorbilidadNavigation { get; set; } = null!;

    public virtual Discapacidad IdDiscapacidadNavigation { get; set; } = null!;

    public virtual Genero IdGeneroNavigation { get; set; } = null!;
}
