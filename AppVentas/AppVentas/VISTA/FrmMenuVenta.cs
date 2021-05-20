using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVentas.VISTA
{
    public partial class FrmMenuVenta : Form
    {
        public FrmMenuVenta()
        {
            InitializeComponent();
        }

        public static FrmVenta FrmVenta = new FrmVenta();
        private void frmVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVenta.Show();
        }
    }
}
