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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            load();
        }
        ClsAcceso acceso = new ClsAcceso();
        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            ClsDUsuarios Vusuarios = new ClsDUsuarios();

            if (txtCorreo.Text=="" && txtPass.Text=="")
            {
                MessageBox.Show("Datos inválidos");
            }
            else
            {
                if (acceso.VerificarEmail(txtCorreo.Text) == true)
                {
                    MessageBox.Show("¡El usuario ya ha sido registrado, por favor elija un nuevo nombre de usuario!");
                }
                else
                {
                    using (sistema_ventasEntities db = new sistema_ventasEntities())
                    {
                        tb_usuario usuario = new tb_usuario();
                        usuario.email = txtCorreo.Text;
                        usuario.contrasena = txtPass.Text;
                        Vusuarios.GuardarUsuario(usuario);
                        load();
                    }
                }
            }
        
        }
        private string correoS = "";
        private void btnActualizar_Click(object sender, EventArgs e)
        {

            ClsDUsuarios Vusuarios = new ClsDUsuarios();

            if (txtCorreo.Text == "" && txtPass.Text == "")
            {
                MessageBox.Show("Datos inválidos");
            }
            else
            {

                if (acceso.VerificarPass(txtPassAntigua.Text, correoS) == true)
                {
                    using (sistema_ventasEntities db = new sistema_ventasEntities())
                    {
                        tb_usuario usuario = new tb_usuario();
                        usuario.iDUsuario = Convert.ToInt32(dtgUsuarios.CurrentRow.Cells[0].Value.ToString());
                        usuario.email = txtCorreo.Text;
                        usuario.contrasena = txtPass.Text;
                        Vusuarios.ActualizarUsuario(usuario);
                        load();
                    }

                }
                else
                {
                    MessageBox.Show("¡Contraseña incorrecta!");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                ClsDUsuarios Vusuario = new ClsDUsuarios();
                Vusuario.EliminarUsuario(Convert.ToInt32(dtgUsuarios.CurrentRow.Cells[0].Value.ToString()));
                load();
            }
        }

        private void load()
        {
            dtgUsuarios.Rows.Clear();
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                var consulta = (from a in db.tb_usuario
                                select a).ToList();
                foreach (var i in consulta)
                {
                    dtgUsuarios.Rows.Add(i.iDUsuario,i.email,i.contrasena);
                }
            }
        }

        private void dtgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            correoS = dtgUsuarios.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
