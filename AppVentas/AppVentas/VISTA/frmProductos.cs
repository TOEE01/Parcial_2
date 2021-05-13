using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppVentas.DAO;
using AppVentas.MODELO;

namespace AppVentas.VISTA
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
            load();


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClsDProductos VProductos = new ClsDProductos();
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_producto producto = new tb_producto();
                producto.nombreProducto = txtProducto.Text;
                producto.precioProducto = txtPrecio.Text;
                producto.estadoProducto = txtEstado.Text;
                VProductos.GuardarProducto(producto);
                load();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ClsDProductos VProductos = new ClsDProductos();
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_producto producto = new tb_producto();
                producto.idProducto = Convert.ToInt32(dtgProductos.CurrentRow.Cells[0].Value.ToString());
                producto.nombreProducto = txtProducto.Text;
                producto.precioProducto = txtPrecio.Text;
                producto.estadoProducto = txtEstado.Text;
                VProductos.ActualizarProducto(producto);
                load();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClsDProductos VProductos = new ClsDProductos();
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                VProductos.EliminarProducto(Convert.ToInt32(dtgProductos.CurrentRow.Cells[0].Value.ToString()));
                load();
            }
        }

        private void load()
        {
            dtgProductos.Rows.Clear();
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                var consulta = (from a in db.tb_producto
                                select a).ToList();
                foreach (var i in consulta)
                {
                    dtgProductos.Rows.Add(i.idProducto,i.nombreProducto,i.precioProducto,i.estadoProducto);
                }
            }
        }
        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string producto = dtgProductos.CurrentRow.Cells[1].Value.ToString();
            string precio = dtgProductos.CurrentRow.Cells[2].Value.ToString();
            string estado = dtgProductos.CurrentRow.Cells[3].Value.ToString();

            txtProducto.Text = producto;
            txtPrecio.Text = precio;
            txtEstado.Text = estado;
        }
    }
}
