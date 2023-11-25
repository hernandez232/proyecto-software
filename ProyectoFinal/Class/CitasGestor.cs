using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Class
{
    public class CitasGestor
    {
        public string Documento { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Establecimiento { get; set; }


        // Constructores
        public CitasGestor()
        {

        }

        public CitasGestor(string documento, string nombres, string apellidos, string fecha, string hora, string establecimiento)
        {
            Documento = documento;
            Nombres = nombres;
            Apellidos = apellidos;
            Fecha = fecha;
            Hora = hora;
            Establecimiento = establecimiento;
        }
    }
}
