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
using AppVentas.VISTA;

namespace AppVentas
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void btbIniciarSecion_Click(object sender, EventArgs e)
        {
            FrmPrincipal usuarioIngresado = new FrmPrincipal();
            string user = txtUser.Text;
            //usuarioIngresado.lblUsuarioIngresado.Text = user;
            ClsAcceso acce = new ClsAcceso();

            Boolean valor = acce.Acceso(txtUser.Text, txtPass.Text);

            if (valor == true)
            {
                MessageBox.Show("Bienvenido");
                FrmPrincipal principal = new FrmPrincipal();
                this.Visible = false;
                principal.Show();
                

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistroUsuario registroUsuario = new FrmRegistroUsuario();
            registroUsuario.ShowDialog();
        }
    }
}
