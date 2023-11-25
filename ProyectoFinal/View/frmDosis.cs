using ProyectoFinal.Context;
using ProyectoFinal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.View
{
    public partial class frmDosis : Form
    {
        public Gestor gestor { get; set; }

        public frmDosis(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void frmDosis_Load(object sender, EventArgs e)
        {
            // Obtener gestor y cabina de la DB
            var db = new ProyectoFinalContext();

            // Mostrar el comboBox de dosis al cargar el formulario
            cmbDosis.DataSource = db.Dosis.ToList();
            cmbDosis.DisplayMember = "Nombre";
            cmbDosis.ValueMember = "Id";

            // Mostrar el comboBox de vacuna al cargar el formulario
            cmbVacuna.DataSource = db.Vacunas.ToList();
            cmbVacuna.DisplayMember = "Nombre";
            cmbVacuna.ValueMember = "Id";

            // Mostrar el comboBox de vacunador al cargar el formulario
            cmbVacunador.DataSource = db.Vacunadores.ToList();
            cmbVacunador.DisplayMember = "Id";
            cmbVacunador.ValueMember = "Id";

            // Mostrar el comboBox de efecto secundario al cargar el formulario
            cmbEfectoSecundario.DataSource = db.EfectosSecundarios.ToList();
            cmbEfectoSecundario.DisplayMember = "Nombre";
            cmbEfectoSecundario.ValueMember = "Id";
        }

        private void frmDosis_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cerrar ventanas para evitar ventanas escondidas
            Application.Exit();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMain ventana = new frmMain(gestor);
            ventana.Show();
            this.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Definir los comboBox de referencia
            Dosi doref = (Dosi)cmbDosis.SelectedItem;
            Vacuna vref = (Vacuna)cmbVacuna.SelectedItem;
            Vacunador vcref = (Vacunador)cmbVacunador.SelectedItem;
            EfectoSecundario esref = (EfectoSecundario)cmbEfectoSecundario.SelectedItem;

            // Establecer conexion con la DB
            var db = new ProyectoFinalContext();

            // Obtener comboBox de la DB
            Dosi dodb = db.Set<Dosi>()
                .SingleOrDefault(d => d.Id.Equals(doref.Id));

            Vacuna vdb = db.Set<Vacuna>()
                .SingleOrDefault(v => v.Id.Equals(vref.Id));

            Vacunador vcdb = db.Set<Vacunador>()
                .SingleOrDefault(vc => vc.Id.Equals(vcref.Id));

            EfectoSecundario esdb = db.Set<EfectoSecundario>()
                .SingleOrDefault(es => es.Id.Equals(esref.Id));

            // Obtener gestor de la DB
            Gestor gdb = db.Set<Gestor>()
                .Single(g => g.Id.Equals(gestor.Id));


            // Validar que los datos del formulario están completos
            var validar = txtDocumento.Text.Length > 0 && txtFecha.Text.Length > 0 && txtHora.Text.Length > 0;


            // Obtener ciudadanos de la DB y verificar si el documento ingresado le pertenece a un ciudadano
            var verificar0 = db.Ciudadanos
                .OrderBy(c => c.Id)
                .Where(c => c.Dui.Equals(txtDocumento.Text))
                .ToList();

            // Obtener extranjeros de la DB y verificar si el documento ingresado le pertenece a un extranjero
            var verificar1 = db.Extranjeros
                .OrderBy(e => e.Id)
                .Where(e => e.Pasaporte.Equals(txtDocumento.Text))
                .ToList();

            // Obtener menores de edad de la DB y verificar si el documento ingresado le pertenece a un menor de edad
            var verificar2 = db.Menores
                .OrderBy(m => m.Id)
                .Where(m => m.DuiResponsable.Equals(txtDocumento.Text))
                .ToList();

            // Si encontró un ciudadano
            if (gdb != null && validar && verificar0.Count > 0)
            {
                // Buscar el ciudadano
                Ciudadano cdb = db.Set<Ciudadano>()
                    .Single(c => c.Dui.Equals(txtDocumento.Text));

                // Crear dosis y añadirla a la DB
                AplicarVacuna nuevaAplicacion = new(
                    txtFecha.Text, txtHora.Text, cdb, dodb, esdb, gdb, vdb, vcdb);

                db.Add(nuevaAplicacion);
                db.SaveChanges();

                // Mostrar mensaje de confirmación
                MessageBox.Show(text: "Dosis aplicada!", caption: "Aplicación de dosis", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Regresar al main del gestor
                frmMain ventana = new frmMain(gdb);
                ventana.Show();
                this.Hide();
            }
            // Si encontró un extranjero
            else if (gdb != null && validar && verificar1.Count > 0)
            {
                // Buscar el extranjero en la DB
                Extranjero exdb = db.Set<Extranjero>()
                    .Single(e => e.Pasaporte.Equals(txtDocumento.Text));

                // Crear dosis y añadirla a la DB
                AplicarVacuna nuevaAplicacion = new(
                    txtFecha.Text, txtHora.Text, dodb, esdb, exdb, gdb, vdb, vcdb);

                db.Add(nuevaAplicacion);
                db.SaveChanges();

                // Mostrar mensaje de confirmación
                MessageBox.Show(text: "Dosis aplicada!", caption: "Aplicación de dosis", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Regresar al main del gestor
                frmMain ventana = new frmMain(gdb);
                ventana.Show();
                this.Hide();
            }
            // Si encontró un menor de edad
            else if (gdb != null && validar && verificar2.Count > 0)
            {
                // Buscar el menor de edad en la DB
                Menor mdb = db.Set<Menor>()
                    .Single(m => m.DuiResponsable.Equals(txtDocumento.Text));

                // Crear dosis y añadirla a la DB
                AplicarVacuna nuevaAplicacion = new(
                    txtFecha.Text, txtHora.Text, dodb, esdb, gdb, mdb, vdb, vcdb);

                db.Add(nuevaAplicacion);
                db.SaveChanges();

                // Mostrar mensaje de confirmación
                MessageBox.Show(text: "Dosis aplicada!", caption: "Aplicación de dosis", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Regresar al main del gestor
                frmMain ventana = new frmMain(gdb);
                ventana.Show();
                this.Hide();
            }
            else
            {
                // Mostrar mensaje de error
                MessageBox.Show(text: "Datos incompletos!", caption: "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}