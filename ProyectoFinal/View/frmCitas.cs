using ProyectoFinal.Context;
using ProyectoFinal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.View
{
    public partial class frmCitas : Form
    {
        public Ciudadano ciudadano { get; set; }

        public Extranjero extranjero { get; set; }

        public Menor menor { get; set; }

        public Gestor gestor { get; set; }

        public frmCitas(Ciudadano ciudadano)
        {
            InitializeComponent();
            this.ciudadano = ciudadano;
        }

        public frmCitas(Extranjero extranjero)
        {
            InitializeComponent();
            this.extranjero = extranjero;
        }

        public frmCitas(Menor menor)
        {
            InitializeComponent();
            this.menor = menor;
        }

        public frmCitas(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void frmCitas_Load(object sender, EventArgs e)
        {
            // Quitar la barrita de los tabPage
            tabAgendarCitaUsuarios.ItemSize = new Size(0, 1);

            // Establecer conexion con la DB
            var db = new ProyectoFinalContext();

            // Ubicar quien ingreso al sistema
            // Si encontro un gestor
            if (gestor != null)
            {
                // Mostrar comboBox de establecimiento al cargar el formulario
                cmbEstablecimientoGestor.DataSource = db.Establecimientos.ToList();
                cmbEstablecimientoGestor.DisplayMember = "Nombre";
                cmbEstablecimientoGestor.ValueMember = "Id";

                // Establecer el tab del gestor
                tabAgendarCitaUsuarios.SelectedIndex = 1;
            }
            // Si encontro un ciudadano, extranjero o responsable de menor de edad
            else if (ciudadano != null || extranjero != null || menor != null)
            {
                // Mostrar comboBox de establecimiento al cargar el formulario
                cmbEstablecimiento.DataSource = db.Establecimientos.ToList();
                cmbEstablecimiento.DisplayMember = "Nombre";
                cmbEstablecimiento.ValueMember = "Id";

                // Establecer el tab del usuario
                tabAgendarCitaUsuarios.SelectedIndex = 0;
            }
        }

        private void frmCitas_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cerrar ventanas para evitar ventanas escondidas
            Application.Exit();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            // Regresar a main con los datos del usuario actual
            if (ciudadano != null)
            {
                frmMain ventana = new frmMain(ciudadano);
                ventana.Show();
                this.Hide();
            }
            else if (extranjero != null)
            {
                frmMain ventana = new frmMain(extranjero);
                ventana.Show();
                this.Hide();
            }
            else if (menor != null)
            {
                frmMain ventana = new frmMain(menor);
                ventana.Show();
                this.Hide();
            }
        }

        private void btnRegresarGestor_Click(object sender, EventArgs e)
        {
            frmMain vetana = new frmMain(gestor);
            vetana.Show();
            this.Hide();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Definir establecimiento de referencia
            Establecimiento eref = (Establecimiento)cmbEstablecimiento.SelectedItem;

            // Establecer conexion con la DB
            var db = new ProyectoFinalContext();

            // Obtener establecimiento de la DB
            Establecimiento edb = db.Set<Establecimiento>()
                .SingleOrDefault(e => e.Id == eref.Id);


            // Validar que los datos del formulario están completos
            var validar = txtFecha.Text.Length > 0 && txtHora.Text.Length > 0;

            if (ciudadano != null && validar)
            {
                // Obtener ciudadano de la DB
                Ciudadano cdb = db.Set<Ciudadano>()
                    .Single(c => c.Id.Equals(ciudadano.Id));

                // Crear cita y añadirla a la DB
                Citum nuevaCita = new Citum(
                    txtFecha.Text, txtHora.Text, cdb, edb);

                db.Add(nuevaCita);
                db.SaveChanges();

                // Mostrar mensaje de confirmación
                MessageBox.Show(text: "Cita agendada!", caption: "Cita", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Regresar al main de usuarios
                frmMain ventana = new frmMain(cdb);
                ventana.Show();
                this.Hide();
            }
            else if (extranjero != null && validar)
            {
                // Obtener extranjero de la DB
                Extranjero exdb = db.Set<Extranjero>()
                    .Single(e => e.Id.Equals(extranjero.Id));

                // Crear cita y añadirla a la DB
                Citum nuevaCita = new Citum(
                    txtFecha.Text, txtHora.Text, edb, exdb);

                db.Add(nuevaCita);
                db.SaveChanges();

                // Mostrar mensaje de confirmación
                MessageBox.Show(text: "Cita agendada!", caption: "Cita", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Regresar al main de usuarios
                frmMain ventana = new frmMain(exdb);
                ventana.Show();
                this.Hide();
            }
            else if (menor != null && validar)
            {
                // Obtener menor de edad de la DB
                Menor mdb = db.Set<Menor>()
                    .Single(m => m.Id.Equals(menor.Id));

                // Crear cita y añadirla a la DB
                Citum nuevaCita = new Citum(
                    txtFecha.Text, txtHora.Text, edb, mdb);

                db.Add(nuevaCita);
                db.SaveChanges();

                // Mostrar mensaje de confirmación
                MessageBox.Show(text: "Cita agendada!", caption: "Cita", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Regresar al main de usuarios
                frmMain ventana = new frmMain(mdb);
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

        private void btnConfirmarGestor_Click(object sender, EventArgs e)
        {
            // Definir establecimiento de referencia
            Establecimiento eref = (Establecimiento)cmbEstablecimientoGestor.SelectedItem;

            // Establecer conexion con la DB
            var db = new ProyectoFinalContext();

            // Obtener establecimiento de la DB
            Establecimiento edb = db.Set<Establecimiento>()
                .SingleOrDefault(e => e.Id == eref.Id);

            // Obtener gestor de la DB
            Gestor gdb = db.Set<Gestor>()
                .Single(g => g.Id.Equals(gestor.Id));


            // Validar que los datos del formulario están completos
            var validar = txtDocumento.Text.Length > 0 && txtFechaGestor.Text.Length > 0 && txtHoraGestor.Text.Length > 0;


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
                // Buscar el ciudadano en la DB
                Ciudadano cdb = db.Set<Ciudadano>()
                    .Single(c => c.Dui.Equals(txtDocumento.Text));

                // Crear cita y añadirla a la DB
                Citum nuevaCita = new(
                    txtFechaGestor.Text, txtHoraGestor.Text, cdb, edb, gdb);

                db.Add(nuevaCita);
                db.SaveChanges();

                // Mostrar mensaje de confirmación
                MessageBox.Show(text: "Cita agendada!", caption: "Cita", MessageBoxButtons.OK,
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

                // Crear cita y añadirla a la DB
                Citum nuevaCita = new(
                    txtFechaGestor.Text, txtHoraGestor.Text, edb, exdb, gdb);

                db.Add(nuevaCita);
                db.SaveChanges();

                // Mostrar mensaje de confirmación
                MessageBox.Show(text: "Cita agendada!", caption: "Cita", MessageBoxButtons.OK,
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

                // Crear cita y añadirla a la DB
                Citum nuevaCita = new(
                    txtFechaGestor.Text, txtHoraGestor.Text, edb, gdb, mdb);

                db.Add(nuevaCita);
                db.SaveChanges();

                // Mostrar mensaje de confirmación
                MessageBox.Show(text: "Cita agendada!", caption: "Cita", MessageBoxButtons.OK,
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

        private void txtDocumento_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}