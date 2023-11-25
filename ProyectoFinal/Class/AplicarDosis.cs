using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Class
{
    public class AplicarDosis
    {
        public string Vacuna { get; set; }
        public string Dosis { get; set; }
        public string EfectoSecundario { get; set; }
        public string VacunadorNombres { get; set; }
        public string VacunadorApellidos { get; set; }
        public string GestorNombres { get; set; }
        public string GestorApellidos { get; set; }


        // Constructores
        public AplicarDosis()
        {

        }

        public AplicarDosis(string vacuna, string dosis, string efectoSecundario, string vacunadorNombres, string vacunadorApellidos, string gestorNombres, string gestorApellidos)
        {
            this.Vacuna = vacuna;
            this.Dosis = dosis;
            this.EfectoSecundario = efectoSecundario;
            this.VacunadorNombres = vacunadorNombres;
            this.VacunadorApellidos = vacunadorApellidos;
            this.GestorNombres = gestorNombres;
            this.GestorApellidos = gestorApellidos;
        }
    }
}
