using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppVentas.MODELO;
using AppVentas.DAO;

namespace AppVentas.VISTA
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
            load();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void load()
        {
            dtgClientes.Rows.Clear();
            using (sistema_ventasEntities db= new sistema_ventasEntities())
            {
                var consulta = ( from a in db.tb_cliente
                                 select a
                    ).ToList();

                foreach (var i in consulta)
                {
                    dtgClientes.Rows.Add(i.iDCliente,i.nombreCliente,i.direccionCliente,i.duiCliente);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if ((txtNombre.Text==""&&txtDUI.Text=="")&&txtDireccion.Text=="")
            {
                MessageBox.Show("¡Datos incompletos: los campos de Nombre, DUI y Dirección son obligatorios!");
            }
            else
            {
                ClsDClientes clsDClientes = new ClsDClientes();
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    tb_cliente cliente = new tb_cliente();
                    cliente.nombreCliente = txtNombre.Text;
                    cliente.direccionCliente = txtDireccion.Text;
                    cliente.duiCliente = txtDUI.Text;
                    clsDClientes.GuardarCliente(cliente);
                    load();
                    limpiar();
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ClsDClientes clsDClientes = new ClsDClientes();
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                tb_cliente cliente = new tb_cliente();
                cliente.nombreCliente = txtNombre.Text;
                cliente.direccionCliente = txtDireccion.Text;
                cliente.duiCliente = txtDUI.Text;
                cliente.iDCliente = Convert.ToInt32(dtgClientes.CurrentRow.Cells[0].Value.ToString());
                clsDClientes.ActualizarCliente(cliente);
                load();
                limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClsDClientes clientes = new ClsDClientes();
            clientes.BorrarCliente(Convert.ToInt32(dtgClientes.CurrentRow.Cells[0].Value.ToString()));
            load();
            limpiar();


        }

        private void limpiar()
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            txtDUI.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDUI_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombre = dtgClientes.CurrentRow.Cells[1].Value.ToString();
            string direccion = dtgClientes.CurrentRow.Cells[2].Value.ToString();
            string dui = dtgClientes.CurrentRow.Cells[3].Value.ToString();

            txtNombre.Text = nombre;
            txtDireccion.Text = direccion;
            txtDUI.Text = dui;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
