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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cerrar ventanas para evitar ventanas escondidas
            Application.Exit();
        }

        private void btnIngresarCiudadano_Click(object sender, EventArgs e)
        {
            // Validar  que el ciudadano completo los campos requeridos
            var validar = txtDUI.Text.Length > 0 && txtFechaCiudadano.Text.Length > 0;

            if (validar)
            {
                // Establecer conexion con la DB
                var db = new ProyectoFinalContext();

                // Obtener ciudadanos de la DB
                var listaCiudadanos = db.Ciudadanos
                    .OrderBy(c => c.Id)
                    .ToList();


                // Verificar si el DUI ingresado y la fecha de nacimiento le pertenecen a un ciudadano
                var verificar = listaCiudadanos.Where(
                    c => c.Dui.Equals(txtDUI.Text) && c.FechaDeNacimiento.Equals(txtFechaCiudadano.Text))
                    .ToList();

                // Verificar si el DUI le pertenece a un ciudadano pero la fecha de nacimiento es incorreta
                var verificar2 = listaCiudadanos.Where(
                   c => c.Dui.Equals(txtDUI.Text) && c.FechaDeNacimiento != txtFechaCiudadano.Text)
                   .ToList();


                // Dirigir a frmMain con los datos del ciudadano
                if (verificar.Count > 0)
                {
                    // Mostrar mensaje de confirmación
                    MessageBox.Show(text: "Bienvenido/a", caption: "Inicio", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    frmMain ventana = new frmMain(verificar[0]);
                    ventana.Show();
                    this.Hide();
                }
                else if (verificar2.Count > 0)
                {
                    // Mostrar mensaje de error
                    MessageBox.Show(text: "DUI y fecha de nacimiento ingresados no coinciden", caption: "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                // Dirigir a frmRegistroCivil para completar formulario
                else
                {
                    frmRegistroCivil ventana = new frmRegistroCivil(txtDUI.Text, 0);
                    ventana.Show();
                    this.Hide();
                }
            }
            else
            {
                // Mostrar mensaje de error
                MessageBox.Show(text: "Información incompleta", caption: "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnIngresarExtranjero_Click(object sender, EventArgs e)
        {
            // Validar que el extranjero completo los campos requeridos
            var validar = txtPasaporteExtranjero.Text.Length > 0 && txtFechaExtranjero.Text.Length > 0;

            if (validar)
            {
                // Establecer conexion con la DB
                var db = new ProyectoFinalContext();

                // Obtener extranjeros de la DB
                var listaExtranjeros = db.Extranjeros
                    .OrderBy(e => e.Id)
                    .ToList();


                // Verificar si el pasaporte y la fecha de nacimiento le pertenecen a un extranjero
                var verificar = listaExtranjeros.Where(
                    e => e.Pasaporte.Equals(txtPasaporteExtranjero.Text) && e.FechaDeNacimiento.Equals(txtFechaExtranjero.Text))
                    .ToList();

                // Verificar si el pasaporte le pertenece a un extranjero pero la fecha de nacimiento es incorrecta
                var verificar2 = listaExtranjeros.Where(
                    e => e.Pasaporte.Equals(txtPasaporteExtranjero.Text) && e.FechaDeNacimiento != txtFechaExtranjero.Text)
                    .ToList();


                // Dirigir a frmMain con los datos del extranjero
                if (verificar.Count > 0)
                {
                    // Mostrar mensaje de confirmación
                    MessageBox.Show(text: "Bienvenido/a", caption: "Inicio", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    frmMain ventana = new frmMain(verificar[0]);
                    ventana.Show();
                    this.Hide();
                }
                else if (verificar2.Count > 0)
                {
                    // Mostrar mensaje de error
                    MessageBox.Show(text: "Pasaporte y fecha de nacimiento ingresados no coinciden", caption: "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Dirigir a frmRegistroCivil
                else
                {
                    frmRegistroCivil ventana = new frmRegistroCivil(txtPasaporteExtranjero.Text, 1);
                    ventana.Show();
                    this.Hide();
                }
            }
            else
            {
                // Mostrar mensaje de error
                MessageBox.Show(text: "Información incompleta", caption: "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnIngresarMenor_Click(object sender, EventArgs e)
        {
            // Validar que el extranjero completo los campos requeridos
            var validar = txtDuiResponsable.Text.Length > 0 && txtFechaMenor.Text.Length > 0;

            if (validar)
            {
                // Establecer conexion con la DB
                var db = new ProyectoFinalContext();

                // Obtener menores de la DB
                var listaMenores = db.Menores
                    .OrderBy(m => m.Id)
                    .ToList();


                // Verificar si el DUI ingresado le pertenece a un menor de edad
                var verificar = listaMenores.Where(
                    m => m.DuiResponsable.Equals(txtDuiResponsable.Text) && m.FechaDeNacimiento.Equals(txtFechaMenor.Text))
                    .ToList();

                // Verificar si el DUI ingresado le pertenece a un menor de edad pero la fecha de nacimiento es incorrecta
                var verificar2 = listaMenores.Where(
                    m => m.DuiResponsable.Equals(txtDuiResponsable.Text) && m.FechaDeNacimiento != txtFechaMenor.Text)
                    .ToList();


                // Dirigir a frmMain con los datos del menor de edad
                if (verificar.Count > 0)
                {
                    // Mostrar mensaje de confirmación
                    MessageBox.Show(text: "Bienvenido/a", caption: "Inicio", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    frmMain ventana = new frmMain(verificar[0]);
                    ventana.Show();
                    this.Hide();
                }
                else if (verificar2.Count > 0)
                {
                    // Mostrar mensaje de error
                    MessageBox.Show(text: "DUI y fecha de nacimiento ingresados no coinciden", caption: "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                // Dirigir a frmRegistroCivil
                else
                {
                    frmRegistroCivil ventana = new frmRegistroCivil(txtDuiResponsable.Text, 2);
                    ventana.Show();
                    this.Hide();
                }
            }
            else
            {
                // Mostrar mensaje de error
                MessageBox.Show(text: "Información incompleta", caption: "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnIngresarGestor_Click(object sender, EventArgs e)
        {
            // Validar que el gestor completo los campos requeridos
            var validar = txtDUIGestor.Text.Length > 0 && txtFechaGestor.Text.Length > 0;

            if (validar)
            {
                // Establecer conexion con la DB
                var db = new ProyectoFinalContext();

                // Obtener gestores de la DB
                var listaGestores = db.Gestores
                    .OrderBy(g => g.Id)
                    .ToList();

                // Verificar si el DUI ingresado le pertenece a un gestor
                var verificar = listaGestores.Where(
                    g => g.Dui.Equals(txtDUIGestor.Text) && g.FechaDeNacimiento.Equals(txtFechaGestor.Text))
                    .ToList();

                // Dirigir a frmGestorLogin con los datos del gestor
                if (verificar.Count() > 0)
                {
                    frmGestorLogin ventana = new frmGestorLogin(verificar[0]);
                    ventana.Show();
                    this.Hide();
                }
                else
                {
                    // Mostrar mensaje de error
                    MessageBox.Show(text: "Datos ingresados no válidos", caption: "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                // Mostrar mensaje de error
                MessageBox.Show(text: "Información incompleta", caption: "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            tabUsuarios.ItemSize = new Size(0, 1);
        }

        private void btnCiudadano_Click(object sender, EventArgs e)
        {
            // Cargar la tabPage de ciudadano
            tabUsuarios.SelectedIndex = 0;
        }

        private void btnExtranjero_Click(object sender, EventArgs e)
        {
            // Cargar la tabPage de extranjero
            tabUsuarios.SelectedIndex = 1;
        }

        private void btnMenorEdad_Click(object sender, EventArgs e)
        {
            // Cargar la tabPage de menor de edad
            tabUsuarios.SelectedIndex = 2;
        }

        private void btnGestor_Click(object sender, EventArgs e)
        {
            // Cargar la tabPage de gestor
            tabUsuarios.SelectedIndex = 3;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}