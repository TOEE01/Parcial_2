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
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void UltimoCorrelativoDeVenta()
        {
            var consultar = new ClsDVenta();

            int lista = 0;

            foreach (var list in consultar.UltimaVenta()) {
                lista = list.iDVenta;
            }
            lista++;
            txtVenta.Text = lista.ToString();
        }
        private void FrmVenta_Load(object sender, EventArgs e)
        {
            UltimoCorrelativoDeVenta();
            
            ClsDClientes cls = new ClsDClientes();

            cbCliente.DataSource = cls.MostrarCliente();
            cbCliente.DisplayMember = "nombreCliente";
            cbCliente.ValueMember = "iDCliente";

            if (cbCliente.Items.Count > 0)
            {
                cbCliente.SelectedIndex = -1;
            }

            ClsDDocumentos clsD = new ClsDDocumentos();
            cbTipoDocumento.DataSource = clsD.MostrarDocumento();
                cbTipoDocumento.DisplayMember = "nombreDocumento";
                cbTipoDocumento.ValueMember = "iDDocumento";
            if (cbTipoDocumento.Items.Count > 0)
            {
                cbTipoDocumento.SelectedIndex = -1;
            }
                
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmProductos buscar = new FrmProductos();
            buscar.Show();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            try {
                Double precio, cantida, total;
                cantida = Convert.ToDouble(txtCantidad.Text);
                precio = Convert.ToDouble(txtPrecio.Text);

                total = precio * cantida;

                txtTotal.Text = total.ToString();


            }
            catch (Exception ex)
            {
                if (txtCantidad.Text.Equals(""))
                {
                    txtCantidad.Text = "0";
                    txtCantidad.SelectAll();
                }
            }
         }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            Double suma = 0;
            dtgVenta.Rows.Add(txtId.Text, txtNombreProducto.Text,txtPrecio.Text,txtCantidad.Text,txtTotal.Text);
                

            for (int i= 0;i<dtgVenta.Rows.Count; i++)
            {
                String datosAOperarTotal = dtgVenta.Rows[i].Cells[4].Value.ToString();

                Double DatosConvertidos = Convert.ToDouble(datosAOperarTotal);

                //variable de acarreo
                
                suma += DatosConvertidos;

                txtTotalFinal.Text = suma.ToString();
                
                
                txtId.Clear();
                txtNombreProducto.Clear();
                txtPrecio.Clear();
                txtCantidad.Clear();
                txtTotal.Clear();

            }
        }

        private void txtTotalFinal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
