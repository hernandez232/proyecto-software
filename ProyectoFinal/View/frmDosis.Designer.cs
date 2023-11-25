namespace ProyectoFinal.View
{
    partial class frmDosis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDosis));
            txtDocumento = new TextBox();
            label1 = new Label();
            txtFecha = new TextBox();
            label2 = new Label();
            txtHora = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cmbDosis = new ComboBox();
            btnAceptar = new Button();
            cmbVacuna = new ComboBox();
            label5 = new Label();
            cmbVacunador = new ComboBox();
            cmbEfectoSecundario = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            btnRegresar = new Button();
            SuspendLayout();
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(241, 43);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(151, 23);
            txtDocumento.TabIndex = 5;
            // 
            // label1
            // 
            label1.Font = new Font("Bodoni MT", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(83, 43);
            label1.Name = "label1";
            label1.Size = new Size(152, 23);
            label1.TabIndex = 4;
            label1.Text = "Documento:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(241, 84);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(151, 23);
            txtFecha.TabIndex = 7;
            // 
            // label2
            // 
            label2.Font = new Font("Bodoni MT", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(83, 84);
            label2.Name = "label2";
            label2.Size = new Size(152, 23);
            label2.TabIndex = 6;
            label2.Text = "Fecha:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtHora
            // 
            txtHora.Location = new Point(241, 127);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(151, 23);
            txtHora.TabIndex = 9;
            // 
            // label3
            // 
            label3.Font = new Font("Bodoni MT", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(83, 127);
            label3.Name = "label3";
            label3.Size = new Size(152, 23);
            label3.TabIndex = 8;
            label3.Text = "Hora:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Font = new Font("Bodoni MT", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(83, 170);
            label4.Name = "label4";
            label4.Size = new Size(152, 23);
            label4.TabIndex = 10;
            label4.Text = "Dosis:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbDosis
            // 
            cmbDosis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDosis.FormattingEnabled = true;
            cmbDosis.Location = new Point(241, 170);
            cmbDosis.Name = "cmbDosis";
            cmbDosis.Size = new Size(151, 23);
            cmbDosis.TabIndex = 11;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.White;
            btnAceptar.FlatStyle = FlatStyle.Popup;
            btnAceptar.Font = new Font("Cascadia Code", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.Black;
            btnAceptar.Location = new Point(261, 333);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(100, 34);
            btnAceptar.TabIndex = 15;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cmbVacuna
            // 
            cmbVacuna.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVacuna.FormattingEnabled = true;
            cmbVacuna.Location = new Point(241, 212);
            cmbVacuna.Name = "cmbVacuna";
            cmbVacuna.Size = new Size(151, 23);
            cmbVacuna.TabIndex = 17;
            // 
            // label5
            // 
            label5.Font = new Font("Bodoni MT", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(60, 212);
            label5.Name = "label5";
            label5.Size = new Size(175, 23);
            label5.TabIndex = 16;
            label5.Text = "Vacuna:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbVacunador
            // 
            cmbVacunador.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVacunador.FormattingEnabled = true;
            cmbVacunador.Location = new Point(241, 253);
            cmbVacunador.Name = "cmbVacunador";
            cmbVacunador.Size = new Size(151, 23);
            cmbVacunador.TabIndex = 18;
            // 
            // cmbEfectoSecundario
            // 
            cmbEfectoSecundario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEfectoSecundario.FormattingEnabled = true;
            cmbEfectoSecundario.Location = new Point(241, 292);
            cmbEfectoSecundario.Name = "cmbEfectoSecundario";
            cmbEfectoSecundario.Size = new Size(151, 23);
            cmbEfectoSecundario.TabIndex = 19;
            // 
            // label6
            // 
            label6.Font = new Font("Bodoni MT", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(60, 292);
            label6.Name = "label6";
            label6.Size = new Size(175, 23);
            label6.TabIndex = 20;
            label6.Text = "Efecto secundario:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Font = new Font("Bodoni MT", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(60, 253);
            label7.Name = "label7";
            label7.Size = new Size(175, 23);
            label7.TabIndex = 21;
            label7.Text = "Vacunador:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.White;
            btnRegresar.FlatStyle = FlatStyle.Popup;
            btnRegresar.Font = new Font("Cascadia Code", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnRegresar.ForeColor = Color.Black;
            btnRegresar.Location = new Point(135, 333);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(100, 34);
            btnRegresar.TabIndex = 22;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // frmDosis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 57, 128);
            ClientSize = new Size(484, 411);
            Controls.Add(btnRegresar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cmbEfectoSecundario);
            Controls.Add(cmbVacunador);
            Controls.Add(cmbVacuna);
            Controls.Add(label5);
            Controls.Add(btnAceptar);
            Controls.Add(cmbDosis);
            Controls.Add(label4);
            Controls.Add(txtHora);
            Controls.Add(label3);
            Controls.Add(txtFecha);
            Controls.Add(label2);
            Controls.Add(txtDocumento);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDosis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aplicar Vacuna";
            FormClosing += frmDosis_FormClosing;
            Load += frmDosis_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDocumento;
        private Label label1;
        private TextBox txtFecha;
        private Label label2;
        private TextBox txtHora;
        private Label label3;
        private Label label4;
        private ComboBox cmbDosis;
        private Button btnAceptar;
        private ComboBox cmbVacuna;
        private Label label5;
        private ComboBox cmbVacunador;
        private ComboBox cmbEfectoSecundario;
        private Label label6;
        private Label label7;
        private Button btnRegresar;
    }
}