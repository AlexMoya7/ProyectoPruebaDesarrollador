using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPrueba.Entidades;
using ProyectoPrueba.Negocio;

namespace ProyectoPrueba.Escritorio
{
    public partial class Form1 : Form
    {
        private readonly IProducto _prod;
        private readonly IVenta _vta;
        public Form1(IProducto prod, IVenta vta)
        {
            InitializeComponent();
            _prod = prod;
            _vta = vta;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                CargarProdCb();
                CargarVentasGlobales(_vta.ObtenerVentasGlobales());
                CargarTopArticulosVendidos(_vta.ObtenerArticulosMasVendidos());
                CargarExistencias(_prod.ObtenerExistencias());
            }
            catch (Exception )
            {

                throw;
            }
        }


        private void btnBuscarVentas_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = (int)cboProductos.SelectedValue;

                Venta vta = _vta.ObtenerVentasXArticulo(valor);
                CargarVtaGrid(vta);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Notificación()
        {
            try
            {
                var prod = _prod.ObtenerProductos();
                var mostrar = prod.Select(p => new
                {
                    Titulo = p.Titulo,
                    Existencias = p.Existencias
                }).ToList();

                foreach (var mo in mostrar) 
                {
                    if (mo.Existencias < 100)
                        MessageBox.Show(
                            $"Pedir más {mo.Titulo}",
                            "Advertencia de inventario bajo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CargarExistencias(List<Producto> prd)
        {
            try
            {
                dgvExistencias.DataSource = null;
                dgvExistencias.AutoGenerateColumns = true;
                dgvExistencias.DataSource = prd ;

                Notificación();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CargarTopArticulosVendidos(List<EVentaDetalle> vta)
        {
            try
            {
                dgvMasVendidos.DataSource = null;
                dgvMasVendidos.AutoGenerateColumns = true;
                dgvMasVendidos.DataSource = vta;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CargarVentasGlobales(List<EVentaDetalle> vta)
        {
            try
            {
                dgvVentasTotales.DataSource = null;
                dgvVentasTotales.AutoGenerateColumns = true;
                dgvVentasTotales.DataSource = vta ;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CargarVtaGrid(Venta ventas)
        {
            try
            {
                dgvVentasArticulo.DataSource = null;
                dgvVentasArticulo.AutoGenerateColumns = true;
                dgvVentasArticulo.DataSource = new List<Venta> { ventas };
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void CargarProdCb()
        {
            try
            {
                var prod = _prod.ObtenerProductos();
                var mostrar = prod.Select(p => new 
                {
                    Id = p.Id,
                    Titulo = p.Titulo
                }).ToList();

                cboProductos.DataSource = mostrar;
                cboProductos.DisplayMember = "Titulo";
                cboProductos.ValueMember = "Id";
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
