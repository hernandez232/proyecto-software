using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using Microsoft.Identity.Client;
using ProyectoFinal.Class;
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
    public partial class frmMain : Form
    {
        public Ciudadano ciudadano { get; set; }

        public Gestor gestor { get; set; }

        public Extranjero extranjero { get; set; }

        public Menor menor { get; set; }


        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(Ciudadano ciudadano)
        {
            InitializeComponent();
            this.ciudadano = ciudadano;
        }

        public frmMain(Gestor gestor)
        {
            InitializeComponent();
            this.gestor = gestor;
        }

        public frmMain(Extranjero extranjero)
        {
            InitializeComponent();
            this.extranjero = extranjero;
        }

        public frmMain(Menor menor)
        {
            InitializeComponent();
            this.menor = menor;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Quitar la barrita de los tabPage
            tabHomeUsuarios.ItemSize = new Size(0, 1);

            // Ubicar quien ingreso al sistema
            // Si encontró un gestor
            if (gestor != null)
            {
                tsPrincipalGestor.Text = "Bienvenido: " + gestor.Nombres.ToString() + " " + gestor.Apellidos.ToString();
                tsPrincipalGestor2.Text = "Bienvenido: " + gestor.Nombres.ToString() + " " + gestor.Apellidos.ToString();
                tabHomeUsuarios.SelectedIndex = 2;
                actualizarCitasGestor();
                actualizarDosisGestor();
            }
            // Si encontró un ciudadano
            else if (ciudadano != null)
            {
                tsPrincipal.Text = "Bienvenido: " + ciudadano.Nombres.ToString() + " " + ciudadano.Apellidos.ToString();
                tsPrincipal2.Text = "Bienvenido: " + ciudadano.Nombres.ToString() + " " + ciudadano.Apellidos.ToString();
                tabHomeUsuarios.SelectedIndex = 0;
                actualizarCitasCiudadano();
                actualizarDosisCiudadano();
            }
            // Si encontró un extranjero
            else if (extranjero != null)
            {
                tsPrincipal.Text = "Bienvenido " + extranjero.Nombres.ToString() + " " + extranjero.Apellidos.ToString();
                tsPrincipal2.Text = "Bienvenido " + extranjero.Nombres.ToString() + " " + extranjero.Apellidos.ToString();
                tabHomeUsuarios.SelectedIndex = 0;
                actualizarCitasExtranjero();
                actualizarDosisExtranjero();
            }
            // Si encontró un menor de edad
            else if (menor != null)
            {
                tsPrincipal.Text = "Bienvenido " + menor.Nombres.ToString() + " " + menor.Apellidos.ToString();
                tsPrincipal2.Text = "Bienvenido " + menor.Nombres.ToString() + " " + menor.Apellidos.ToString();
                tabHomeUsuarios.SelectedIndex = 0;
                actualizarCitasMenor();
                actualizarDosisMenor();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        // tabPage Usuarios
        private void btnCrearCita_Click(object sender, EventArgs e)
        {
            agendarCita();
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            tabHomeUsuarios.SelectedIndex = 1;
        }


        // tabPage Gestor
        private void btnCrearCitaGestor_Click(object sender, EventArgs e)
        {
            agendarCita();
        }

        private void btnAplicarDosis_Click(object sender, EventArgs e)
        {
            aplicarDosisGestor();
        }

        private void btnInformacionGestor_Click(object sender, EventArgs e)
        {
            tabHomeUsuarios.SelectedIndex = 3;
        }


        // Botones de toolStrip Usuarios
        private void tsPrincipal_Click(object sender, EventArgs e)
        {
            tabHomeUsuarios.SelectedIndex = 0;
        }

        private void tsAgendarCita_Click(object sender, EventArgs e)
        {
            agendarCita();
        }

        private void tsInformacion_Click(object sender, EventArgs e)
        {
            tabHomeUsuarios.SelectedIndex = 1;
        }

        private void tsSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Botones de toolStrip2 Gestor
        private void tsPrincipalGestor_Click(object sender, EventArgs e)
        {
            tabHomeUsuarios.SelectedIndex = 2;
        }

        private void tsAgendarCitaGestor_Click(object sender, EventArgs e)
        {
            agendarCita();
        }

        private void tsInformacionGestor_Click(object sender, EventArgs e)
        {
            tabHomeUsuarios.SelectedIndex = 3;
        }

        private void tsAplicarDosisGestor_Click(object sender, EventArgs e)
        {
            aplicarDosisGestor();
        }

        private void tsSalirGestor_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Botones de toolStrip3 Usuarios
        private void tsPrincipal2_Click(object sender, EventArgs e)
        {
            tabHomeUsuarios.SelectedIndex = 0;
        }

        private void tsAgendarCita2_Click(object sender, EventArgs e)
        {
            agendarCita();
        }

        private void tsInformacion2_Click(object sender, EventArgs e)
        {
            tabHomeUsuarios.SelectedIndex = 1;
        }

        private void tsSalir2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Botones de toolStrip4 Gestor
        private void tsPrincipalGestor2_Click(object sender, EventArgs e)
        {
            tabHomeUsuarios.SelectedIndex = 2;
        }

        private void tsAgendarCitaGestor2_Click(object sender, EventArgs e)
        {
            agendarCita();
        }

        private void tsInformacionGestor2_Click(object sender, EventArgs e)
        {
            tabHomeUsuarios.SelectedIndex = 3;
        }

        private void tsAplicarDosisGestor2_Click(object sender, EventArgs e)
        {
            aplicarDosisGestor();
        }

        private void tsSalirGestor2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // FUNCIÓN PARA AGENDAR CITAS
        public void agendarCita()
        {
            // Establecer conexion con la DB
            var db = new ProyectoFinalContext();

            // Si encontro un gestor
            if (gestor != null)
            {
                // Obtener gestor de la DB
                Gestor gdb = db.Set<Gestor>()
                    .SingleOrDefault(g => g.Id.Equals(gestor.Id));

                // Enviar datos del gestor
                frmCitas vetana = new frmCitas(gdb);
                vetana.Show();
                this.Hide();
            }
            // Si encontro un ciudadano
            else if (ciudadano != null)
            {
                // Obtener el iudadano de la DB
                Ciudadano cdb = db.Set<Ciudadano>()
                    .SingleOrDefault(c => c.Id.Equals(ciudadano.Id));

                // Enviar datos del ciudadano
                frmCitas ventana = new frmCitas(cdb);
                ventana.Show();
                this.Hide();
            }
            else if (extranjero != null)
            {
                // Obtener el extranjero de la DB
                Extranjero edb = db.Set<Extranjero>()
                .SingleOrDefault(e => e.Id.Equals(extranjero.Id));

                // Enviar datos del extranjero
                frmCitas ventana = new frmCitas(edb);
                ventana.Show();
                this.Hide();
            }
            else if (menor != null)
            {
                // Obtener el menor de edad de la DB
                Menor mdb = db.Set<Menor>()
                .SingleOrDefault(m => m.Id.Equals(menor.Id));

                // Enviar datos del menor de edad
                frmCitas ventana = new frmCitas(mdb);
                ventana.Show();
                this.Hide();
            }
            else
            {
                // Mostrar mensaje de error
                MessageBox.Show(text: "Usuario no válido", caption: "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // FUNCIÓN PARA APLICAR DOSIS POR PARTE DEL GESTOR
        public void aplicarDosisGestor()
        {
            // Establecer conexion con la DB
            var db = new ProyectoFinalContext();

            // Obtener gestor de la DB
            Gestor gdb = db.Set<Gestor>()
                .Single(g => g.Id.Equals(gestor.Id));

            // Si encontro un gestor
            if (gdb != null)
            {
                // Enviar datos del gestor
                frmDosis vetana = new frmDosis(gdb);
                vetana.Show();
                this.Hide();
            }
            else
            {
                // Mostrar mensaje de error
                MessageBox.Show(text: "Datos ingresados incorrectos", caption: "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // FUNCIÓN PARA ACTUALIZAR CITAS DE CIUDADANO
        private void actualizarCitasCiudadano()
        {
            // Establecer conexion con la DB
            var db = new ProyectoFinalContext();

            // Obtener todas las citas de la DB
            var listaCitasCiudadanos = db.Citas
                .Include(i => i.IdCiudadanoNavigation)
                .Include(i => i.IdGestorNavigation)
                .Include(i => i.IdEstablecimientoNavigation)
                .OrderBy(i => i.Id)
                .ToList();

            // Obtener todas las citas del ciudadano activo
            var resultadoCitasCiudadano = listaCitasCiudadanos
                .Where(i => i.IdCiudadano.Equals(ciudadano.Id))
                .ToList();

            // Mostrar las citas del ciudadano activo en el Data Gried View
            List<Citas> listaCitas = new List<Citas>();
            foreach (Citum cita in resultadoCitasCiudadano)
            {
                // Buscar el establecimiento de cada cita
                Establecimiento establecimientoDB = db.Set<Establecimiento>()
                    .Single(e => e.Id == cita.IdEstablecimiento);

                // Crear cita y agregar a la lista de citas del ciudadano
                Citas nuevaCita = new Citas(
                    cita.Fecha, cita.Hora, establecimientoDB.Nombre);

                listaCitas.Add(nuevaCita);
            }

            dgvCitas.DataSource = null;
            dgvCitas.DataSource = listaCitas;
        }

        // FUNCIÓN PARA ACTUALIZAR DOSIS DE CIUDADANO
        public void actualizarDosisCiudadano()
        {
            // Establecer conexion con la DB
            var db = new ProyectoFinalContext();

            // Obtener todas las dosis aplicadas de la DB
            var listaDosisCiudadanos = db.AplicarVacunas
                .Include(i => i.IdVacunaNavigation)
                .Include(i => i.IdDosisNavigation)
                .Include(i => i.IdEfectoSecundarioNavigation)
                .Include(i => i.IdVacunadorNavigation)
                .Include(i => i.IdCiudadanoNavigation)
                .OrderBy(i => i.Id)
                .ToList();

            // Obtener todas las dosis aplicadas del ciudadano activo
            var listaDosisCiudadano = listaDosisCiudadanos
                .Where(i => i.IdCiudadano.Equals(ciudadano.Id))
                .ToList();

            // Mostrar las dosis del ciudadano activo en el Data Gried View
            List<AplicarDosis> listaDosis = new List<AplicarDosis>();
            foreach (AplicarVacuna dosis in listaDosisCiudadano)
            {
                // Buscar la vacuna
                Vacuna vacunaDB = db.Set<Vacuna>()
                    .Single(v => v.Id == dosis.IdVacuna);

                // Buscar la dosis aplicada
                Dosi dosisDB = db.Set<Dosi>()
                    .Single(d => d.Id == dosis.IdDosis);

                // Buscar el efecto secundario de cada dosis
                EfectoSecundario efectoDB = db.Set<EfectoSecundario>()
                    .Single(e => e.Id == dosis.IdEfectoSecundario);

                // Buscar el vacunador
                Vacunador vacunadorDB = db.Set<Vacunador>()
                    .Single(v => v.Id == dosis.IdVacunador);

                // Buscar el gestor
                Gestor gestorDB = db.Set<Gestor>()
                    .Single(g => g.Id == dosis.IdGestor);

                AplicarDosis nuevaDosis = new AplicarDosis(
                    vacunaDB.Nombre, dosisDB.Nombre, efectoDB.Nombre, vacunadorDB.Nombres, vacunadorDB.Apellidos,
                    gestorDB.Nombres, gestorDB.Apellidos);

                listaDosis.Add(nuevaDosis);
            }

            dgvDosis.DataSource = null;
            dgvDosis.DataSource = listaDosis;
        }

        // FUNCIÓN PARA ACTUALIZAR CITAS DE EXTRANJERO
        public void actualizarCitasExtranjero()
        {
            // Establecer conexion con la DB
            var db = new ProyectoFinalContext();

            // Obtener todas las citas de la DB
            var listaCitasExtranjeros = db.Citas
                .Include(i => i.IdExtranjeroNavigation)
                .Include(i => i.IdGestorNavigation)
                .Include(i => i.IdEstablecimientoNavigation)
                .OrderBy(i => i.Id)
                .ToList();

            // Obtener todas las citas del extranjero activo
            var resultadoCitasExtranjero = listaCitasExtranjeros
                .Where(i => i.IdExtranjero.Equals(extranjero.Id))
                .ToList();

            // Mostrar las citas del extranjero activo en el Data Gried View
            List<Citas> listaCitas = new List<Citas>();
            foreach (Citum cita in resultadoCitasExtranjero)
            {
                // Buscar el establecimiento de cada cita
                Establecimiento establecimientoDB = db.Set<Establecimiento>()
                    .Single(e => e.Id == cita.IdEstablecimiento);

                // Crear cita y agregar a la lista de citas del extranjero
                Citas nuevaCita = new Citas(
                    cita.Fecha, cita.Hora, establecimientoDB.Nombre);

                listaCitas.Add(nuevaCita);
            }

            dgvCitas.DataSource = null;
            dgvCitas.DataSource = listaCitas;
        }

        // FUNCIÓN PARA ACTUALIZAR DOSIS DE EXTRANJERO
        public void actualizarDosisExtranjero()
        {
            // Establecer conexion con la DB
            var db = new ProyectoFinalContext();

            // Obtener todas las dosis aplicadas de la DB
            var listaDosisExtranjeros = db.AplicarVacunas
                .Include(i => i.IdVacunaNavigation)
                .Include(i => i.IdDosisNavigation)
                .Include(i => i.IdEfectoSecundarioNavigation)
                .Include(i => i.IdVacunadorNavigation)
                .Include(i => i.IdExtranjeroNavigation)
                .OrderBy(i => i.Id)
                .ToList();

            // Obtener todas las dosis aplicadas del extranjero activo
            var listaDosisExtranjero = listaDosisExtranjeros
                .Where(i => i.IdExtranjero.Equals(extranjero.Id))
                .ToList();

            // Mostrar las dosis del extranjero activo en el Data Gried View
            List<AplicarDosis> listaDosis = new List<AplicarDosis>();
            foreach (AplicarVacuna dosis in listaDosisExtranjero)
            {
                // Buscar la vacuna
                Vacuna vacunaDB = db.Set<Vacuna>()
                    .Single(v => v.Id == dosis.IdVacuna);

                // Buscar la dosis aplicada
                Dosi dosisDB = db.Set<Dosi>()
                    .Single(d => d.Id == dosis.IdDosis);

                // Buscar el efecto secundario de cada dosis
                EfectoSecundario efectoDB = db.Set<EfectoSecundario>()
                    .Single(e => e.Id == dosis.IdEfectoSecundario);

                // Buscar el vacunador
                Vacunador vacunadorDB = db.Set<Vacunador>()
                    .Single(v => v.Id == dosis.IdVacunador);

                // Buscar el gestor
                Gestor gestorDB = db.Set<Gestor>()
                    .Single(g => g.Id == dosis.IdGestor);

                AplicarDosis nuevaDosis = new AplicarDosis(
                    vacunaDB.Nombre, dosisDB.Nombre, efectoDB.Nombre, vacunadorDB.Nombres, vacunadorDB.Apellidos,
                    gestorDB.Nombres, gestorDB.Apellidos);

                listaDosis.Add(nuevaDosis);
            }

            dgvDosis.DataSource = null;
            dgvDosis.DataSource = listaDosis;
        }

        // FUNCIÓN PARA ACTUALIZAR CITAS DE MENOR DE EDAD
        public void actualizarCitasMenor()
        {
            // Establecer conexion con la DB
            var db = new ProyectoFinalContext();

            // Obtener todas las citas de la DB
            var listaCitasMenores = db.Citas
                .Include(i => i.IdMenorNavigation)
                .Include(i => i.IdGestorNavigation)
                .Include(i => i.IdEstablecimientoNavigation)
                .OrderBy(i => i.Id)
                .ToList();

            // Obtener todas las citas del menor de edad activo
            var resultadoCitasMenores = listaCitasMenores
                .Where(i => i.IdMenor.Equals(menor.Id))
                .ToList();

            // Mostrar las citas del menor de edad activo en el Data Gried View
            List<Citas> listaCitas = new List<Citas>();
            foreach (Citum cita in resultadoCitasMenores)
            {
                // Buscar el establecimiento de cada cita
                Establecimiento establecimientoDB = db.Set<Establecimiento>()
                    .Single(e => e.Id == cita.IdEstablecimiento);

                // Crear cita y agregar a la lista de citas del extranjero
                Citas nuevaCita = new Citas(
                    cita.Fecha, cita.Hora, establecimientoDB.Nombre);

                listaCitas.Add(nuevaCita);
            }

            dgvCitas.DataSource = null;
            dgvCitas.DataSource = listaCitas;
        }

        // FUNCIÓN PARA ACTUALIZAR DOSIS DE MENOR DE EDAD
        public void actualizarDosisMenor()
        {
            // Establecer conexion con la DB
            var db = new ProyectoFinalContext();

            // Obtener todas las dosis aplicadas de la DB
            var listaDosisExtranjeros = db.AplicarVacunas
                .Include(i => i.IdVacunaNavigation)
                .Include(i => i.IdDosisNavigation)
                .Include(i => i.IdEfectoSecundarioNavigation)
                .Include(i => i.IdVacunadorNavigation)
                .Include(i => i.IdMenorNavigation)
                .OrderBy(i => i.Id)
                .ToList();

            // Obtener todas las dosis aplicadas del menor de edad activo
            var listaDosisExtranjero = listaDosisExtranjeros
                .Where(i => i.IdMenor.Equals(menor.Id))
                .ToList();

            // Mostrar las dosis del menor de edad activo en el Data Gried View
            List<AplicarDosis> listaDosis = new List<AplicarDosis>();
            foreach (AplicarVacuna dosis in listaDosisExtranjero)
            {
                // Buscar la vacuna
                Vacuna vacunaDB = db.Set<Vacuna>()
                    .Single(v => v.Id == dosis.IdVacuna);

                // Buscar la dosis aplicada
                Dosi dosisDB = db.Set<Dosi>()
                    .Single(d => d.Id == dosis.IdDosis);

                // Buscar el efecto secundario de cada dosis
                EfectoSecundario efectoDB = db.Set<EfectoSecundario>()
                    .Single(e => e.Id == dosis.IdEfectoSecundario);

                // Buscar el vacunador
                Vacunador vacunadorDB = db.Set<Vacunador>()
                    .Single(v => v.Id == dosis.IdVacunador);

                // Buscar el gestor
                Gestor gestorDB = db.Set<Gestor>()
                    .Single(g => g.Id == dosis.IdGestor);

                AplicarDosis nuevaDosis = new AplicarDosis(
                    vacunaDB.Nombre, dosisDB.Nombre, efectoDB.Nombre, vacunadorDB.Nombres, vacunadorDB.Apellidos,
                    gestorDB.Nombres, gestorDB.Apellidos);

                listaDosis.Add(nuevaDosis);
            }

            dgvDosis.DataSource = null;
            dgvDosis.DataSource = listaDosis;
        }

        // FUNCIÓN PARA ACTUALIZAR CITAS DE CIUDADANOS REALIZADAS POR GESTOR
        public void actualizarCitasGestor()
        {
            // Establecer conexion con la DB
            var db = new ProyectoFinalContext();

            // Obtener todas las citas de la DB
            var listaCitasGestores = db.Citas
                .Include(i => i.IdCiudadanoNavigation)
                .Include(i => i.IdGestorNavigation)
                .Include(i => i.IdEstablecimientoNavigation)
                .OrderBy(i => i.Id)
                .ToList();

            // Obtener todas las citas de ciudadanos programadas por el gestor activo
            var resultadoCitasCiudadanoGestor = listaCitasGestores
                .Where(c => c.IdGestor.Equals(gestor.Id) && c.IdCiudadano != null)
                .ToList();

            // Lista que contiene todas las citas del gestor activo
            List<CitasGestor> listaCitas = new List<CitasGestor>();

            // Guardar en la lista las citas de ciudadanos agendadas por el gestor activo
            foreach (Citum cita in resultadoCitasCiudadanoGestor)
            {
                // Buscar el ciudadano
                Ciudadano ciudadanoDB = db.Set<Ciudadano>()
                    .Single(c => c.Id == cita.IdCiudadano);

                // Buscar el establecimiento de cada cita
                Establecimiento establecimientoDB = db.Set<Establecimiento>()
                    .Single(e => e.Id == cita.IdEstablecimiento);

                CitasGestor nuevaCitaGestor = new CitasGestor(
                    ciudadanoDB.Dui, ciudadanoDB.Nombres, ciudadanoDB.Apellidos, cita.Fecha, cita.Hora, establecimientoDB.Nombre);

                listaCitas.Add(nuevaCitaGestor);
            }


            // Obtener todas las citas de extranjeros programadas por el gestor activo
            var resultadoCitasExtranjeroGestor = listaCitasGestores
                .Where(c => c.IdGestor.Equals(gestor.Id) && c.IdExtranjero != null)
                .ToList();

            // Guardar en la lista las citas de extranjeros agendadas por el gestor activo
            foreach (Citum cita in resultadoCitasExtranjeroGestor)
            {
                // Buscar el extranjero de cada cita
                Extranjero extranjeroDB = db.Set<Extranjero>()
                    .Single(e => e.Id == cita.IdExtranjero);

                // Buscar el establecimiento de cada cita
                Establecimiento establecimientoDB = db.Set<Establecimiento>()
                    .Single(e => e.Id == cita.IdEstablecimiento);

                CitasGestor nuevaCitaGestor = new CitasGestor(
                    extranjeroDB.Pasaporte, extranjeroDB.Nombres, extranjeroDB.Apellidos, cita.Fecha, cita.Hora,
                    establecimientoDB.Nombre);

                listaCitas.Add(nuevaCitaGestor);
            }


            // Obtener todas las citas de menores de edad programadas por el gestor activo
            var resultadoCitasMenorGestor = listaCitasGestores
                .Where(c => c.IdGestor.Equals(gestor.Id) && c.IdMenor != null)
                .ToList();

            // Guardar en la lista las citas de menores de edad agendadas por el gestor activo
            foreach (Citum cita in resultadoCitasMenorGestor)
            {
                // Buscar el menor de edad de cada cita
                Menor menorDB = db.Set<Menor>()
                    .Single(e => e.Id == cita.IdMenor);

                // Buscar el establecimiento de cada cita
                Establecimiento establecimientoDB = db.Set<Establecimiento>()
                    .Single(e => e.Id == cita.IdEstablecimiento);

                CitasGestor nuevaCitaGestor = new CitasGestor(
                    menorDB.DuiResponsable, menorDB.Nombres, menorDB.Apellidos, cita.Fecha, cita.Hora, establecimientoDB.Nombre);

                listaCitas.Add(nuevaCitaGestor);
            }

            // Mostrar las citas del gestor activo en el Data Gried View
            dgvCitasGestor.DataSource = null;
            dgvCitasGestor.DataSource = listaCitas;
        }


        // FUNCIÓN PARA ACTUALIZAR CITAS DE CIUDADANOS REALIZADAS POR GESTOR
        public void actualizarDosisGestor()
        {
            // Establecer conexion con la DB
            var db = new ProyectoFinalContext();

            // Obtener todas las aplicaciones de vacunas registradas en la DB
            var listaDosisGestores = db.AplicarVacunas
                .Include(i => i.IdCiudadanoNavigation)
                .Include(i => i.IdGestorNavigation)
                .Include(i => i.IdExtranjeroNavigation)
                .Include(i => i.IdMenorNavigation)
                .Include(i => i.IdDosisNavigation)
                .Include(i => i.IdVacunaNavigation)
                .OrderBy(i => i.Id)
                .ToList();

            // Obtener todas las aplicaciones de vacunas de ciudadanos registradas por el gestor activo
            var resultadoDosisCiudadanoGestor = listaDosisGestores
                .Where(c => c.IdGestor.Equals(gestor.Id) && c.IdCiudadano != null)
                .ToList();

            // Lista que contiene todas las vacunas registradas del gestor activo
            List<DosisGestor> listaDosis = new List<DosisGestor>();

            // Guardar en la lista las vacunas aplicadas a ciudadanos por el gestor activo
            foreach (AplicarVacuna dosis in resultadoDosisCiudadanoGestor)
            {
                // Buscar el ciudadano de cada vacuna aplicada
                Ciudadano ciudadanoDB = db.Set<Ciudadano>()
                    .Single(c => c.Id == dosis.IdCiudadano);

                // Buscar la dosis de cada aplicación de vacuna
                Dosi dosisDB = db.Set<Dosi>()
                    .Single(d => d.Id == dosis.IdDosis);

                // Buscar la vacuna de cada aplicación
                Vacuna vacunaDB = db.Set<Vacuna>()
                    .Single(v => v.Id == dosis.IdVacuna);

                DosisGestor nuevaDosisGestor = new DosisGestor(
                    ciudadanoDB.Dui, ciudadanoDB.Nombres, ciudadanoDB.Apellidos, dosis.Fecha, dosis.Hora,
                    dosisDB.Nombre, vacunaDB.Nombre);

                listaDosis.Add(nuevaDosisGestor);
            }


            // Obtener todas las aplicaciones de vacunas de extranjeros registradas por el gestor activo
            var resultadoDosisExtranjeroGestor = listaDosisGestores
                .Where(c => c.IdGestor.Equals(gestor.Id) && c.IdExtranjero != null)
                .ToList();

            // Guardar en la lista las vacunas aplicadas a extranjeros por el gestor activo
            foreach (AplicarVacuna dosis in resultadoDosisExtranjeroGestor)
            {
                // Buscar el extranjero de vacuna aplicada
                Extranjero extranjeroDB = db.Set<Extranjero>()
                    .Single(e => e.Id == dosis.IdExtranjero);

                // Buscar la dosis de cada aplicación de vacuna
                Dosi dosisDB = db.Set<Dosi>()
                    .Single(d => d.Id == dosis.IdDosis);

                // Buscar la vacuna de cada aplicación
                Vacuna vacunaDB = db.Set<Vacuna>()
                    .Single(v => v.Id == dosis.IdVacuna);

                DosisGestor nuevaDosisGestor = new DosisGestor(
                   extranjeroDB.Pasaporte, extranjeroDB.Nombres, extranjeroDB.Apellidos, dosis.Fecha, dosis.Hora,
                   dosisDB.Nombre, vacunaDB.Nombre);

                listaDosis.Add(nuevaDosisGestor);
            }


            // Obtener todas las aplicaciones de vacunas de menores de edad registradas por el gestor activo
            var resultadoDosisMenorGestor = listaDosisGestores
                .Where(c => c.IdGestor.Equals(gestor.Id) && c.IdMenor != null)
                .ToList();

            // Guardar en la lista las vacunas aplicadas a menores de edad por el gestor activo
            foreach (AplicarVacuna dosis in resultadoDosisMenorGestor)
            {
                // Buscar el menor de edad de vacuna aplicada
                Menor menorDB = db.Set<Menor>()
                    .Single(e => e.Id == dosis.IdMenor);

                // Buscar la dosis de cada aplicación de vacuna
                Dosi dosisDB = db.Set<Dosi>()
                    .Single(d => d.Id == dosis.IdDosis);

                // Buscar la vacuna de cada aplicación
                Vacuna vacunaDB = db.Set<Vacuna>()
                    .Single(v => v.Id == dosis.IdVacuna);

                DosisGestor nuevaDosisGestor = new DosisGestor(
                   menorDB.DuiResponsable, menorDB.Nombres, menorDB.Apellidos, dosis.Fecha, dosis.Hora,
                   dosisDB.Nombre, vacunaDB.Nombre);

                listaDosis.Add(nuevaDosisGestor);
            }

            // Mostrar las citas del gestor activo en el Data Gried View
            dgvDosisGestor.DataSource = null;
            dgvDosisGestor.DataSource = listaDosis;
        }
    }
}


/*
// CIUDADANO
// Establecer conexion con la DB
            var db = new ProyectoFinalContext();

            // Obtener todas las citas de todos los ciudadanos de la DB
            var listaCitasCiudadanos = db.Citas
                .Include(i => i.IdCiudadanoNavigation)
                .Include(i => i.IdGestorNavigation)
                .Include(i => i.IdEstablecimientoNavigation)
                .OrderBy(i => i.Id)
                .ToList();

            // Obtener todas las citas del ciudadano activo
            var resultadoCitasCiudadano = listaCitasCiudadanos
                .Where(i => i.IdCiudadanoNavigation.Id.Equals(ciudadano.Id))
                .ToList();

            // Mostrar las citas del usuario activo en el Data Gried View
            List<Citum> listaCitas = new List<Citum>();
            foreach (Citum c in resultadoCitasCiudadano)
            {
                listaCitas.Add(c);
            }

            dgvCitas.DataSource = null;
            dgvCitas.DataSource =listaCitas;
            
*/

/*

        // FUNCIÓN PARA ACTUALIZAR CITAS DE CIUDADANOS REALIZADAS POR GESTOR
        public void actualizarCitasGestor0()
        {
            // Establecer conexion con la DB
            var db = new ProyectoFinalContext();

            // Obtener todas las citas de la DB
            var listaCitasGestores = db.Citas
                .Include(i => i.IdCiudadanoNavigation)
                .Include(i => i.IdGestorNavigation)
                .Include(i => i.IdEstablecimientoNavigation)
                .OrderBy(i => i.Id)
                .ToList();

            // Obtener todas las citas programadas por el gestor activo
            var resultadoCitasGestor = listaCitasGestores
                .Where(c => c.IdGestor.Equals(gestor.Id) && c.IdCiudadano != null)
                .ToList();

            // Mostrar las citas del usuario activo en el Data Gried View
            List<CitasGestor> listaCitas = new List<CitasGestor>();
            foreach (Citum cita in resultadoCitasGestor)
            {
                // Buscar el ciudadano
                Ciudadano ciudadanoDB = db.Set<Ciudadano>()
                    .Single(c => c.Id == cita.IdCiudadano);

                // Buscar el establecimiento de cada cita
                Establecimiento establecimientoDB = db.Set<Establecimiento>()
                    .Single(e => e.Id == cita.IdEstablecimiento);

                CitasGestor nuevaCitaGestor = new CitasGestor(
                    cita.Fecha, cita.Hora, ciudadanoDB.Nombres, ciudadanoDB.Apellidos, establecimientoDB.Nombre);

                listaCitas.Add(nuevaCitaGestor);
            }

            dgvCitasGestor0.DataSource = null;
            dgvCitasGestor0.DataSource = listaCitas;
        }

        // FUNCIÓN PARA ACTUALIZAR CITAS DE EXTRANJEROS REALIZADAS POR GESTOR
        public void actualizarCitasGestor1()
        {
            // Establecer conexion con la DB
            var db = new ProyectoFinalContext();

            // Obtener todas las citas de la DB
            var listaCitasGestores = db.Citas
                .Include(i => i.IdExtranjeroNavigation)
                .Include(i => i.IdGestorNavigation)
                .Include(i => i.IdEstablecimientoNavigation)
                .OrderBy(i => i.Id)
                .ToList();

            // Obtener todas las citas programadas por el gestor activo
            var resultadoCitasGestor = listaCitasGestores
                .Where(c => c.IdGestor.Equals(gestor.Id) && c.IdExtranjero != null)
                .ToList();

            // Mostrar las citas del gestor activo en el Data Gried View
            List<CitasGestor> listaCitas = new List<CitasGestor>();
            foreach (Citum cita in resultadoCitasGestor)
            {
                // Buscar el extranjero de cada cita
                Extranjero extranjeroDB = db.Set<Extranjero>()
                    .Single(e => e.Id == cita.IdExtranjero);

                // Buscar el establecimiento de cada cita
                Establecimiento establecimientoDB = db.Set<Establecimiento>()
                    .Single(e => e.Id == cita.IdEstablecimiento);

                CitasGestor nuevaCitaGestor = new CitasGestor(
                    cita.Fecha, cita.Hora, extranjeroDB.Nombres, extranjeroDB.Apellidos, establecimientoDB.Nombre);

                listaCitas.Add(nuevaCitaGestor);
            }

            dgvCitasGestor1.DataSource = null;
            dgvCitasGestor1.DataSource = listaCitas;
        }

        // FUNCIÓN PARA ACTUALIZAR CITAS DE MENORES DE EDAD REALIZADAS POR GESTOR
        public void actualizarCitasGestor2()
        {
            // Establecer conexion con la DB
            var db = new ProyectoFinalContext();

            // Obtener todas las citas de la DB
            var listaCitasGestores = db.Citas
                .Include(i => i.IdMenorNavigation)
                .Include(i => i.IdGestorNavigation)
                .Include(i => i.IdEstablecimientoNavigation)
                .OrderBy(i => i.Id)
                .ToList();

            // Obtener todas las citas programadas por el gestor activo
            var resultadoCitasGestor = listaCitasGestores
                .Where(c => c.IdGestor.Equals(gestor.Id) && c.IdMenor != null)
                .ToList();

            // Mostrar las citas del gestor activo en el Data Gried View
            List<CitasGestor> listaCitas = new List<CitasGestor>();
            foreach (Citum cita in resultadoCitasGestor)
            {
                // Buscar el menor de edad de cada cita
                Menor menorDB = db.Set<Menor>()
                    .Single(e => e.Id == cita.IdMenor);

                // Buscar el establecimiento de cada cita
                Establecimiento establecimientoDB = db.Set<Establecimiento>()
                    .Single(e => e.Id == cita.IdEstablecimiento);

                CitasGestor nuevaCitaGestor = new CitasGestor(
                    cita.Fecha, cita.Hora, menorDB.Nombres, menorDB.Apellidos, establecimientoDB.Nombre);

                listaCitas.Add(nuevaCitaGestor);
            }

            dgvCitasGestor2.DataSource = null;
            dgvCitasGestor2.DataSource = listaCitas;
        }
*/