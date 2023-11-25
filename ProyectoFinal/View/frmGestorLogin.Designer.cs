namespace ProyectoFinal.View
{
    partial class frmGestorLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestorLogin));
            label1 = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cmbCabinas = new ComboBox();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Bodoni MT", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(64, 60);
            label1.Name = "label1";
            label1.Size = new Size(139, 31);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(210, 60);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(172, 27);
            txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(210, 121);
            txtContraseña.Margin = new Padding(3, 4, 3, 4);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(172, 27);
            txtContraseña.TabIndex = 3;
            // 
            // label2
            // 
            label2.Font = new Font("Bodoni MT", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(64, 121);
            label2.Name = "label2";
            label2.Size = new Size(139, 31);
            label2.TabIndex = 2;
            label2.Text = "Contraseña:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new Font("Bodoni MT", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(64, 179);
            label3.Name = "label3";
            label3.Size = new Size(139, 31);
            label3.TabIndex = 4;
            label3.Text = "Cabina:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbCabinas
            // 
            cmbCabinas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCabinas.FormattingEnabled = true;
            cmbCabinas.Location = new Point(210, 179);
            cmbCabinas.Margin = new Padding(3, 4, 3, 4);
            cmbCabinas.Name = "cmbCabinas";
            cmbCabinas.Size = new Size(172, 28);
            cmbCabinas.TabIndex = 5;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.White;
            btnIngresar.FlatStyle = FlatStyle.Popup;
            btnIngresar.Font = new Font("Cascadia Code", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.Black;
            btnIngresar.Location = new Point(168, 253);
            btnIngresar.Margin = new Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(103, 45);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // frmGestorLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 57, 128);
            ClientSize = new Size(439, 348);
            Controls.Add(btnIngresar);
            Controls.Add(cmbCabinas);
            Controls.Add(label3);
            Controls.Add(txtContraseña);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGestorLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Sesión";
            FormClosing += frmGestorLogin_FormClosing;
            Load += frmGestorLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Label label2;
        private Label label3;
        private ComboBox cmbCabinas;
        private Button btnIngresar;
    }
}