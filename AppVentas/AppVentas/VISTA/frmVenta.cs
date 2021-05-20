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

        private void FrmVenta_Load(object sender, EventArgs e)
        {
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
    }
}
