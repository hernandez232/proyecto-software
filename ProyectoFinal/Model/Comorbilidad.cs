using System;
using System.Collections.Generic;

namespace ProyectoFinal.Model;

public partial class Comorbilidad
{
    public int Id { get; set; }

    public string? Comorbilidad1 { get; set; }

    public virtual ICollection<Ciudadano> Ciudadanos { get; set; } = new List<Ciudadano>();

    public virtual ICollection<Extranjero> Extranjeros { get; set; } = new List<Extranjero>();

    public virtual ICollection<Gestor> Gestors { get; set; } = new List<Gestor>();

    public virtual ICollection<Menor> Menors { get; set; } = new List<Menor>();

    public virtual ICollection<Vacunador> Vacunadors { get; set; } = new List<Vacunador>();
}
