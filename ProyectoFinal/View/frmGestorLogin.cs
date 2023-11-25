using Microsoft.EntityFrameworkCore;
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
    public partial class frmGestorLogin : Form
    {
        private Gestor gestor { get; set; }

        public frmGestorLogin(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        private void frmGestorLogin_Load(object sender, EventArgs e)
        {
            // Establecer conexion con la DB
            var db = new ProyectoFinalContext();

            // Mostrar el comboBox de cabinas al abrir el formulario
            cmbCabinas.DataSource = db.Cabinas.ToList();
            cmbCabinas.DisplayMember = "Nombre";
            cmbCabinas.ValueMember = "Id";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Gestor y Cabina de referencia
            Gestor gref = gestor;
            Cabina cref = (Cabina)cmbCabinas.SelectedItem;

            // Obtener gestor y cabina de la DB
            var db = new ProyectoFinalContext();

            Gestor gdb = db.Set<Gestor>()
                .SingleOrDefault(g => g.Id == gref.Id);

            Cabina cdb = db.Set<Cabina>()
                .SingleOrDefault(c => c.Id == cref.Id);

            // Validar usuario y contraseña
            if (gdb.Usuario == txtUsuario.Text && gdb.Contraseña == txtContraseña.Text)
            {
                // Instanciar objeto de la clase InicioSesion, y anexar el "cbdd" a la entidad InicioSesiones
                InicioSesion nuevoInicioSesion = new InicioSesion(DateTime.Now, cdb, gdb);
                db.Add(nuevoInicioSesion);
                db.SaveChanges();

                // Mostrar mensaje de confirmación
                MessageBox.Show(text: "Bienvenido!", caption: "Cabina", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Dirigir a Inicio para registrar ciudadanos
                frmMain ventana = new frmMain(gestor);
                ventana.Show();
                this.Hide();
            }
            else
            {
                // Mostrar mensaje de error
                MessageBox.Show(text: "Datos incorrectos", caption: "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void frmGestorLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cerrar ventanas para evitar ventanas escondidas
            Application.Exit();
        }
    }
}