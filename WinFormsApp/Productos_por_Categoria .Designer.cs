namespace GestionStock
{
    partial class Productos_por_Categoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos_por_Categoria));
            dataGridView1 = new DataGridView();
            btnSalir = new Button();
            bntAgregar = new Button();
            bntEditar = new Button();
            btnDesahibilar = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            btnAtras = new Button();
            btnSiguiente = new Button();
            labelPaginado = new Label();
            lblCategoria = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 198);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(746, 453);
            dataGridView1.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.IndianRed;
            btnSalir.Location = new Point(840, 565);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(107, 48);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // bntAgregar
            // 
            bntAgregar.Font = new Font("Consolas", 12F, FontStyle.Bold);
            bntAgregar.Location = new Point(824, 315);
            bntAgregar.Margin = new Padding(4, 5, 4, 5);
            bntAgregar.Name = "bntAgregar";
            bntAgregar.Size = new Size(156, 38);
            bntAgregar.TabIndex = 2;
            bntAgregar.Text = "AGREGAR";
            bntAgregar.UseVisualStyleBackColor = true;
            bntAgregar.Click += bntAgregar_Click;
            // 
            // bntEditar
            // 
            bntEditar.Font = new Font("Consolas", 12F, FontStyle.Bold);
            bntEditar.Location = new Point(824, 405);
            bntEditar.Margin = new Padding(4, 5, 4, 5);
            bntEditar.Name = "bntEditar";
            bntEditar.Size = new Size(156, 38);
            bntEditar.TabIndex = 3;
            bntEditar.Text = "EDITAR";
            bntEditar.UseVisualStyleBackColor = true;
            bntEditar.Click += bntEditar_Click;
            // 
            // btnDesahibilar
            // 
            btnDesahibilar.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btnDesahibilar.Location = new Point(810, 490);
            btnDesahibilar.Margin = new Padding(4, 5, 4, 5);
            btnDesahibilar.Name = "btnDesahibilar";
            btnDesahibilar.Size = new Size(186, 38);
            btnDesahibilar.TabIndex = 4;
            btnDesahibilar.Text = "DESHABILITAR";
            btnDesahibilar.UseVisualStyleBackColor = true;
            btnDesahibilar.Click += btnDesahibilar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(793, 248);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(238, 42);
            label1.TabIndex = 5;
            label1.Text = "ADMINISTRAR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(173, 73);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(218, 42);
            label2.TabIndex = 6;
            label2.Text = "CATEGORÍA:";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(771, 3);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 220);
            panel1.TabIndex = 7;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(17, 660);
            btnAtras.Margin = new Padding(4, 5, 4, 5);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(107, 38);
            btnAtras.TabIndex = 8;
            btnAtras.Text = "<Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(133, 662);
            btnSiguiente.Margin = new Padding(4, 5, 4, 5);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(107, 38);
            btnSiguiente.TabIndex = 9;
            btnSiguiente.Text = "Siguiente>";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // labelPaginado
            // 
            labelPaginado.AutoSize = true;
            labelPaginado.Location = new Point(619, 660);
            labelPaginado.Margin = new Padding(4, 0, 4, 0);
            labelPaginado.Name = "labelPaginado";
            labelPaginado.Size = new Size(59, 25);
            labelPaginado.TabIndex = 10;
            labelPaginado.Text = "label3";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(409, 70);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(35, 45);
            lblCategoria.TabIndex = 11;
            lblCategoria.Text = "*";
            // 
            // Productos_por_Categoria
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1099, 745);
            Controls.Add(lblCategoria);
            Controls.Add(labelPaginado);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAtras);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDesahibilar);
            Controls.Add(bntEditar);
            Controls.Add(bntAgregar);
            Controls.Add(btnSalir);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Productos_por_Categoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnSalir;
        private Button bntAgregar;
        private Button bntEditar;
        private Button btnDesahibilar;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button btnAtras;
        private Button btnSiguiente;
        private Label labelPaginado;
        private Label lblCategoria;
    }
}