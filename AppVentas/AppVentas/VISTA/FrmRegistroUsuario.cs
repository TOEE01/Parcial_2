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
    public partial class FrmRegistroUsuario : Form
    {
        public FrmRegistroUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                ClsAcceso acceso = new ClsAcceso();

                if (acceso.VerificarEmail(txtUser.Text)==true)
                {
                    MessageBox.Show("¡El usuario ya ha sido registrado, por favor elija un nuevo nombre de usuario!");
                }
                else
                {
                    if (txtPass1.Text == txtPass2.Text)
                    {
                        tb_usuario usuario = new tb_usuario();
                        usuario.email = txtUser.Text;
                        usuario.contrasena = txtPass2.Text;

                        ClsDRegistroUsuario registroUsuario = new ClsDRegistroUsuario();
                        registroUsuario.GuardarUsuario(usuario);
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden, por favor verifique las contraseñas ingresadas");
                    }
                }
            }
        }
    }
}
