using System;
using System.Collections.Generic;

namespace ProyectoFinal.Model;

public partial class Menor
{
    public int Id { get; set; }

    public string DuiResponsable { get; set; } = null!;

    public string FechaDeNacimiento { get; set; } = null!;

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string TelefonoResponsable { get; set; } = null!;

    public string CorreoElectronicoResponsable { get; set; } = null!;

    public string DireccionResponsable { get; set; } = null!;

    public int IdDiscapacidad { get; set; }

    public int IdComorbilidad { get; set; }

    public int IdGenero { get; set; }

    public int? IdInstitucionEsencialResponsable { get; set; }

    public int IdEnfermedadCronica { get; set; }

    public virtual ICollection<AplicarVacuna> AplicarVacunas { get; set; } = new List<AplicarVacuna>();

    public virtual ICollection<Citum> Cita { get; set; } = new List<Citum>();

    public virtual Comorbilidad IdComorbilidadNavigation { get; set; } = null!;

    public virtual Discapacidad IdDiscapacidadNavigation { get; set; } = null!;

    public virtual EnfermedadCronica IdEnfermedadCronicaNavigation { get; set; } = null!;

    public virtual Genero IdGeneroNavigation { get; set; } = null!;

    public virtual InstitucionEsencial? IdInstitucionEsencialResponsableNavigation { get; set; }


    // Constructores
    public Menor()
    {

    }

    public Menor(string duiResponsable, string fechaDeNacimiento, string nombres, string apellidos, string telefonoResponsable, string correoElectronicoResponsable, string direccionResponsable, Comorbilidad idComorbilidadNavigation, Discapacidad idDiscapacidadNavigation, EnfermedadCronica idEnfermedadCronicaNavigation, Genero idGeneroNavigation, InstitucionEsencial? idInstitucionEsencialResponsableNavigation)
    {
        DuiResponsable = duiResponsable;
        FechaDeNacimiento = fechaDeNacimiento;
        Nombres = nombres;
        Apellidos = apellidos;
        TelefonoResponsable = telefonoResponsable;
        CorreoElectronicoResponsable = correoElectronicoResponsable;
        DireccionResponsable = direccionResponsable;
        IdComorbilidadNavigation = idComorbilidadNavigation;
        IdDiscapacidadNavigation = idDiscapacidadNavigation;
        IdEnfermedadCronicaNavigation = idEnfermedadCronicaNavigation;
        IdGeneroNavigation = idGeneroNavigation;
        IdInstitucionEsencialResponsableNavigation = idInstitucionEsencialResponsableNavigation;
    }
}
