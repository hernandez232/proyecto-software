using System;
using System.Collections.Generic;

namespace ProyectoFinal.Model;

public partial class Extranjero
{
    public int Id { get; set; }

    public string Pasaporte { get; set; } = null!;

    public string FechaDeNacimiento { get; set; } = null!;

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string CorreoElectronico { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public int IdDiscapacidad { get; set; }

    public int IdComorbilidad { get; set; }

    public int IdGenero { get; set; }

    public int IdEnfermedadCronica { get; set; }

    public int IdNacionalidad { get; set; }

    public virtual ICollection<AplicarVacuna> AplicarVacunas { get; set; } = new List<AplicarVacuna>();

    public virtual ICollection<Citum> Cita { get; set; } = new List<Citum>();

    public virtual Comorbilidad IdComorbilidadNavigation { get; set; } = null!;

    public virtual Discapacidad IdDiscapacidadNavigation { get; set; } = null!;

    public virtual EnfermedadCronica IdEnfermedadCronicaNavigation { get; set; } = null!;

    public virtual Genero IdGeneroNavigation { get; set; } = null!;

    public virtual Nacionalidad IdNacionalidadNavigation { get; set; } = null!;


    // Constructores
    public Extranjero()
    {

    }

    public Extranjero(string pasaporte, string fechaDeNacimiento, string nombres, string apellidos, string telefono, string correoElectronico, string direccion, Comorbilidad idComorbilidadNavigation, Discapacidad idDiscapacidadNavigation, EnfermedadCronica idEnfermedadCronicaNavigation, Genero idGeneroNavigation, Nacionalidad idNacionalidadNavigation)
    {
        Pasaporte = pasaporte;
        FechaDeNacimiento = fechaDeNacimiento;
        Nombres = nombres;
        Apellidos = apellidos;
        Telefono = telefono;
        CorreoElectronico = correoElectronico;
        Direccion = direccion;
        IdComorbilidadNavigation = idComorbilidadNavigation;
        IdDiscapacidadNavigation = idDiscapacidadNavigation;
        IdEnfermedadCronicaNavigation = idEnfermedadCronicaNavigation;
        IdGeneroNavigation = idGeneroNavigation;
        IdNacionalidadNavigation = idNacionalidadNavigation;
    }
}
