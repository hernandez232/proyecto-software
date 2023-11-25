﻿using System;
using System.Collections.Generic;

namespace ProyectoFinal.Model;

public partial class InstitucionEsencial
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Ciudadano> Ciudadanos { get; set; } = new List<Ciudadano>();

    public virtual ICollection<Menor> Menors { get; set; } = new List<Menor>();
}
