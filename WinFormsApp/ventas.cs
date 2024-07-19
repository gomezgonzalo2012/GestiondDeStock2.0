﻿using GestionDeStock.Data.Implements;
using GestionDeStock;
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
using GestionDeStock.Data;

namespace GestionStock
{
    public partial class ventas : Form
    {
        private readonly IVentaRepository _ventaRepository;
        private int _currentPageIndex;
        private int _pageSize;
        private ListaPaginada<Venta> _currentPage;


        private DataTable tabla;
        public ventas(IVentaRepository ventaRepository)
        {
            InitializeComponent();
            _ventaRepository = ventaRepository;
            _currentPageIndex = 1;
            _pageSize = 5;
            Iniciar();
            Consultar(_currentPageIndex);
        }

        private void Iniciar()
        {
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Fecha",
                DataPropertyName = "Fecha",
                Name = "Fecha",
                DisplayIndex = 0
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Producto",
                DataPropertyName = "Producto",
                Name = "Producto",
                DisplayIndex = 1
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Cantidad",
                DataPropertyName = "Cantidad",
                Name = "Cantidad",
                DisplayIndex = 2
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Usuario",
                DataPropertyName = "Usuario",
                Name = "Usuario",
                DisplayIndex = 3
            });

            
            
        }
        private void Consultar(int pageIndex)
        {
            IEnumerable<Venta> lista = _ventaRepository.GetAllVentas();
            _currentPage = ListaPaginada<Venta>.CrearLista(lista, pageIndex, _pageSize);
            dataGridView1.DataSource = _currentPage;
            
            btnAnterior.Enabled = _currentPage.HasPreviousPage;
            btnSiguiente.Enabled = _currentPage.HasNextPage;
            labelPaginado.Text = $"Página {_currentPageIndex} de {_currentPage.TotalPages}";


            var ventas = _currentPage.Select(item => new
            {
                Fecha = item.Fecha,
                Producto = item.Producto.Nombre,
                Cantidad = item.Cantidad,
                Usuario = item?.Usuario.Nombre
            }).ToList();
           

            dataGridView1.DataSource = ventas;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
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
