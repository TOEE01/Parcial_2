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


            ClsDDocumentos clsD = new ClsDDocumentos();
            cbTipoDocumento.DataSource = clsD.MostrarDocumento();
                cbTipoDocumento.DisplayMember = "nombreDocumento";
                cbTipoDocumento.ValueMember = "iDDocumento";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmProductos buscar = new FrmProductos();
            buscar.Show();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }
        void calcular()
        {
            try
            {
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
                    txtCantidad.Text = "1";
                    txtCantidad.SelectAll();
                }
            }
        }
        void calculartotal()
        {
             dtgVenta.Rows.Add(txtId.Text, txtNombreProducto.Text,txtPrecio.Text,txtCantidad.Text,txtTotal.Text);
            Double suma = 0;  
            for (int i = 0; i < dtgVenta.Rows.Count; i++)
            {
                String datosAOperarTotal = dtgVenta.Rows[i].Cells[4].Value.ToString();

                Double DatosConvertidos = Convert.ToDouble(datosAOperarTotal);

                suma += DatosConvertidos;

                txtTotalFinal.Text = suma.ToString();
                limpiar();

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            calcular();
            calculartotal();
            dtgVenta.Refresh();
            dtgVenta.ClearSelection();
            int last = dtgVenta.Rows.Count - 1;
            dtgVenta.FirstDisplayedScrollingRowIndex = last;
            dtgVenta.Rows[last].Selected = true;
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBucarProducto.Text.Equals(""))
            {
                if (e.KeyChar == 13)
                {
                   
                    btnBuscar.PerformClick();
                    e.Handled = true;
                    
                }

            }
            else
            {
                if (e.KeyChar == 13)
                {
                    ClsDProductos prod = new ClsDProductos();
                    var busqueda = prod.BuscarProducto(Convert.ToInt32(txtBucarProducto.Text));
                    
                    if (busqueda.Count < 1)
                    {
                        MessageBox.Show("El codigo no existe");
                        txtBucarProducto.Text = "";
                    }

                    foreach (var iteracion in busqueda)
                    {
                        txtId.Text = iteracion.idProducto.ToString();
                        txtNombreProducto.Text = iteracion.nombreProducto;
                        txtPrecio.Text = iteracion.precioProducto.ToString();
                        txtCantidad.Text = "1";
                        txtCantidad.Focus();
                        txtBucarProducto.Text = "";
                    }
                }
            }
            
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                btnAgregar.PerformClick();
                txtBucarProducto.Focus();
            }
            else
            {
                e.Handled = true;
                ClsDProductos cls = new ClsDProductos();
                var busqueda = cls.BuscarProducto(Convert.ToInt32(txtBucarProducto.Text));
                

                foreach (var  iteracion in busqueda)
                {
                    txtId.Text = iteracion.idProducto.ToString();
                    txtNombreProducto.Text = iteracion.nombreProducto;
                    txtPrecio.Text = iteracion.precioProducto.ToString();
                  
                    
                }
            }
        }

        private void txtBucarProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGuardarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                ClsDVenta ventas = new ClsDVenta();
                tb_venta venta = new tb_venta();
                venta.iDDocumento = Convert.ToInt32(cbTipoDocumento.SelectedValue.ToString());
                venta.iDCliente = Convert.ToInt32(cbCliente.SelectedValue.ToString());
                venta.iDUsuario = 1;
                venta.totalVenta = Convert.ToDecimal(txtTotalFinal.Text);
                venta.fecha = Convert.ToDateTime(dtpFecha.Text);
                ventas.save(venta);
                ClsDDetalle clsD = new ClsDDetalle();
                tb_detalleVenta tbDetalle = new tb_detalleVenta();
                foreach (DataGridViewRow dtgV in dtgVenta.Rows)
                {
                    tbDetalle.iDVenta = Convert.ToInt32(txtVenta.Text);
                    tbDetalle.iDProducto = Convert.ToInt32(dtgV.Cells[0].Value.ToString());
                    tbDetalle.cantidad = Convert.ToInt32(dtgV.Cells[3].Value.ToString());
                    tbDetalle.precio = Convert.ToDecimal(dtgV.Cells[2].Value.ToString());
                    tbDetalle.total = Convert.ToDecimal(dtgV.Cells[4].Value.ToString());
                }

                UltimoCorrelativoDeVenta();
                dtgVenta.Rows.Clear();
                txtTotalFinal.Text = "";
                MessageBox.Show("Save");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
        void limpiar()
        {
            txtId.Clear();
            txtNombreProducto.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtTotal.Clear();
        }

        private void dtgVenta_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //va a detectar cuando nosotros eliminamos una linea del datagridview
            calculartotal();
        }
    }
   
}
