namespace GestionStock
{
    partial class agregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregar));
            btnAgregar = new Button();
            btnSalir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtProducto = new TextBox();
            txtPrecio = new TextBox();
            panel1 = new Panel();
            labelHabilitado = new Label();
            checbHabilitado = new CheckBox();
            labelCategoria = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btnAgregar.Location = new Point(206, 415);
            btnAgregar.Margin = new Padding(4, 5, 4, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(126, 38);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btnSalir.Location = new Point(467, 415);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(107, 38);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label1.Location = new Point(51, 102);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label2.Location = new Point(51, 184);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 28);
            label2.TabIndex = 3;
            label2.Text = "CATEGORIA:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label3.Location = new Point(51, 265);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 4;
            label3.Text = "PRECIO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(263, 22);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(271, 34);
            label4.TabIndex = 5;
            label4.Text = "AGREGAR PRODUCTO";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(201, 95);
            txtProducto.Margin = new Padding(4, 5, 4, 5);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(279, 31);
            txtProducto.TabIndex = 6;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(201, 265);
            txtPrecio.Margin = new Padding(4, 5, 4, 5);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(279, 31);
            txtPrecio.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(600, 95);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(146, 102);
            panel1.TabIndex = 9;
            // 
            // labelHabilitado
            // 
            labelHabilitado.AutoSize = true;
            labelHabilitado.Font = new Font("Consolas", 12F, FontStyle.Bold);
            labelHabilitado.Location = new Point(51, 332);
            labelHabilitado.Margin = new Padding(4, 0, 4, 0);
            labelHabilitado.Name = "labelHabilitado";
            labelHabilitado.Size = new Size(155, 28);
            labelHabilitado.TabIndex = 10;
            labelHabilitado.Text = "HABILITADO:";
            // 
            // checbHabilitado
            // 
            checbHabilitado.AutoSize = true;
            checbHabilitado.Location = new Point(227, 337);
            checbHabilitado.Margin = new Padding(4, 5, 4, 5);
            checbHabilitado.Name = "checbHabilitado";
            checbHabilitado.Size = new Size(22, 21);
            checbHabilitado.TabIndex = 12;
            checbHabilitado.UseVisualStyleBackColor = true;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(206, 187);
            labelCategoria.Margin = new Padding(4, 0, 4, 0);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(59, 25);
            labelCategoria.TabIndex = 13;
            labelCategoria.Text = "label5";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label5.Location = new Point(51, 95);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(129, 28);
            label5.TabIndex = 14;
            label5.Text = "PRODUCTO:";
            // 
            // agregar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(790, 567);
            Controls.Add(label5);
            Controls.Add(labelCategoria);
            Controls.Add(checbHabilitado);
            Controls.Add(labelHabilitado);
            Controls.Add(panel1);
            Controls.Add(txtPrecio);
            Controls.Add(txtProducto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Margin = new Padding(4, 5, 4, 5);
            Name = "agregar";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnSalir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtProducto;
        private TextBox txtCategoria;
        private TextBox txtPrecio;
        private Panel panel1;
        private Label labelHabilitado;
        private CheckBox checbHabilitado;
        private Label labelCategoria;
        private Label label5;
    }
}