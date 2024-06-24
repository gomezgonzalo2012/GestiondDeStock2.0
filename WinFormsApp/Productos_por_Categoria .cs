﻿using GestionDeStock;
using GestionDeStock.Business.Interfaces;
using GestionDeStock.Data;
using GestionDeStock.Data.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock
{
    public partial class Productos_por_Categoria : Form
    {

        private readonly IProductoBusiness _productoBusiness;
        private readonly IStockBusiness _stockBusiness;
        private readonly ICategoriaBusiness _categoriaBusiness;
        private int _currentPageIndex;
        private int _pageSize;
        private ListaPaginada<Producto> _currentPage;
        public Categoria CategoriaActual { get; set; }



        public Productos_por_Categoria(IProductoBusiness productoBusiness, IStockBusiness stockBusiness, ICategoriaBusiness categoriaBusiness)
        {
            InitializeComponent();
            _productoBusiness = productoBusiness;
            _stockBusiness = stockBusiness;
            _categoriaBusiness = categoriaBusiness;
            _currentPageIndex = 1;
            _pageSize = 7;
            Iniciar();
            //_repository = repository;
            //_producto = producto;
            //Consultar();

        }

        public void SetCategoriaActual(Categoria categoria)
        {

            CategoriaActual = categoria;
            lblCategoria.Text = categoria.Nombre;
            Consultar(_currentPageIndex);
        }


        private void Iniciar()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Producto",
                DataPropertyName = "Producto",
                Name = "Producto",
                DisplayIndex = 0
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Categoria",
                DataPropertyName = "Categoria",
                Name = "Categoria",
                DisplayIndex = 1
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Precio",
                DataPropertyName = "Precio",
                Name = "Precio",
                DisplayIndex = 2
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Stock",
                DataPropertyName = "Stock",
                Name = "Stock",
                DisplayIndex = 3
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Habilitado",
                DataPropertyName = "Habilitado",
                Name = "Habilitado",
                DisplayIndex = 4
            });


            btnAtras.Click += btnAtras_Click;
            btnSiguiente.Click += btnSiguiente_Click;
            
        }

        private void Consultar(int pageIndex)
        {
            // label2.Text = CategoriaActual.Nombre;
            {
                if (CategoriaActual.Productos == null)
                {
                    MessageBox.Show("No hay productos en esta Categoria");
                    return;
                }

                var productos = CategoriaActual.Productos.Select(item => new
                {
                    Producto = item.Nombre,
                    Categoria = CategoriaActual.Nombre,
                    Precio = item.Precio, // Asume que esta propiedad existe en Producto
                    Stock = _stockBusiness.ObtenerStockDeProducto(item.ProductoId),
                    item.Habilitado
                }).ToList();

                _currentPage = ListaPaginada<Producto>.CrearLista(CategoriaActual.Productos, pageIndex, _pageSize);

                var paginaProductos = _currentPage.Select(item => new
                {
                    Producto = item.Nombre,
                    Categoria = CategoriaActual.Nombre,
                    Precio = item.Precio,
                    Stock = _stockBusiness.ObtenerStockDeProducto(item.ProductoId),
                    item.Habilitado
                }).ToList();

                dataGridView1.DataSource = paginaProductos;
                labelPaginado.Text = $"Página {_currentPage.PageIndex} de {_currentPage.TotalPages}";


                //dataGridView1.DataSource = productos;
                //label2.Text = CategoriaActual.Nombre;
            }
        }





        private void bntAgregar_Click(object sender, EventArgs e)
        {
            using (var formAgregar = new agregar(_productoBusiness, _categoriaBusiness))
            {
                formAgregar.SetCategoriaActual(CategoriaActual);


                if (formAgregar.ShowDialog() == DialogResult.OK)
                {
                    Consultar(_currentPageIndex);

                }
                

            }

        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {



                var selectedRow = dataGridView1.SelectedRows[0];
                var productoNombre = selectedRow.Cells["Producto"].Value.ToString();
                var producto = CategoriaActual.Productos.First(p => p.Nombre == productoNombre);

                using (var form8 = new Editar(_productoBusiness))
                {
                    form8.SetProducto(producto);

                    if (form8.ShowDialog() == DialogResult.OK)
                    {
                        Consultar(_currentPageIndex);
                    }


                    //    Form8 form8 = Program.ServiceProvider.GetRequiredService<Form8>();

                    //if (form8.Visible)
                    //{
                    //    MessageBox.Show("El formulario ya esta abierto");
                    //}

                    //form8.SetProducto(producto);
                    //form8.Show();

                    //if(form8.ShowDialog() == DialogResult.OK)
                    //{
                    //    Consultar();
                    //}
                }
            }
            else
            {

                MessageBox.Show("Por favor, seleccione un producto para editar.");
            }
        }

        private void btnDesahibilar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un producto.");
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            var productoNombre = selectedRow.Cells["Producto"].Value.ToString();
            var producto = CategoriaActual.Productos.First(p => p.Nombre == productoNombre);

            if (!producto.Habilitado)
            {
                MessageBox.Show("El producto ya está deshabilitado.");
                return;
            }

            // Cambiar el estado del producto a deshabilitado
            producto.Habilitado = false;

            // Lógica para guardar los cambios en la base de datos o sistema de almacenamiento
            _productoBusiness.UpdateProducto(producto);

            // Refrescar la vista
            Consultar(_currentPageIndex);

            MessageBox.Show("El producto ha sido deshabilitado.");

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (_currentPage.HasPreviousPage)
            {
                _currentPageIndex--;
                Consultar(_currentPageIndex);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (_currentPage.HasNextPage)
            {
                _currentPageIndex++;
                Consultar(_currentPageIndex);
            }
        }

        
    }
}
