namespace ProyectoFinal.View
{
    partial class frmCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCitas));
            tabPage2 = new TabPage();
            btnRegresarGestor = new Button();
            txtDocumento = new TextBox();
            txtHoraGestor = new TextBox();
            txtFechaGestor = new TextBox();
            label7 = new Label();
            btnConfirmarGestor = new Button();
            cmbEstablecimientoGestor = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tabPage1 = new TabPage();
            btnRegresar = new Button();
            btnConfirmar = new Button();
            cmbEstablecimiento = new ComboBox();
            label3 = new Label();
            txtHora = new TextBox();
            label2 = new Label();
            txtFecha = new TextBox();
            label1 = new Label();
            tabAgendarCitaUsuarios = new TabControl();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabAgendarCitaUsuarios.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(48, 57, 128);
            tabPage2.Controls.Add(btnRegresarGestor);
            tabPage2.Controls.Add(txtDocumento);
            tabPage2.Controls.Add(txtHoraGestor);
            tabPage2.Controls.Add(txtFechaGestor);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(btnConfirmarGestor);
            tabPage2.Controls.Add(cmbEstablecimientoGestor);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 27);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(392, 238);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Gestor";
            // 
            // btnRegresarGestor
            // 
            btnRegresarGestor.BackColor = Color.White;
            btnRegresarGestor.FlatStyle = FlatStyle.Popup;
            btnRegresarGestor.Font = new Font("Cascadia Code", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            btnRegresarGestor.ForeColor = Color.Black;
            btnRegresarGestor.Location = new Point(81, 189);
            btnRegresarGestor.Name = "btnRegresarGestor";
            btnRegresarGestor.Size = new Size(100, 34);
            btnRegresarGestor.TabIndex = 31;
            btnRegresarGestor.Text = "REGRESAR";
            btnRegresarGestor.UseVisualStyleBackColor = false;
            btnRegresarGestor.Click += btnRegresarGestor_Click;
            // 
            // txtDocumento
            // 
            txtDocumento.BorderStyle = BorderStyle.FixedSingle;
            txtDocumento.Location = new Point(187, 23);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(151, 20);
            txtDocumento.TabIndex = 30;
            txtDocumento.TextChanged += txtDocumento_TextChanged_1;
            // 
            // txtHoraGestor
            // 
            txtHoraGestor.Location = new Point(187, 106);
            txtHoraGestor.Name = "txtHoraGestor";
            txtHoraGestor.Size = new Size(151, 20);
            txtHoraGestor.TabIndex = 25;
            // 
            // txtFechaGestor
            // 
            txtFechaGestor.Location = new Point(187, 64);
            txtFechaGestor.Name = "txtFechaGestor";
            txtFechaGestor.Size = new Size(151, 20);
            txtFechaGestor.TabIndex = 23;
            // 
            // label7
            // 
            label7.Font = new Font("Bodoni MT", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(59, 25);
            label7.Name = "label7";
            label7.Size = new Size(122, 23);
            label7.TabIndex = 29;
            label7.Text = "Documento:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnConfirmarGestor
            // 
            btnConfirmarGestor.BackColor = Color.White;
            btnConfirmarGestor.FlatStyle = FlatStyle.Popup;
            btnConfirmarGestor.Font = new Font("Cascadia Code", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            btnConfirmarGestor.ForeColor = Color.Black;
            btnConfirmarGestor.Location = new Point(213, 189);
            btnConfirmarGestor.Name = "btnConfirmarGestor";
            btnConfirmarGestor.Size = new Size(100, 34);
            btnConfirmarGestor.TabIndex = 28;
            btnConfirmarGestor.Text = "CONFIRMAR";
            btnConfirmarGestor.UseVisualStyleBackColor = false;
            btnConfirmarGestor.Click += btnConfirmarGestor_Click;
            // 
            // cmbEstablecimientoGestor
            // 
            cmbEstablecimientoGestor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstablecimientoGestor.FormattingEnabled = true;
            cmbEstablecimientoGestor.Location = new Point(187, 148);
            cmbEstablecimientoGestor.Name = "cmbEstablecimientoGestor";
            cmbEstablecimientoGestor.Size = new Size(151, 23);
            cmbEstablecimientoGestor.TabIndex = 27;
            // 
            // label4
            // 
            label4.Font = new Font("Bodoni MT", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(23, 148);
            label4.Name = "label4";
            label4.Size = new Size(158, 23);
            label4.TabIndex = 26;
            label4.Text = "Establecimiento:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Font = new Font("Bodoni MT", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(59, 106);
            label5.Name = "label5";
            label5.Size = new Size(122, 23);
            label5.TabIndex = 24;
            label5.Text = "Hora:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Font = new Font("Bodoni MT", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(59, 64);
            label6.Name = "label6";
            label6.Size = new Size(122, 23);
            label6.TabIndex = 22;
            label6.Text = "Fecha:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(48, 57, 128);
            tabPage1.Controls.Add(btnRegresar);
            tabPage1.Controls.Add(btnConfirmar);
            tabPage1.Controls.Add(cmbEstablecimiento);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtHora);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtFecha);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 27);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(392, 238);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Usuario";
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.White;
            btnRegresar.FlatStyle = FlatStyle.Popup;
            btnRegresar.Font = new Font("Cascadia Code", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnRegresar.ForeColor = Color.Black;
            btnRegresar.Location = new Point(82, 171);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(100, 34);
            btnRegresar.TabIndex = 22;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.White;
            btnConfirmar.FlatStyle = FlatStyle.Popup;
            btnConfirmar.Font = new Font("Cascadia Code", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnConfirmar.ForeColor = Color.Black;
            btnConfirmar.Location = new Point(214, 171);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(100, 34);
            btnConfirmar.TabIndex = 21;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // cmbEstablecimiento
            // 
            cmbEstablecimiento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstablecimiento.FormattingEnabled = true;
            cmbEstablecimiento.Location = new Point(188, 125);
            cmbEstablecimiento.Name = "cmbEstablecimiento";
            cmbEstablecimiento.Size = new Size(151, 23);
            cmbEstablecimiento.TabIndex = 20;
            // 
            // label3
            // 
            label3.Font = new Font("Bodoni MT", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 125);
            label3.Name = "label3";
            label3.Size = new Size(158, 23);
            label3.TabIndex = 19;
            label3.Text = "Establecimiento:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtHora
            // 
            txtHora.Location = new Point(188, 83);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(151, 20);
            txtHora.TabIndex = 18;
            // 
            // label2
            // 
            label2.Font = new Font("Bodoni MT", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(60, 83);
            label2.Name = "label2";
            label2.Size = new Size(122, 23);
            label2.TabIndex = 17;
            label2.Text = "Hora:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(188, 41);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(151, 20);
            txtFecha.TabIndex = 16;
            // 
            // label1
            // 
            label1.Font = new Font("Bodoni MT", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(60, 41);
            label1.Name = "label1";
            label1.Size = new Size(122, 23);
            label1.TabIndex = 15;
            label1.Text = "Fecha:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tabAgendarCitaUsuarios
            // 
            tabAgendarCitaUsuarios.Appearance = TabAppearance.FlatButtons;
            tabAgendarCitaUsuarios.Controls.Add(tabPage1);
            tabAgendarCitaUsuarios.Controls.Add(tabPage2);
            tabAgendarCitaUsuarios.Font = new Font("Cascadia Code", 8F, FontStyle.Italic, GraphicsUnit.Point);
            tabAgendarCitaUsuarios.Location = new Point(-9, -1);
            tabAgendarCitaUsuarios.Name = "tabAgendarCitaUsuarios";
            tabAgendarCitaUsuarios.SelectedIndex = 0;
            tabAgendarCitaUsuarios.Size = new Size(400, 269);
            tabAgendarCitaUsuarios.SizeMode = TabSizeMode.Fixed;
            tabAgendarCitaUsuarios.TabIndex = 15;
            tabAgendarCitaUsuarios.TabStop = false;
            // 
            // frmCitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 69, 193);
            ClientSize = new Size(384, 261);
            Controls.Add(tabAgendarCitaUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCitas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agendar cita";
            FormClosing += frmCitas_FormClosing;
            Load += frmCitas_Load;
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabAgendarCitaUsuarios.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private TextBox txtDocumento;
        private TextBox txtHoraGestor;
        private TextBox txtFechaGestor;
        private Label label7;
        private Button btnConfirmarGestor;
        private ComboBox cmbEstablecimientoGestor;
        private Label label4;
        private Label label5;
        private Label label6;
        private TabPage tabPage1;
        private Button btnConfirmar;
        private ComboBox cmbEstablecimiento;
        private Label label3;
        private TextBox txtHora;
        private Label label2;
        private TextBox txtFecha;
        private Label label1;
        private TabControl tabAgendarCitaUsuarios;
        private Button btnRegresar;
        private Button btnRegresarGestor;
    }
}