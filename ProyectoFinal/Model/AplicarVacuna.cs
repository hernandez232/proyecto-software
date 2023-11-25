using System;
using System.Collections.Generic;

namespace ProyectoFinal.Model;

public partial class AplicarVacuna
{
    public int Id { get; set; }

    public string Fecha { get; set; } = null!;

    public string Hora { get; set; } = null!;

    public int IdDosis { get; set; }

    public int IdVacuna { get; set; }

    public int IdEfectoSecundario { get; set; }

    public int IdVacunador { get; set; }

    public int IdGestor { get; set; }

    public int? IdCiudadano { get; set; }

    public int? IdMenor { get; set; }

    public int? IdExtranjero { get; set; }

    public virtual Ciudadano? IdCiudadanoNavigation { get; set; }

    public virtual Dosi IdDosisNavigation { get; set; } = null!;

    public virtual EfectoSecundario IdEfectoSecundarioNavigation { get; set; } = null!;

    public virtual Extranjero? IdExtranjeroNavigation { get; set; }

    public virtual Gestor IdGestorNavigation { get; set; } = null!;

    public virtual Menor? IdMenorNavigation { get; set; }

    public virtual Vacuna IdVacunaNavigation { get; set; } = null!;

    public virtual Vacunador IdVacunadorNavigation { get; set; } = null!;


    // Constructores
    public AplicarVacuna()
    {

    }

    // Constructor cuando el gestor ingresa la dosis de un ciudadano
    public AplicarVacuna(string fecha, string hora, Ciudadano? idCiudadanoNavigation, Dosi idDosisNavigation, EfectoSecundario idEfectoSecundarioNavigation, Gestor idGestorNavigation, Vacuna idVacunaNavigation, Vacunador idVacunadorNavigation)
    {
        Fecha = fecha;
        Hora = hora;
        IdCiudadanoNavigation = idCiudadanoNavigation;
        IdDosisNavigation = idDosisNavigation;
        IdEfectoSecundarioNavigation = idEfectoSecundarioNavigation;
        IdGestorNavigation = idGestorNavigation;
        IdVacunaNavigation = idVacunaNavigation;
        IdVacunadorNavigation = idVacunadorNavigation;
    }

    // Constructor cuando el gestor ingresa la dosis de un extranjero
    public AplicarVacuna(string fecha, string hora, Dosi idDosisNavigation, EfectoSecundario idEfectoSecundarioNavigation, Extranjero? idExtranjeroNavigation, Gestor idGestorNavigation, Vacuna idVacunaNavigation, Vacunador idVacunadorNavigation)
    {
        Fecha = fecha;
        Hora = hora;
        IdDosisNavigation = idDosisNavigation;
        IdEfectoSecundarioNavigation = idEfectoSecundarioNavigation;
        IdExtranjeroNavigation = idExtranjeroNavigation;
        IdGestorNavigation = idGestorNavigation;
        IdVacunaNavigation = idVacunaNavigation;
        IdVacunadorNavigation = idVacunadorNavigation;
    }

    // Constructor cuando el gestor ingresa la dosis de un menor
    public AplicarVacuna(string fecha, string hora, Dosi idDosisNavigation, EfectoSecundario idEfectoSecundarioNavigation, Gestor idGestorNavigation, Menor? idMenorNavigation, Vacuna idVacunaNavigation, Vacunador idVacunadorNavigation)
    {
        Fecha = fecha;
        Hora = hora;
        IdDosisNavigation = idDosisNavigation;
        IdEfectoSecundarioNavigation = idEfectoSecundarioNavigation;
        IdGestorNavigation = idGestorNavigation;
        IdMenorNavigation = idMenorNavigation;
        IdVacunaNavigation = idVacunaNavigation;
        IdVacunadorNavigation = idVacunadorNavigation;
    }
}