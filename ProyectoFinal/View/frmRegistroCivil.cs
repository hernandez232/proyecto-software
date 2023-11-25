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
    public partial class frmRegistroCivil : Form
    {
        public string documento { get; set; }

        public int index { get; set; }

        public frmRegistroCivil(string documento, int index)
        {
            InitializeComponent();
            this.documento = documento;
            this.index = index;
        }

        private void frmRegistroCivil_Load(object sender, EventArgs e)
        {
            // Quitar la barra de los tab en el formulario
            tabUsuarios.ItemSize = new Size(0, 1);

            // Establecer conexion con la DB
            var db = new ProyectoFinalContext();


            // UBICAR QUIEN INGRESO AL SISTEMA
            // Si ingreso un ciudadano
            if (index == 0)
            {
                // Cargar la tabPage de ciudadano
                tabUsuarios.SelectedIndex = 0;

                // ComboBox de Ciudadano
                cmbComorbilidad.DataSource = db.Comorbilidad.ToList();
                cmbComorbilidad.DisplayMember = "Comorbilidad1";
                cmbComorbilidad.ValueMember = "Id";

                cmbDiscapacidad.DataSource = db.Discapacidad.ToList();
                cmbDiscapacidad.DisplayMember = "Discapacidad1";
                cmbDiscapacidad.ValueMember = "Id";

                cmbGenero.DataSource = db.Generos.ToList();
                cmbGenero.DisplayMember = "Genero1";
                cmbGenero.ValueMember = "Id";

                cmbInstitucion.DataSource = db.InstitucionesEsenciales.ToList();
                cmbInstitucion.DisplayMember = "Nombre";
                cmbInstitucion.ValueMember = "Id";

                cmbEnfermedad.DataSource = db.EnfermedadesCronicas.ToList();
                cmbEnfermedad.DisplayMember = "Nombre";
                cmbEnfermedad.ValueMember = "Id";
            }
            // Si ingreso un extranjero
            else if (index == 1)
            {
                // Cargar la tabPage de extranjero
                tabUsuarios.SelectedIndex = 1;

                // ComboBox de Extranjero
                cmbComorbilidad1.DataSource = db.Comorbilidad.ToList();
                cmbComorbilidad1.DisplayMember = "Comorbilidad1";
                cmbComorbilidad1.ValueMember = "Id";

                cmbDiscapacidad1.DataSource = db.Discapacidad.ToList();
                cmbDiscapacidad1.DisplayMember = "Discapacidad1";
                cmbDiscapacidad1.ValueMember = "Id";

                cmbGenero1.DataSource = db.Generos.ToList();
                cmbGenero1.DisplayMember = "Genero1";
                cmbGenero1.ValueMember = "Id";

                cmbEnfermedad1.DataSource = db.EnfermedadesCronicas.ToList();
                cmbEnfermedad1.DisplayMember = "Nombre";
                cmbEnfermedad1.ValueMember = "Id";

                cmbNacionalidad1.DataSource = db.Nacionalidades.ToList();
                cmbNacionalidad1.DisplayMember = "Nacionalidad1";
                cmbNacionalidad1.ValueMember = "Id";
            }
            // Si ingreso un menor
            else if (index == 2)
            {
                // Cargar la tabPage de menor de edad
                tabUsuarios.SelectedIndex = 2;

                // ComboBox de Menor
                cmbComorbilidad2.DataSource = db.Comorbilidad.ToList();
                cmbComorbilidad2.DisplayMember = "Comorbilidad1";
                cmbComorbilidad2.ValueMember = "Id";

                cmbDiscapacidad2.DataSource = db.Discapacidad.ToList();
                cmbDiscapacidad2.DisplayMember = "Discapacidad1";
                cmbDiscapacidad2.ValueMember = "Id";

                cmbGenero2.DataSource = db.Generos.ToList();
                cmbGenero2.DisplayMember = "Genero1";
                cmbGenero2.ValueMember = "Id";

                cmbInstitucion2.DataSource = db.InstitucionesEsenciales.ToList();
                cmbInstitucion2.DisplayMember = "Nombre";
                cmbInstitucion2.ValueMember = "Id";

                cmbEnfermedad2.DataSource = db.EnfermedadesCronicas.ToList();
                cmbEnfermedad2.DisplayMember = "Nombre";
                cmbEnfermedad2.ValueMember = "Id";
            }
        }

        private void frmRegistroCivil_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cerrar ventanas para evitar ventanas escondidas
            Application.Exit();
        }

        private void btnContinuarCiudadano_Click(object sender, EventArgs e)
        {
            // Comorbilidad, Discapacidad, Genero, InstitucionEsencial y EnfermedadCronica de referencia
            Comorbilidad cref = (Comorbilidad)cmbComorbilidad.SelectedItem;
            Discapacidad dref = (Discapacidad)cmbDiscapacidad.SelectedItem;
            Genero gref = (Genero)cmbGenero.SelectedItem;
            InstitucionEsencial ieref = (InstitucionEsencial)cmbInstitucion.SelectedItem;
            EnfermedadCronica ecref = (EnfermedadCronica)cmbEnfermedad.SelectedItem;

            // Establecer conexion con la DB
            var db = new ProyectoFinalContext();

            // Obtener Comorbilidad, Discapacidad, Genero, InstitucionEsencial y EnfermedadCronica de la DB
            Comorbilidad cdb = db.Set<Comorbilidad>()
                .SingleOrDefault(c => c.Id == cref.Id);

            Discapacidad ddb = db.Set<Discapacidad>()
                .SingleOrDefault(d => d.Id == dref.Id);

            Genero gdb = db.Set<Genero>()
                .SingleOrDefault(g => g.Id == gref.Id);

            InstitucionEsencial iedb = db.Set<InstitucionEsencial>()
                .SingleOrDefault(ie => ie.Id == ieref.Id);

            EnfermedadCronica ecdb = db.Set<EnfermedadCronica>()
                .SingleOrDefault(ec => ec.Id == ecref.Id);


            // Validar que el ciudadano completo el formulario
            var validar = documento.Length > 0 && txtFechaCiudadano.Text.Length > 0 && txtNombresCiudadano.Text.Length > 0
                && txtApellidosCiudadano.Text.Length > 0 && txtTelefonoCiudadano.Text.Length > 0 &&
                txtCorreoCiudadano.Text.Length > 0 && txtDireccionCiudadano.Text.Length > 0 && cmbComorbilidad.Text.Length > 0
                && cmbDiscapacidad.Text.Length > 0 && cmbEnfermedad.Text.Length > 0 && cmbGenero.Text.Length > 0
                && cmbInstitucion.Text.Length > 0;


            if (validar)
            {
                // Crear Ciudadano y añadirlo a la DB
                Ciudadano nuevoCiudadano = new Ciudadano(
                    documento, txtFechaCiudadano.Text, txtNombresCiudadano.Text, txtApellidosCiudadano.Text,
                    txtTelefonoCiudadano.Text, txtCorreoCiudadano.Text, txtDireccionCiudadano.Text,
                    cdb, ddb, ecdb, gdb, iedb);

                db.Add(nuevoCiudadano);
                db.SaveChanges();

                // Mostrar mensaje de confirmación
                MessageBox.Show(text: "Registro completo", caption: "Registro", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Enviar datos de ciudadano a frmMain
                frmMain ventana = new frmMain(nuevoCiudadano);
                ventana.Show();
                this.Hide();
            }
            else
            {
                // Mostrar mensaje de error
                MessageBox.Show(text: "Registro incompleto", caption: "Registro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnContinuarExtranjero_Click(object sender, EventArgs e)
        {
            // Comorbilidad, Discapacidad, Genero, EnfermedadCronica de referencia y Nacionalidad
            Comorbilidad cref = (Comorbilidad)cmbComorbilidad1.SelectedItem;
            Discapacidad dref = (Discapacidad)cmbDiscapacidad1.SelectedItem;
            Genero gref = (Genero)cmbGenero1.SelectedItem;
            EnfermedadCronica ecref = (EnfermedadCronica)cmbEnfermedad1.SelectedItem;
            Nacionalidad nref = (Nacionalidad)cmbNacionalidad1.SelectedItem;

            // Establecer conexion con la DB
            var db = new ProyectoFinalContext();

            // Obtener Comorbilidad, Discapacidad, Genero, EnfermedadCronica de referencia y Nacionalidad de la DB
            Comorbilidad cdb = db.Set<Comorbilidad>()
                .SingleOrDefault(c => c.Id == cref.Id);

            Discapacidad ddb = db.Set<Discapacidad>()
                .SingleOrDefault(d => d.Id == dref.Id);

            Genero gdb = db.Set<Genero>()
                .SingleOrDefault(g => g.Id == gref.Id);

            EnfermedadCronica ecdb = db.Set<EnfermedadCronica>()
                .SingleOrDefault(ec => ec.Id == ecref.Id);

            Nacionalidad ndb = db.Set<Nacionalidad>()
                .SingleOrDefault(n => n.Id == nref.Id);


            // Validar que el extranjero completo el formulario
            var validar = documento.Length > 0 && txtFechaExtranjero.Text.Length > 0 && txtNombresExtranjero.Text.Length > 0
                && txtApellidosExtranjero.Text.Length > 0 && txtTelefonoExtranjero.Text.Length > 0 &&
                txtCorreoExtranjero.Text.Length > 0 && txtDireccionExtranjero.Text.Length > 0 && cmbComorbilidad1.Text.Length > 0
                && cmbDiscapacidad1.Text.Length > 0 && cmbNacionalidad1.Text.Length > 0;

            if (validar)
            {
                // Crear extranjero y añadirlo a la DB
                Extranjero nuevoExtranjero = new Extranjero(
                    documento, txtFechaExtranjero.Text, txtNombresExtranjero.Text, txtApellidosExtranjero.Text,
                    txtTelefonoExtranjero.Text, txtCorreoExtranjero.Text, txtDireccionExtranjero.Text, cdb,
                    ddb, ecdb, gdb, ndb);

                db.Add(nuevoExtranjero);
                db.SaveChanges();

                // Mostrar mensaje de confirmación
                MessageBox.Show(text: "Registro completo!", caption: "Registro", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Enviar datos de ciudadano a frmMain
                frmMain ventana = new frmMain(nuevoExtranjero);
                ventana.Show();
                this.Hide();
            }
            else
            {
                // Mostrar mensaje de error
                MessageBox.Show(text: "Registro incompleto!", caption: "Registro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnContinuarMenor_Click(object sender, EventArgs e)
        {
            // Comorbilidad, Discapacidad, Genero, InstitucionEsencial y EnfermedadCronica de referencia
            Comorbilidad cref = (Comorbilidad)cmbComorbilidad2.SelectedItem;
            Discapacidad dref = (Discapacidad)cmbDiscapacidad2.SelectedItem;
            Genero gref = (Genero)cmbGenero2.SelectedItem;
            InstitucionEsencial ieref = (InstitucionEsencial)cmbInstitucion2.SelectedItem;
            EnfermedadCronica ecref = (EnfermedadCronica)cmbEnfermedad2.SelectedItem;

            // Establecer conexion con la DB
            var db = new ProyectoFinalContext();

            // Obtener Comorbilidad, Discapacidad, Genero, InstitucionEsencial y EnfermedadCronica de la DB
            Comorbilidad cdb = db.Set<Comorbilidad>()
                .SingleOrDefault(c => c.Id == cref.Id);

            Discapacidad ddb = db.Set<Discapacidad>()
                .SingleOrDefault(d => d.Id == dref.Id);

            Genero gdb = db.Set<Genero>()
                .SingleOrDefault(g => g.Id == gref.Id);

            InstitucionEsencial iedb = db.Set<InstitucionEsencial>()
                .SingleOrDefault(ie => ie.Id == ieref.Id);

            EnfermedadCronica ecdb = db.Set<EnfermedadCronica>()
                .SingleOrDefault(ec => ec.Id == ecref.Id);


            // Validar que el menor completo el formulario
            var validar = documento.Length > 0 && txtFechaMenor.Text.Length > 0 && txtNombresMenor.Text.Length > 0 &&
                txtApellidosMenor.Text.Length > 0 && txtTelefonoResponsable.Text.Length > 0 &&
                txtCorreoResponsable.Text.Length > 0 && txtDireccionResponsable.Text.Length > 0 &&
                txtDireccionResponsable.Text.Length > 0 && cmbComorbilidad2.Text.Length > 0 && cmbDiscapacidad2.Text.Length > 0
                && cmbGenero2.Text.Length > 0 && cmbInstitucion2.Text.Length > 0 && cmbEnfermedad2.Text.Length > 0;


            if (validar)
            {
                // Crear menor y añadirlo a la DB
                Menor nuevoMenor = new Menor(
                    documento, txtFechaMenor.Text, txtNombresMenor.Text, txtApellidosMenor.Text, txtTelefonoResponsable.Text,
                    txtCorreoResponsable.Text, txtDireccionResponsable.Text, cdb, ddb, ecdb,
                    gdb, iedb);

                db.Add(nuevoMenor);
                db.SaveChanges();

                // Mostrar mensaje de confirmación
                MessageBox.Show(text: "Registro completo!", caption: "Registro", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Enviar datos de ciudadano a frmMain
                frmMain ventana = new frmMain(nuevoMenor);
                ventana.Show();
                this.Hide();
            }
            else
            {
                // Mostrar mensaje de error
                MessageBox.Show(text: "Registro incompleto!", caption: "Registro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresarCiudadano_Click(object sender, EventArgs e)
        {
            // Regresar al inicio sin los datos del usuario actual
            frmInicio ventana = new frmInicio();
            ventana.Show();
            this.Hide();
        }

        private void btnRegresarExtranjero_Click(object sender, EventArgs e)
        {
            // Regresar al inicio sin los datos del usuario actual
            frmInicio ventana = new frmInicio();
            ventana.Show();
            this.Hide();
        }

        private void btnRegresarMenor_Click(object sender, EventArgs e)
        {
            // Regresar al inicio sin los datos del usuario actual
            frmInicio ventana = new frmInicio();
            ventana.Show();
            this.Hide();
        }
    }
}