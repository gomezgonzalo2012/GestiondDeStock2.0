using GestionDeStock.Business.Interfaces;
using GestionDeStock.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionDeStock;
using GestionDeStock.Business.Implements;




namespace GestionStock
{
    public partial class agregar : Form


    {
        ICategoriaBusiness _categoriaBusiness;
        IProductoBusiness _productoBusiness;

        public Categoria CategoriaA;

        public agregar(IProductoBusiness productoBusiness, ICategoriaBusiness categoriaBusiness)
        {
            InitializeComponent();
            _productoBusiness = productoBusiness;
            _categoriaBusiness = categoriaBusiness;
            
                
        }
        public void SetCategoriaActual(Categoria categoria)
        {
            CategoriaA = categoria;
            Iniciar();

        }
        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void Iniciar()
        {

            if (labelCategoria == null)
            {
                MessageBox.Show("labelCategoria no está inicializado.");
                return;
            }
            if (CategoriaA != null)
            {
                labelCategoria.Text = CategoriaA.Nombre;
            }
            else
            {
                labelCategoria.Text = "Categoría no seleccionada";
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProducto.Text)|| string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

           

            GestionDeStock.Producto producto = new GestionDeStock.Producto
            {
                Nombre = txtProducto.Text,
                CategoriaId = CategoriaA.CategoriaId, 
                Precio = Convert.ToDecimal(txtPrecio.Text),
                Habilitado = checbHabilitado.Checked
            };

            var resultProducto =_productoBusiness.AddProducto(producto);
            if (resultProducto == 1)
            {
                MessageBox.Show("El producto ya existe.");

            }

            DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

       
        
       
    }
}
