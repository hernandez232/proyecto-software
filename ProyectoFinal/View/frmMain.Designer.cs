namespace ProyectoFinal.View
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            tabPage4 = new TabPage();
            toolStrip4 = new ToolStrip();
            tsPrincipalGestor2 = new ToolStripLabel();
            tsAgendarCitaGestor2 = new ToolStripLabel();
            tsInformacionGestor2 = new ToolStripLabel();
            tsAplicarDosisGestor2 = new ToolStripLabel();
            tsSalirGestor2 = new ToolStripLabel();
            dgvDosisGestor = new DataGridView();
            label4 = new Label();
            dgvCitasGestor = new DataGridView();
            label3 = new Label();
            tabPage2 = new TabPage();
            toolStrip3 = new ToolStrip();
            tsPrincipal2 = new ToolStripLabel();
            tsAgendarCita2 = new ToolStripLabel();
            tsInformacion2 = new ToolStripLabel();
            tsSalir2 = new ToolStripLabel();
            dgvDosis = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            dgvCitas = new DataGridView();
            tabHomeUsuarios = new TabControl();
            tabPage1 = new TabPage();
            toolStrip1 = new ToolStrip();
            tsPrincipal = new ToolStripLabel();
            tsAgendarCita = new ToolStripLabel();
            tsInformacion = new ToolStripLabel();
            tsSalir = new ToolStripLabel();
            btnInformacion = new Button();
            btnCrearCita = new Button();
            tabPage3 = new TabPage();
            toolStrip2 = new ToolStrip();
            tsPrincipalGestor = new ToolStripLabel();
            tsAgendarCitaGestor = new ToolStripLabel();
            tsInformacionGestor = new ToolStripLabel();
            tsAplicarDosisGestor = new ToolStripLabel();
            tsSalirGestor = new ToolStripLabel();
            btnAplicarDosis = new Button();
            btnInformacionGestor = new Button();
            btnCrearCitaGestor = new Button();
            tabPage4.SuspendLayout();
            toolStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDosisGestor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCitasGestor).BeginInit();
            tabPage2.SuspendLayout();
            toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDosis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            tabHomeUsuarios.SuspendLayout();
            tabPage1.SuspendLayout();
            toolStrip1.SuspendLayout();
            tabPage3.SuspendLayout();
            toolStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(48, 57, 128);
            tabPage4.Controls.Add(toolStrip4);
            tabPage4.Controls.Add(dgvDosisGestor);
            tabPage4.Controls.Add(label4);
            tabPage4.Controls.Add(dgvCitasGestor);
            tabPage4.Controls.Add(label3);
            tabPage4.Location = new Point(4, 27);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(853, 524);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "GestorInfo";
            // 
            // toolStrip4
            // 
            toolStrip4.AutoSize = false;
            toolStrip4.BackColor = Color.FromArgb(159, 166, 200, 255);
            toolStrip4.Font = new Font("Bodoni MT", 9.8F, FontStyle.Italic, GraphicsUnit.Point);
            toolStrip4.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip4.ImageScalingSize = new Size(20, 20);
            toolStrip4.Items.AddRange(new ToolStripItem[] { tsPrincipalGestor2, tsAgendarCitaGestor2, tsInformacionGestor2, tsAplicarDosisGestor2, tsSalirGestor2 });
            toolStrip4.Location = new Point(3, 3);
            toolStrip4.Name = "toolStrip4";
            toolStrip4.RenderMode = ToolStripRenderMode.System;
            toolStrip4.Size = new Size(847, 43);
            toolStrip4.TabIndex = 21;
            toolStrip4.Text = "toolStrip4";
            // 
            // tsPrincipalGestor2
            // 
            tsPrincipalGestor2.BackColor = Color.Transparent;
            tsPrincipalGestor2.ForeColor = Color.Black;
            tsPrincipalGestor2.Image = Properties.Resources.bienvenida;
            tsPrincipalGestor2.Margin = new Padding(10, 1, 10, 2);
            tsPrincipalGestor2.Name = "tsPrincipalGestor2";
            tsPrincipalGestor2.Size = new Size(140, 40);
            tsPrincipalGestor2.Text = "Bienvenido XXXX";
            tsPrincipalGestor2.Click += tsPrincipalGestor2_Click;
            // 
            // tsAgendarCitaGestor2
            // 
            tsAgendarCitaGestor2.BackColor = Color.Transparent;
            tsAgendarCitaGestor2.ForeColor = Color.Black;
            tsAgendarCitaGestor2.Image = Properties.Resources.agendar;
            tsAgendarCitaGestor2.Margin = new Padding(10, 1, 10, 2);
            tsAgendarCitaGestor2.Name = "tsAgendarCitaGestor2";
            tsAgendarCitaGestor2.Size = new Size(105, 40);
            tsAgendarCitaGestor2.Text = "Agendar Cita";
            tsAgendarCitaGestor2.Click += tsAgendarCitaGestor2_Click;
            // 
            // tsInformacionGestor2
            // 
            tsInformacionGestor2.BackColor = Color.Transparent;
            tsInformacionGestor2.ForeColor = Color.Black;
            tsInformacionGestor2.Image = Properties.Resources.informacion;
            tsInformacionGestor2.Margin = new Padding(10, 1, 10, 2);
            tsInformacionGestor2.Name = "tsInformacionGestor2";
            tsInformacionGestor2.Size = new Size(100, 40);
            tsInformacionGestor2.Text = "Información";
            tsInformacionGestor2.Click += tsInformacionGestor2_Click;
            // 
            // tsAplicarDosisGestor2
            // 
            tsAplicarDosisGestor2.ActiveLinkColor = Color.Red;
            tsAplicarDosisGestor2.BackColor = Color.Transparent;
            tsAplicarDosisGestor2.ForeColor = Color.Black;
            tsAplicarDosisGestor2.Image = Properties.Resources.vacuna_covicho;
            tsAplicarDosisGestor2.Margin = new Padding(10, 1, 10, 2);
            tsAplicarDosisGestor2.Name = "tsAplicarDosisGestor2";
            tsAplicarDosisGestor2.Size = new Size(107, 40);
            tsAplicarDosisGestor2.Text = "Aplicar Dosis";
            tsAplicarDosisGestor2.Click += tsAplicarDosisGestor2_Click;
            // 
            // tsSalirGestor2
            // 
            tsSalirGestor2.BackColor = Color.Transparent;
            tsSalirGestor2.Image = Properties.Resources.cerrar_sesion;
            tsSalirGestor2.Name = "tsSalirGestor2";
            tsSalirGestor2.Size = new Size(57, 40);
            tsSalirGestor2.Text = "Salir";
            tsSalirGestor2.Click += tsSalirGestor2_Click;
            // 
            // dgvDosisGestor
            // 
            dgvDosisGestor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDosisGestor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDosisGestor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvDosisGestor.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvDosisGestor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDosisGestor.Location = new Point(17, 330);
            dgvDosisGestor.Name = "dgvDosisGestor";
            dgvDosisGestor.ReadOnly = true;
            dgvDosisGestor.RowHeadersWidth = 51;
            dgvDosisGestor.RowTemplate.Height = 25;
            dgvDosisGestor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDosisGestor.Size = new Size(822, 178);
            dgvDosisGestor.TabIndex = 13;
            // 
            // label4
            // 
            label4.Font = new Font("Cascadia Code", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(17, 292);
            label4.Name = "label4";
            label4.Size = new Size(302, 35);
            label4.TabIndex = 12;
            label4.Text = "Dosis registradas:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvCitasGestor
            // 
            dgvCitasGestor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCitasGestor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCitasGestor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvCitasGestor.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvCitasGestor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitasGestor.Location = new Point(17, 96);
            dgvCitasGestor.Name = "dgvCitasGestor";
            dgvCitasGestor.ReadOnly = true;
            dgvCitasGestor.RowHeadersWidth = 51;
            dgvCitasGestor.RowTemplate.Height = 25;
            dgvCitasGestor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCitasGestor.Size = new Size(822, 170);
            dgvCitasGestor.TabIndex = 11;
            // 
            // label3
            // 
            label3.Font = new Font("Cascadia Code", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(17, 58);
            label3.Name = "label3";
            label3.Size = new Size(302, 35);
            label3.TabIndex = 10;
            label3.Text = "Citas programadas:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(48, 57, 128);
            tabPage2.Controls.Add(toolStrip3);
            tabPage2.Controls.Add(dgvDosis);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(dgvCitas);
            tabPage2.Location = new Point(4, 27);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(853, 524);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "UsuarioInfo";
            // 
            // toolStrip3
            // 
            toolStrip3.AutoSize = false;
            toolStrip3.BackColor = Color.FromArgb(159, 166, 200, 255);
            toolStrip3.Font = new Font("Bodoni MT", 9.8F, FontStyle.Italic, GraphicsUnit.Point);
            toolStrip3.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip3.ImageScalingSize = new Size(20, 20);
            toolStrip3.Items.AddRange(new ToolStripItem[] { tsPrincipal2, tsAgendarCita2, tsInformacion2, tsSalir2 });
            toolStrip3.Location = new Point(3, 3);
            toolStrip3.Name = "toolStrip3";
            toolStrip3.RenderMode = ToolStripRenderMode.System;
            toolStrip3.Size = new Size(847, 42);
            toolStrip3.TabIndex = 18;
            toolStrip3.Text = "toolStrip3";
            // 
            // tsPrincipal2
            // 
            tsPrincipal2.BackColor = Color.Transparent;
            tsPrincipal2.ForeColor = Color.Black;
            tsPrincipal2.Image = Properties.Resources.bienvenida;
            tsPrincipal2.Margin = new Padding(10, 1, 10, 2);
            tsPrincipal2.Name = "tsPrincipal2";
            tsPrincipal2.Size = new Size(140, 39);
            tsPrincipal2.Text = "Bienvenido XXXX";
            tsPrincipal2.Click += tsPrincipal2_Click;
            // 
            // tsAgendarCita2
            // 
            tsAgendarCita2.BackColor = Color.Transparent;
            tsAgendarCita2.ForeColor = Color.Black;
            tsAgendarCita2.Image = Properties.Resources.agendar;
            tsAgendarCita2.Margin = new Padding(10, 1, 10, 2);
            tsAgendarCita2.Name = "tsAgendarCita2";
            tsAgendarCita2.Size = new Size(105, 39);
            tsAgendarCita2.Text = "Agendar Cita";
            tsAgendarCita2.Click += tsAgendarCita2_Click;
            // 
            // tsInformacion2
            // 
            tsInformacion2.BackColor = Color.Transparent;
            tsInformacion2.ForeColor = Color.Black;
            tsInformacion2.Image = Properties.Resources.informacion;
            tsInformacion2.Margin = new Padding(10, 1, 10, 2);
            tsInformacion2.Name = "tsInformacion2";
            tsInformacion2.Size = new Size(100, 39);
            tsInformacion2.Text = "Información";
            tsInformacion2.Click += tsInformacion2_Click;
            // 
            // tsSalir2
            // 
            tsSalir2.ActiveLinkColor = Color.Red;
            tsSalir2.BackColor = Color.Transparent;
            tsSalir2.ForeColor = Color.Black;
            tsSalir2.Image = Properties.Resources.cerrar_sesion;
            tsSalir2.Margin = new Padding(10, 1, 10, 2);
            tsSalir2.Name = "tsSalir2";
            tsSalir2.Size = new Size(57, 39);
            tsSalir2.Text = "Salir";
            tsSalir2.Click += tsSalir2_Click;
            // 
            // dgvDosis
            // 
            dgvDosis.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDosis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDosis.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvDosis.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvDosis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDosis.Location = new Point(15, 331);
            dgvDosis.Name = "dgvDosis";
            dgvDosis.ReadOnly = true;
            dgvDosis.RowHeadersWidth = 51;
            dgvDosis.RowTemplate.Height = 25;
            dgvDosis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDosis.Size = new Size(824, 180);
            dgvDosis.TabIndex = 11;
            // 
            // label1
            // 
            label1.Font = new Font("Cascadia Code", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 293);
            label1.Name = "label1";
            label1.Size = new Size(179, 35);
            label1.TabIndex = 10;
            label1.Text = "Dosis aplicadas:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Cascadia Code", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 54);
            label2.Name = "label2";
            label2.Size = new Size(179, 35);
            label2.TabIndex = 9;
            label2.Text = "Citas programadas:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvCitas
            // 
            dgvCitas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCitas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvCitas.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Location = new Point(15, 92);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.ReadOnly = true;
            dgvCitas.RowHeadersWidth = 51;
            dgvCitas.RowTemplate.Height = 25;
            dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCitas.Size = new Size(824, 168);
            dgvCitas.TabIndex = 1;
            // 
            // tabHomeUsuarios
            // 
            tabHomeUsuarios.Appearance = TabAppearance.FlatButtons;
            tabHomeUsuarios.Controls.Add(tabPage1);
            tabHomeUsuarios.Controls.Add(tabPage2);
            tabHomeUsuarios.Controls.Add(tabPage3);
            tabHomeUsuarios.Controls.Add(tabPage4);
            tabHomeUsuarios.Font = new Font("Cascadia Code", 8F, FontStyle.Italic, GraphicsUnit.Point);
            tabHomeUsuarios.Location = new Point(-5, 0);
            tabHomeUsuarios.Name = "tabHomeUsuarios";
            tabHomeUsuarios.SelectedIndex = 0;
            tabHomeUsuarios.Size = new Size(861, 556);
            tabHomeUsuarios.SizeMode = TabSizeMode.Fixed;
            tabHomeUsuarios.TabIndex = 1;
            tabHomeUsuarios.TabStop = false;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = Properties.Resources.covid_home;
            tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage1.Controls.Add(toolStrip1);
            tabPage1.Controls.Add(btnInformacion);
            tabPage1.Controls.Add(btnCrearCita);
            tabPage1.Location = new Point(4, 27);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(853, 525);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Usuario";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = Color.FromArgb(159, 166, 200, 255);
            toolStrip1.Font = new Font("Bodoni MT", 9.8F, FontStyle.Italic, GraphicsUnit.Point);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsPrincipal, tsAgendarCita, tsInformacion, tsSalir });
            toolStrip1.Location = new Point(3, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(847, 42);
            toolStrip1.TabIndex = 17;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsPrincipal
            // 
            tsPrincipal.BackColor = Color.Transparent;
            tsPrincipal.ForeColor = Color.Black;
            tsPrincipal.Image = Properties.Resources.bienvenida;
            tsPrincipal.Margin = new Padding(10, 1, 10, 2);
            tsPrincipal.Name = "tsPrincipal";
            tsPrincipal.Size = new Size(140, 39);
            tsPrincipal.Text = "Bienvenido XXXX";
            tsPrincipal.Click += tsPrincipal_Click;
            // 
            // tsAgendarCita
            // 
            tsAgendarCita.BackColor = Color.Transparent;
            tsAgendarCita.ForeColor = Color.Black;
            tsAgendarCita.Image = Properties.Resources.agendar;
            tsAgendarCita.Margin = new Padding(10, 1, 10, 2);
            tsAgendarCita.Name = "tsAgendarCita";
            tsAgendarCita.Size = new Size(105, 39);
            tsAgendarCita.Text = "Agendar Cita";
            tsAgendarCita.Click += tsAgendarCita_Click;
            // 
            // tsInformacion
            // 
            tsInformacion.BackColor = Color.Transparent;
            tsInformacion.ForeColor = Color.Black;
            tsInformacion.Image = Properties.Resources.informacion;
            tsInformacion.Margin = new Padding(10, 1, 10, 2);
            tsInformacion.Name = "tsInformacion";
            tsInformacion.Size = new Size(100, 39);
            tsInformacion.Text = "Información";
            tsInformacion.Click += tsInformacion_Click;
            // 
            // tsSalir
            // 
            tsSalir.ActiveLinkColor = Color.Red;
            tsSalir.BackColor = Color.Transparent;
            tsSalir.ForeColor = Color.Black;
            tsSalir.Image = Properties.Resources.cerrar_sesion;
            tsSalir.Margin = new Padding(10, 1, 10, 2);
            tsSalir.Name = "tsSalir";
            tsSalir.Size = new Size(57, 39);
            tsSalir.Text = "Salir";
            tsSalir.Click += tsSalir_Click;
            // 
            // btnInformacion
            // 
            btnInformacion.BackColor = Color.White;
            btnInformacion.FlatStyle = FlatStyle.Flat;
            btnInformacion.Font = new Font("Cascadia Code", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnInformacion.ForeColor = Color.Black;
            btnInformacion.Location = new Point(43, 270);
            btnInformacion.Name = "btnInformacion";
            btnInformacion.Size = new Size(121, 62);
            btnInformacion.TabIndex = 16;
            btnInformacion.Text = "Información";
            btnInformacion.UseVisualStyleBackColor = false;
            btnInformacion.Click += btnInformacion_Click;
            // 
            // btnCrearCita
            // 
            btnCrearCita.BackColor = Color.White;
            btnCrearCita.FlatStyle = FlatStyle.Popup;
            btnCrearCita.Font = new Font("Cascadia Code", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnCrearCita.ForeColor = Color.Black;
            btnCrearCita.Location = new Point(43, 185);
            btnCrearCita.Name = "btnCrearCita";
            btnCrearCita.Size = new Size(121, 62);
            btnCrearCita.TabIndex = 15;
            btnCrearCita.Text = "Agendar Cita";
            btnCrearCita.UseVisualStyleBackColor = false;
            btnCrearCita.Click += btnCrearCita_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = Properties.Resources.covid_home;
            tabPage3.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage3.Controls.Add(toolStrip2);
            tabPage3.Controls.Add(btnAplicarDosis);
            tabPage3.Controls.Add(btnInformacionGestor);
            tabPage3.Controls.Add(btnCrearCitaGestor);
            tabPage3.Location = new Point(4, 27);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(853, 524);
            tabPage3.TabIndex = 4;
            tabPage3.Text = "Gestor";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // toolStrip2
            // 
            toolStrip2.AutoSize = false;
            toolStrip2.BackColor = Color.FromArgb(159, 166, 200, 255);
            toolStrip2.Font = new Font("Bodoni MT", 9.8F, FontStyle.Italic, GraphicsUnit.Point);
            toolStrip2.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip2.ImageScalingSize = new Size(20, 20);
            toolStrip2.Items.AddRange(new ToolStripItem[] { tsPrincipalGestor, tsAgendarCitaGestor, tsInformacionGestor, tsAplicarDosisGestor, tsSalirGestor });
            toolStrip2.Location = new Point(3, 3);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.RenderMode = ToolStripRenderMode.System;
            toolStrip2.Size = new Size(847, 42);
            toolStrip2.TabIndex = 20;
            toolStrip2.Text = "toolStrip2";
            // 
            // tsPrincipalGestor
            // 
            tsPrincipalGestor.BackColor = Color.Transparent;
            tsPrincipalGestor.ForeColor = Color.Black;
            tsPrincipalGestor.Image = Properties.Resources.bienvenida;
            tsPrincipalGestor.Margin = new Padding(10, 1, 10, 2);
            tsPrincipalGestor.Name = "tsPrincipalGestor";
            tsPrincipalGestor.Size = new Size(140, 39);
            tsPrincipalGestor.Text = "Bienvenido XXXX";
            tsPrincipalGestor.Click += tsPrincipalGestor_Click;
            // 
            // tsAgendarCitaGestor
            // 
            tsAgendarCitaGestor.BackColor = Color.Transparent;
            tsAgendarCitaGestor.ForeColor = Color.Black;
            tsAgendarCitaGestor.Image = Properties.Resources.agendar;
            tsAgendarCitaGestor.Margin = new Padding(10, 1, 10, 2);
            tsAgendarCitaGestor.Name = "tsAgendarCitaGestor";
            tsAgendarCitaGestor.Size = new Size(105, 39);
            tsAgendarCitaGestor.Text = "Agendar Cita";
            tsAgendarCitaGestor.Click += tsAgendarCitaGestor_Click;
            // 
            // tsInformacionGestor
            // 
            tsInformacionGestor.BackColor = Color.Transparent;
            tsInformacionGestor.ForeColor = Color.Black;
            tsInformacionGestor.Image = Properties.Resources.informacion;
            tsInformacionGestor.Margin = new Padding(10, 1, 10, 2);
            tsInformacionGestor.Name = "tsInformacionGestor";
            tsInformacionGestor.Size = new Size(100, 39);
            tsInformacionGestor.Text = "Información";
            tsInformacionGestor.Click += tsInformacionGestor_Click;
            // 
            // tsAplicarDosisGestor
            // 
            tsAplicarDosisGestor.ActiveLinkColor = Color.Red;
            tsAplicarDosisGestor.BackColor = Color.Transparent;
            tsAplicarDosisGestor.ForeColor = Color.Black;
            tsAplicarDosisGestor.Image = Properties.Resources.vacuna_covicho;
            tsAplicarDosisGestor.Margin = new Padding(10, 1, 10, 2);
            tsAplicarDosisGestor.Name = "tsAplicarDosisGestor";
            tsAplicarDosisGestor.Size = new Size(107, 39);
            tsAplicarDosisGestor.Text = "Aplicar Dosis";
            tsAplicarDosisGestor.Click += tsAplicarDosisGestor_Click;
            // 
            // tsSalirGestor
            // 
            tsSalirGestor.BackColor = Color.Transparent;
            tsSalirGestor.Image = Properties.Resources.cerrar_sesion;
            tsSalirGestor.Name = "tsSalirGestor";
            tsSalirGestor.Size = new Size(57, 39);
            tsSalirGestor.Text = "Salir";
            tsSalirGestor.Click += tsSalirGestor_Click;
            // 
            // btnAplicarDosis
            // 
            btnAplicarDosis.BackColor = Color.White;
            btnAplicarDosis.FlatStyle = FlatStyle.Flat;
            btnAplicarDosis.Font = new Font("Cascadia Code", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnAplicarDosis.ForeColor = Color.Black;
            btnAplicarDosis.Location = new Point(57, 330);
            btnAplicarDosis.Name = "btnAplicarDosis";
            btnAplicarDosis.Size = new Size(121, 62);
            btnAplicarDosis.TabIndex = 19;
            btnAplicarDosis.Text = "Aplicar Dosis";
            btnAplicarDosis.UseVisualStyleBackColor = false;
            btnAplicarDosis.Click += btnAplicarDosis_Click;
            // 
            // btnInformacionGestor
            // 
            btnInformacionGestor.BackColor = Color.White;
            btnInformacionGestor.FlatStyle = FlatStyle.Flat;
            btnInformacionGestor.Font = new Font("Cascadia Code", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnInformacionGestor.ForeColor = Color.Black;
            btnInformacionGestor.Location = new Point(57, 236);
            btnInformacionGestor.Name = "btnInformacionGestor";
            btnInformacionGestor.Size = new Size(121, 62);
            btnInformacionGestor.TabIndex = 18;
            btnInformacionGestor.Text = "Información";
            btnInformacionGestor.UseVisualStyleBackColor = false;
            btnInformacionGestor.Click += btnInformacionGestor_Click;
            // 
            // btnCrearCitaGestor
            // 
            btnCrearCitaGestor.BackColor = Color.White;
            btnCrearCitaGestor.FlatStyle = FlatStyle.Flat;
            btnCrearCitaGestor.Font = new Font("Cascadia Code", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnCrearCitaGestor.ForeColor = Color.Black;
            btnCrearCitaGestor.Location = new Point(57, 137);
            btnCrearCitaGestor.Name = "btnCrearCitaGestor";
            btnCrearCitaGestor.Size = new Size(121, 62);
            btnCrearCitaGestor.TabIndex = 17;
            btnCrearCitaGestor.Text = "Agendar Cita";
            btnCrearCitaGestor.UseVisualStyleBackColor = false;
            btnCrearCitaGestor.Click += btnCrearCitaGestor_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 69, 193);
            ClientSize = new Size(850, 550);
            Controls.Add(tabHomeUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            FormClosing += frmMain_FormClosing;
            Load += frmMain_Load;
            tabPage4.ResumeLayout(false);
            toolStrip4.ResumeLayout(false);
            toolStrip4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDosisGestor).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCitasGestor).EndInit();
            tabPage2.ResumeLayout(false);
            toolStrip3.ResumeLayout(false);
            toolStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDosis).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            tabHomeUsuarios.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabPage3.ResumeLayout(false);
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvCitasGestor;
        private Label label3;
        private TabPage tabPage4;
        private DataGridView dgvDosis;
        private Label label1;
        private Label label2;
        private DataGridView dgvCitas;
        private TabControl tabHomeUsuarios;
        private TabPage tabPage1;
        private Button btnInformacion;
        private Button btnCrearCita;
        private TabPage tabPage3;
        private TabPage tabPage2;
        private Button btnAplicarDosis;
        private Button btnInformacionGestor;
        private Button btnCrearCitaGestor;
        private DataGridView dgvDosisGestor;
        private ToolStrip toolStrip1;
        private ToolStripLabel tsPrincipal;
        private ToolStripLabel tsAgendarCita;
        private ToolStripLabel tsInformacion;
        private ToolStripLabel tsSalir;
        private ToolStrip toolStrip2;
        private ToolStripLabel tsPrincipalGestor;
        private ToolStripLabel tsAgendarCitaGestor;
        private ToolStripLabel tsInformacionGestor;
        private ToolStripLabel tsAplicarDosisGestor;
        private ToolStripLabel tsSalirGestor;
        private ToolStrip toolStrip4;
        private ToolStripLabel tsPrincipalGestor2;
        private ToolStripLabel tsAgendarCitaGestor2;
        private ToolStripLabel tsInformacionGestor2;
        private ToolStripLabel tsAplicarDosisGestor2;
        private ToolStripLabel tsSalirGestor2;
        private ToolStrip toolStrip3;
        private ToolStripLabel tsPrincipal2;
        private ToolStripLabel tsAgendarCita2;
        private ToolStripLabel tsInformacion2;
        private ToolStripLabel tsSalir2;
        private Label label4;
    }
}