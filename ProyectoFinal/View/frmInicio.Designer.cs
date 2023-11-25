namespace ProyectoFinal.View
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            pictureBox1 = new PictureBox();
            tabUsuarios = new TabControl();
            tabPage1 = new TabPage();
            btnIngresarCiudadano = new Button();
            txtFechaCiudadano = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtDUI = new TextBox();
            tabPage2 = new TabPage();
            btnIngresarExtranjero = new Button();
            txtFechaExtranjero = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtPasaporteExtranjero = new TextBox();
            tabPage3 = new TabPage();
            btnIngresarMenor = new Button();
            txtFechaMenor = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtDuiResponsable = new TextBox();
            tabPage4 = new TabPage();
            btnIngresarGestor = new Button();
            txtFechaGestor = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtDUIGestor = new TextBox();
            btnCiudadano = new Button();
            btnExtranjero = new Button();
            btnMenorEdad = new Button();
            btnGestor = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabUsuarios.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(48, 57, 128);
            pictureBox1.Image = Properties.Resources.covicho_sin_fondo;
            pictureBox1.Location = new Point(274, 35);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 177);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabUsuarios
            // 
            tabUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabUsuarios.Appearance = TabAppearance.FlatButtons;
            tabUsuarios.Controls.Add(tabPage1);
            tabUsuarios.Controls.Add(tabPage2);
            tabUsuarios.Controls.Add(tabPage3);
            tabUsuarios.Controls.Add(tabPage4);
            tabUsuarios.Location = new Point(-8, 319);
            tabUsuarios.Margin = new Padding(3, 4, 3, 4);
            tabUsuarios.Name = "tabUsuarios";
            tabUsuarios.Padding = new Point(0, 0);
            tabUsuarios.SelectedIndex = 0;
            tabUsuarios.Size = new Size(794, 303);
            tabUsuarios.SizeMode = TabSizeMode.Fixed;
            tabUsuarios.TabIndex = 6;
            tabUsuarios.TabStop = false;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(48, 57, 128);
            tabPage1.Controls.Add(btnIngresarCiudadano);
            tabPage1.Controls.Add(txtFechaCiudadano);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtDUI);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(786, 267);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.Click += tabPage1_Click;
            // 
            // btnIngresarCiudadano
            // 
            btnIngresarCiudadano.BackColor = Color.White;
            btnIngresarCiudadano.FlatStyle = FlatStyle.Flat;
            btnIngresarCiudadano.Font = new Font("Cascadia Code", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnIngresarCiudadano.ForeColor = Color.FromArgb(48, 57, 128);
            btnIngresarCiudadano.Location = new Point(313, 177);
            btnIngresarCiudadano.Margin = new Padding(3, 4, 3, 4);
            btnIngresarCiudadano.Name = "btnIngresarCiudadano";
            btnIngresarCiudadano.Size = new Size(139, 44);
            btnIngresarCiudadano.TabIndex = 9;
            btnIngresarCiudadano.Text = "INGRESAR";
            btnIngresarCiudadano.UseVisualStyleBackColor = false;
            btnIngresarCiudadano.Click += btnIngresarCiudadano_Click;
            // 
            // txtFechaCiudadano
            // 
            txtFechaCiudadano.BorderStyle = BorderStyle.FixedSingle;
            txtFechaCiudadano.Location = new Point(399, 111);
            txtFechaCiudadano.Margin = new Padding(3, 4, 3, 4);
            txtFechaCiudadano.Name = "txtFechaCiudadano";
            txtFechaCiudadano.Size = new Size(273, 27);
            txtFechaCiudadano.TabIndex = 8;
            // 
            // label2
            // 
            label2.Font = new Font("Bodoni MT", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 111);
            label2.Name = "label2";
            label2.Size = new Size(363, 31);
            label2.TabIndex = 7;
            label2.Text = "Ingresa tu fecha de nacimiento:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("Bodoni MT", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(106, 47);
            label1.Name = "label1";
            label1.Size = new Size(286, 31);
            label1.TabIndex = 6;
            label1.Text = "Ingresa tu número de DUI:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtDUI
            // 
            txtDUI.AccessibleDescription = "";
            txtDUI.BorderStyle = BorderStyle.FixedSingle;
            txtDUI.Location = new Point(399, 47);
            txtDUI.Margin = new Padding(3, 4, 3, 4);
            txtDUI.Name = "txtDUI";
            txtDUI.Size = new Size(273, 27);
            txtDUI.TabIndex = 5;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(48, 57, 128);
            tabPage2.Controls.Add(btnIngresarExtranjero);
            tabPage2.Controls.Add(txtFechaExtranjero);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(txtPasaporteExtranjero);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(786, 267);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // btnIngresarExtranjero
            // 
            btnIngresarExtranjero.BackColor = Color.White;
            btnIngresarExtranjero.FlatStyle = FlatStyle.Flat;
            btnIngresarExtranjero.Font = new Font("Cascadia Code", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnIngresarExtranjero.ForeColor = Color.FromArgb(48, 57, 128);
            btnIngresarExtranjero.Location = new Point(315, 181);
            btnIngresarExtranjero.Margin = new Padding(3, 4, 3, 4);
            btnIngresarExtranjero.Name = "btnIngresarExtranjero";
            btnIngresarExtranjero.Size = new Size(139, 44);
            btnIngresarExtranjero.TabIndex = 14;
            btnIngresarExtranjero.Text = "INGRESAR";
            btnIngresarExtranjero.UseVisualStyleBackColor = false;
            btnIngresarExtranjero.Click += btnIngresarExtranjero_Click;
            // 
            // txtFechaExtranjero
            // 
            txtFechaExtranjero.BorderStyle = BorderStyle.FixedSingle;
            txtFechaExtranjero.Location = new Point(401, 115);
            txtFechaExtranjero.Margin = new Padding(3, 4, 3, 4);
            txtFechaExtranjero.Name = "txtFechaExtranjero";
            txtFechaExtranjero.Size = new Size(273, 27);
            txtFechaExtranjero.TabIndex = 13;
            // 
            // label3
            // 
            label3.Font = new Font("Bodoni MT", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(31, 115);
            label3.Name = "label3";
            label3.Size = new Size(363, 31);
            label3.TabIndex = 12;
            label3.Text = "Ingresa su fecha de nacimiento:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Font = new Font("Bodoni MT", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(17, 51);
            label4.Name = "label4";
            label4.Size = new Size(377, 31);
            label4.TabIndex = 11;
            label4.Text = "Ingresa tu número de pasaporte:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtPasaporteExtranjero
            // 
            txtPasaporteExtranjero.AccessibleDescription = "";
            txtPasaporteExtranjero.BorderStyle = BorderStyle.FixedSingle;
            txtPasaporteExtranjero.Location = new Point(401, 51);
            txtPasaporteExtranjero.Margin = new Padding(3, 4, 3, 4);
            txtPasaporteExtranjero.Name = "txtPasaporteExtranjero";
            txtPasaporteExtranjero.Size = new Size(273, 27);
            txtPasaporteExtranjero.TabIndex = 10;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(48, 57, 128);
            tabPage3.Controls.Add(btnIngresarMenor);
            tabPage3.Controls.Add(txtFechaMenor);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(txtDuiResponsable);
            tabPage3.Location = new Point(4, 32);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(786, 267);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            // 
            // btnIngresarMenor
            // 
            btnIngresarMenor.BackColor = Color.White;
            btnIngresarMenor.FlatStyle = FlatStyle.Flat;
            btnIngresarMenor.Font = new Font("Cascadia Code", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnIngresarMenor.ForeColor = Color.FromArgb(48, 57, 128);
            btnIngresarMenor.Location = new Point(313, 177);
            btnIngresarMenor.Margin = new Padding(3, 4, 3, 4);
            btnIngresarMenor.Name = "btnIngresarMenor";
            btnIngresarMenor.Size = new Size(139, 44);
            btnIngresarMenor.TabIndex = 19;
            btnIngresarMenor.Text = "INGRESAR";
            btnIngresarMenor.UseVisualStyleBackColor = false;
            btnIngresarMenor.Click += btnIngresarMenor_Click;
            // 
            // txtFechaMenor
            // 
            txtFechaMenor.BorderStyle = BorderStyle.FixedSingle;
            txtFechaMenor.Location = new Point(399, 111);
            txtFechaMenor.Margin = new Padding(3, 4, 3, 4);
            txtFechaMenor.Name = "txtFechaMenor";
            txtFechaMenor.Size = new Size(273, 27);
            txtFechaMenor.TabIndex = 18;
            // 
            // label7
            // 
            label7.Font = new Font("Bodoni MT", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(29, 111);
            label7.Name = "label7";
            label7.Size = new Size(363, 31);
            label7.TabIndex = 17;
            label7.Text = "Ingresa tu fecha de nacimiento:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Font = new Font("Bodoni MT", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(82, 47);
            label8.Name = "label8";
            label8.Size = new Size(310, 31);
            label8.TabIndex = 16;
            label8.Text = "Ingresa tu número de DUI:";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtDuiResponsable
            // 
            txtDuiResponsable.AccessibleDescription = "";
            txtDuiResponsable.BorderStyle = BorderStyle.FixedSingle;
            txtDuiResponsable.Location = new Point(399, 47);
            txtDuiResponsable.Margin = new Padding(3, 4, 3, 4);
            txtDuiResponsable.Name = "txtDuiResponsable";
            txtDuiResponsable.Size = new Size(273, 27);
            txtDuiResponsable.TabIndex = 15;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(48, 57, 128);
            tabPage4.Controls.Add(btnIngresarGestor);
            tabPage4.Controls.Add(txtFechaGestor);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(txtDUIGestor);
            tabPage4.Location = new Point(4, 32);
            tabPage4.Margin = new Padding(3, 4, 3, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 4, 3, 4);
            tabPage4.Size = new Size(786, 267);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            // 
            // btnIngresarGestor
            // 
            btnIngresarGestor.BackColor = Color.White;
            btnIngresarGestor.FlatStyle = FlatStyle.Flat;
            btnIngresarGestor.Font = new Font("Cascadia Code", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnIngresarGestor.ForeColor = Color.FromArgb(48, 57, 128);
            btnIngresarGestor.Location = new Point(313, 176);
            btnIngresarGestor.Margin = new Padding(3, 4, 3, 4);
            btnIngresarGestor.Name = "btnIngresarGestor";
            btnIngresarGestor.Size = new Size(139, 44);
            btnIngresarGestor.TabIndex = 14;
            btnIngresarGestor.Text = "INGRESAR";
            btnIngresarGestor.UseVisualStyleBackColor = false;
            btnIngresarGestor.Click += btnIngresarGestor_Click;
            // 
            // txtFechaGestor
            // 
            txtFechaGestor.BorderStyle = BorderStyle.FixedSingle;
            txtFechaGestor.Location = new Point(399, 109);
            txtFechaGestor.Margin = new Padding(3, 4, 3, 4);
            txtFechaGestor.Name = "txtFechaGestor";
            txtFechaGestor.Size = new Size(273, 27);
            txtFechaGestor.TabIndex = 13;
            // 
            // label5
            // 
            label5.Font = new Font("Bodoni MT", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(29, 109);
            label5.Name = "label5";
            label5.Size = new Size(363, 31);
            label5.TabIndex = 12;
            label5.Text = "Ingresa tu fecha de nacimiento:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Font = new Font("Bodoni MT", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(73, 45);
            label6.Name = "label6";
            label6.Size = new Size(319, 31);
            label6.TabIndex = 11;
            label6.Text = "Ingresa tu número de DUI:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtDUIGestor
            // 
            txtDUIGestor.AccessibleDescription = "";
            txtDUIGestor.BorderStyle = BorderStyle.FixedSingle;
            txtDUIGestor.Location = new Point(399, 45);
            txtDUIGestor.Margin = new Padding(3, 4, 3, 4);
            txtDUIGestor.Name = "txtDUIGestor";
            txtDUIGestor.Size = new Size(273, 27);
            txtDUIGestor.TabIndex = 10;
            // 
            // btnCiudadano
            // 
            btnCiudadano.BackColor = Color.FromArgb(48, 57, 128);
            btnCiudadano.FlatStyle = FlatStyle.Popup;
            btnCiudadano.Font = new Font("Cascadia Code", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnCiudadano.ForeColor = Color.White;
            btnCiudadano.Location = new Point(153, 265);
            btnCiudadano.Margin = new Padding(3, 4, 3, 4);
            btnCiudadano.Name = "btnCiudadano";
            btnCiudadano.Size = new Size(114, 45);
            btnCiudadano.TabIndex = 15;
            btnCiudadano.Text = "CIUDADANO";
            btnCiudadano.UseVisualStyleBackColor = false;
            btnCiudadano.Click += btnCiudadano_Click;
            // 
            // btnExtranjero
            // 
            btnExtranjero.BackColor = Color.FromArgb(48, 57, 128);
            btnExtranjero.FlatStyle = FlatStyle.Popup;
            btnExtranjero.Font = new Font("Cascadia Code", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnExtranjero.ForeColor = Color.White;
            btnExtranjero.Location = new Point(274, 265);
            btnExtranjero.Margin = new Padding(3, 4, 3, 4);
            btnExtranjero.Name = "btnExtranjero";
            btnExtranjero.Size = new Size(114, 45);
            btnExtranjero.TabIndex = 16;
            btnExtranjero.Text = "EXTRANJERO";
            btnExtranjero.UseVisualStyleBackColor = false;
            btnExtranjero.Click += btnExtranjero_Click;
            // 
            // btnMenorEdad
            // 
            btnMenorEdad.BackColor = Color.FromArgb(48, 57, 128);
            btnMenorEdad.FlatStyle = FlatStyle.Popup;
            btnMenorEdad.Font = new Font("Cascadia Code", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnMenorEdad.ForeColor = Color.White;
            btnMenorEdad.Location = new Point(395, 265);
            btnMenorEdad.Margin = new Padding(3, 4, 3, 4);
            btnMenorEdad.Name = "btnMenorEdad";
            btnMenorEdad.Size = new Size(141, 45);
            btnMenorEdad.TabIndex = 17;
            btnMenorEdad.Text = "MENOR DE EDAD";
            btnMenorEdad.UseVisualStyleBackColor = false;
            btnMenorEdad.Click += btnMenorEdad_Click;
            // 
            // btnGestor
            // 
            btnGestor.BackColor = Color.FromArgb(48, 57, 128);
            btnGestor.FlatStyle = FlatStyle.Popup;
            btnGestor.Font = new Font("Cascadia Code", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnGestor.ForeColor = Color.White;
            btnGestor.Location = new Point(543, 265);
            btnGestor.Margin = new Padding(3, 4, 3, 4);
            btnGestor.Name = "btnGestor";
            btnGestor.Size = new Size(114, 45);
            btnGestor.TabIndex = 18;
            btnGestor.Text = "GESTOR";
            btnGestor.UseVisualStyleBackColor = false;
            btnGestor.Click += btnGestor_Click;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(782, 615);
            Controls.Add(btnGestor);
            Controls.Add(btnMenorEdad);
            Controls.Add(btnExtranjero);
            Controls.Add(btnCiudadano);
            Controls.Add(tabUsuarios);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta Vacuna";
            FormClosing += frmInicio_FormClosing;
            Load += frmInicio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabUsuarios.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TabControl tabUsuarios;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TextBox txtFechaCiudadano;
        private Label label2;
        private Label label1;
        private TextBox txtDUI;
        private Button btnIngresarCiudadano;
        private Button btnIngresarExtranjero;
        private TextBox txtFechaExtranjero;
        private Label label3;
        private Label label4;
        private TextBox txtPasaporteExtranjero;
        private Button btnIngresarGestor;
        private TextBox txtFechaGestor;
        private Label label5;
        private Label label6;
        private TextBox txtDUIGestor;
        private Button btnCiudadano;
        private Button btnExtranjero;
        private Button btnMenorEdad;
        private Button btnGestor;
        private Button btnIngresarMenor;
        private TextBox txtFechaMenor;
        private Label label7;
        private Label label8;
        private TextBox txtDuiResponsable;
    }
}