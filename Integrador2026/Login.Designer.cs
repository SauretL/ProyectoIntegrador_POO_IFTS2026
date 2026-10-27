namespace Integrador2026
{
    partial class frmLogin
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
            txtNombreLogin = new TextBox();
            txtContraseña = new TextBox();
            lblNombreLogin = new Label();
            lblContraseña = new Label();
            btnConfirmarLogin = new Button();
            SuspendLayout();
            // 
            // txtNombreLogin
            // 
            txtNombreLogin.Location = new Point(334, 183);
            txtNombreLogin.Name = "txtNombreLogin";
            txtNombreLogin.Size = new Size(252, 23);
            txtNombreLogin.TabIndex = 0;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(334, 232);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = 'x';
            txtContraseña.Size = new Size(252, 23);
            txtContraseña.TabIndex = 1;
            // 
            // lblNombreLogin
            // 
            lblNombreLogin.AutoSize = true;
            lblNombreLogin.Location = new Point(182, 183);
            lblNombreLogin.Name = "lblNombreLogin";
            lblNombreLogin.Size = new Size(51, 15);
            lblNombreLogin.TabIndex = 2;
            lblNombreLogin.Text = "Nombre";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(182, 232);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 3;
            lblContraseña.Text = "Contraseña";
            lblContraseña.UseWaitCursor = true;
            // 
            // btnConfirmarLogin
            // 
            btnConfirmarLogin.Location = new Point(182, 324);
            btnConfirmarLogin.Name = "btnConfirmarLogin";
            btnConfirmarLogin.Size = new Size(130, 23);
            btnConfirmarLogin.TabIndex = 4;
            btnConfirmarLogin.TabStop = false;
            btnConfirmarLogin.Text = "Confirmar";
            btnConfirmarLogin.UseVisualStyleBackColor = true;
            btnConfirmarLogin.Click += btnConfirmarLogin_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirmarLogin);
            Controls.Add(lblContraseña);
            Controls.Add(lblNombreLogin);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombreLogin);
            Name = "frmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreLogin;
        private Label lblNombreLogin;
        private Label lblContraseña;
        private Button btnConfirmarLogin;
        public TextBox txtContraseña;
    }
}