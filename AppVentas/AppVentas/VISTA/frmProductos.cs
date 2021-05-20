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
            using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
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
            using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
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
            using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
            {
                VProductos.EliminarProducto(Convert.ToInt32(dtgProductos.CurrentRow.Cells[0].Value.ToString()));
                load();
            }
        }

        private void load()
        {
            dtgProductos.Rows.Clear();
            using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
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
            string id = dtgProductos.CurrentRow.Cells[0].Value.ToString();
            string Nombre = dtgProductos.CurrentRow.Cells[1].Value.ToString();
            string precio = dtgProductos.CurrentRow.Cells[2].Value.ToString();


            //txtProducto.Text = producto;
            //txtPrecio.Text = precio;
            //txtEstado.Text = estado;

            FrmMenuVenta.FrmVenta.txtCodigoProducto.Text = id;
            FrmMenuVenta.FrmVenta.txtNombreProducto.Text = Nombre;
            FrmMenuVenta.FrmVenta.txtPrecio.Text = precio;
            

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtProducto.Clear();
            txtPrecio.Clear();
            txtEstado.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnNormal.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnNormal.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
