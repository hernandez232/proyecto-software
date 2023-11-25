using System;
using System.Collections.Generic;

namespace ProyectoFinal.Model;

public partial class Citum
{
    public int Id { get; set; }

    public string Fecha { get; set; } = null!;

    public string Hora { get; set; } = null!;

    public int IdEstablecimiento { get; set; }

    public int? IdGestor { get; set; }

    public int? IdCiudadano { get; set; }

    public int? IdMenor { get; set; }

    public int? IdExtranjero { get; set; }

    public virtual Ciudadano? IdCiudadanoNavigation { get; set; }

    public virtual Establecimiento IdEstablecimientoNavigation { get; set; } = null!;

    public virtual Extranjero? IdExtranjeroNavigation { get; set; }

    public virtual Gestor? IdGestorNavigation { get; set; }

    public virtual Menor? IdMenorNavigation { get; set; }


    // Constructores
    public Citum()
    {

    }

    // Constructor cuando el cuidadano agenda la cita
    public Citum(string fecha, string hora, Ciudadano? idCiudadanoNavigation, Establecimiento idEstablecimientoNavigation)
    {
        Fecha = fecha;
        Hora = hora;
        IdCiudadanoNavigation = idCiudadanoNavigation;
        IdEstablecimientoNavigation = idEstablecimientoNavigation;
    }

    // Constructor cuando el extranjero agenda la cita
    public Citum(string fecha, string hora, Establecimiento idEstablecimientoNavigation, Extranjero? idExtranjeroNavigation)
    {
        Fecha = fecha;
        Hora = hora;
        IdEstablecimientoNavigation = idEstablecimientoNavigation;
        IdExtranjeroNavigation = idExtranjeroNavigation;
    }

    // Constructor cuando el menor agenda la cita
    public Citum(string fecha, string hora, Establecimiento idEstablecimientoNavigation, Menor? idMenorNavigation)
    {
        Fecha = fecha;
        Hora = hora;
        IdEstablecimientoNavigation = idEstablecimientoNavigation;
        IdMenorNavigation = idMenorNavigation;
    }

    // Constructor cuando el gestor cuidadano agenda la cita de un ciudadano
    public Citum(string fecha, string hora, Ciudadano? idCiudadanoNavigation, Establecimiento idEstablecimientoNavigation, Gestor? idGestorNavigation) : this(fecha, hora, idCiudadanoNavigation, idEstablecimientoNavigation)
    {
        IdGestorNavigation = idGestorNavigation;
    }

    // Constructor cuando el gestor cuidadano agenda la cita de un extranjero
    public Citum(string fecha, string hora, Establecimiento idEstablecimientoNavigation, Extranjero? idExtranjeroNavigation, Gestor? idGestorNavigation) : this(fecha, hora, idEstablecimientoNavigation, idExtranjeroNavigation)
    {
        IdGestorNavigation = idGestorNavigation;
    }

    // Constructor cuando el gestor cuidadano agenda la cita de un menor
    public Citum(string fecha, string hora, Establecimiento idEstablecimientoNavigation, Gestor? idGestorNavigation, Menor? idMenorNavigation)
    {
        Fecha = fecha;
        Hora = hora;
        IdEstablecimientoNavigation = idEstablecimientoNavigation;
        IdGestorNavigation = idGestorNavigation;
        IdMenorNavigation = idMenorNavigation;
    }
}
