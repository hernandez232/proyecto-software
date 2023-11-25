using System;
using System.Collections.Generic;

namespace ProyectoFinal.Model;

public partial class InicioSesion
{
    public int Id { get; set; }

    public DateTime FechaHora { get; set; }

    public int IdGestor { get; set; }

    public int IdCabina { get; set; }

    public virtual Cabina IdCabinaNavigation { get; set; } = null!;

    public virtual Gestor IdGestorNavigation { get; set; } = null!;


    // Constructores
    public InicioSesion()
    {

    }

    public InicioSesion(DateTime fechaHora, Cabina idCabinaNavigation, Gestor idGestorNavigation)
    {
        FechaHora = fechaHora;
        IdCabinaNavigation = idCabinaNavigation;
        IdGestorNavigation = idGestorNavigation;
    }
}
