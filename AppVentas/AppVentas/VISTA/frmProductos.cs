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
            cargardatos();
            


        }
        void cargardatos()
        {
            var ClsDProductos = new ClsDProductos();
            dtgProductos.Rows.Clear();

            foreach (var listarDatos in ClsDProductos.MostrarProducto(txtBuscarProducto.Text))
            {
                dtgProductos.Rows.Add(listarDatos.idProducto, listarDatos.nombreProducto, listarDatos.precioProducto);
            }

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
           


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtProducto.Clear();
            txtPrecio.Clear();
            txtEstado.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        void envio()
        {
            string id = dtgProductos.CurrentRow.Cells[0].Value.ToString();
            string Nombre = dtgProductos.CurrentRow.Cells[1].Value.ToString();
            string precio = dtgProductos.CurrentRow.Cells[2].Value.ToString();



            //txtEstado.Text = id;
            //txtProducto.Text = Nombre;
            //txtPrecio.Text = precio;




            FrmMenuVenta.FrmVenta.txtId.Text = id;
            FrmMenuVenta.FrmVenta.txtNombreProducto.Text = Nombre;
            FrmMenuVenta.FrmVenta.txtPrecio.Text = precio;
            FrmMenuVenta.FrmVenta.txtCantidad.Focus();
            //this.Close();
        }

        private void dtgProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            envio();
        }

        private void dtgProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                envio();
            }
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void dtgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
