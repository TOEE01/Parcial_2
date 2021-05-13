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
            using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
            {
                var consulta = db.tb_cliente.ToList();
                cbCliente.DataSource = consulta;
                cbCliente.DisplayMember = "nombreCliente";
                cbCliente.ValueMember = "iDCliente";

                //if (cbCliente.Items.Count > 0)
                //{
                //    cbCliente.SelectedIndex = -1;
                //}

                var consultaDoc = db.tb_documento.ToList();
                cbTipoDocumento.DataSource = consultaDoc;
                cbTipoDocumento.DisplayMember = "nombreDocumento";
                cbTipoDocumento.ValueMember = "iDDocumento";
                
            }
        }
    }
}
