using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Class
{
    public class DosisGestor
    {
        public string Documento { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Dosis { get; set; }
        public string Vacuna { get; set; }


        // Constructores
        public DosisGestor()
        {

        }

        public DosisGestor(string documento, string nombres, string apellidos, string fecha, string hora, string dosis, string vacuna)
        {
            Documento = documento;
            Nombres = nombres;
            Apellidos = apellidos;
            Fecha = fecha;
            Hora = hora;
            Dosis = dosis;
            Vacuna = vacuna;
        }
    }
}
