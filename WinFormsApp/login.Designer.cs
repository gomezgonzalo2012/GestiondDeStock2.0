namespace GestionStock
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            txtusuario = new TextBox();
            txtContrasenia = new TextBox();
            lblusuario = new Label();
            lblcontraseña = new Label();
            lblLogin = new Label();
            bntIngresar = new Button();
            panel1 = new Panel();
            btnsalir = new Button();
            btnRegistrarse = new Button();
            SuspendLayout();
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(426, 183);
            txtusuario.Margin = new Padding(4, 5, 4, 5);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(404, 31);
            txtusuario.TabIndex = 0;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(426, 287);
            txtContrasenia.Margin = new Padding(4, 5, 4, 5);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.Size = new Size(404, 31);
            txtContrasenia.TabIndex = 1;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusuario.Location = new Point(273, 192);
            lblusuario.Margin = new Padding(4, 0, 4, 0);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(116, 27);
            lblusuario.TabIndex = 2;
            lblusuario.Text = "USUARIO:";
            // 
            // lblcontraseña
            // 
            lblcontraseña.AutoSize = true;
            lblcontraseña.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcontraseña.Location = new Point(239, 295);
            lblcontraseña.Margin = new Padding(4, 0, 4, 0);
            lblcontraseña.Name = "lblcontraseña";
            lblcontraseña.Size = new Size(155, 27);
            lblcontraseña.TabIndex = 3;
            lblcontraseña.Text = "CONTRASEÑA:";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Consolas", 21.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(497, 88);
            lblLogin.Margin = new Padding(4, 0, 4, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(142, 51);
            lblLogin.TabIndex = 4;
            lblLogin.Text = "LOGIN";
            // 
            // bntIngresar
            // 
            bntIngresar.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntIngresar.Location = new Point(331, 398);
            bntIngresar.Margin = new Padding(4, 5, 4, 5);
            bntIngresar.Name = "bntIngresar";
            bntIngresar.Size = new Size(127, 38);
            bntIngresar.TabIndex = 5;
            bntIngresar.Text = "INGRESAR";
            bntIngresar.UseVisualStyleBackColor = true;
            bntIngresar.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(81, 40);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(156, 218);
            panel1.TabIndex = 6;
            // 
            // btnsalir
            // 
            btnsalir.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsalir.Location = new Point(704, 397);
            btnsalir.Margin = new Padding(4, 5, 4, 5);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(127, 38);
            btnsalir.TabIndex = 7;
            btnsalir.Text = "SALIR";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarse.Location = new Point(497, 397);
            btnRegistrarse.Margin = new Padding(4, 5, 4, 5);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(167, 38);
            btnRegistrarse.TabIndex = 8;
            btnRegistrarse.Text = "REGISTRARSE";
            btnRegistrarse.UseVisualStyleBackColor = true;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(886, 490);
            Controls.Add(btnRegistrarse);
            Controls.Add(btnsalir);
            Controls.Add(panel1);
            Controls.Add(bntIngresar);
            Controls.Add(lblLogin);
            Controls.Add(lblcontraseña);
            Controls.Add(lblusuario);
            Controls.Add(txtContrasenia);
            Controls.Add(txtusuario);
            Margin = new Padding(4, 5, 4, 5);
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtusuario;
        private TextBox txtContrasenia;
        private Label lblusuario;
        private Label lblcontraseña;
        private Label lblLogin;
        private Button bntIngresar;
        private Panel panel1;
        private Button btnsalir;
        private Button btnRegistrarse;
    }
}
