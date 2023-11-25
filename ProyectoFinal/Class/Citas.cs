using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Class
{
    public class Citas
    {
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Establecimiento { get; set; }


        // Constructores
        public Citas()
        {

        }

        public Citas(string fecha, string hora, string establecimiento)
        {
            Fecha = fecha;
            Hora = hora;
            Establecimiento = establecimiento;
        }
    }
}
