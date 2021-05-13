using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppVentas.MODELO;

namespace AppVentas.DAO
{
    class ClsDRegistroUsuario
    {
        public void GuardarUsuario(tb_usuario vUsuario)
        {
            try
            {
                using (sistema_ventasEntities db = new sistema_ventasEntities())
                {
                    tb_usuario dbUsuario = new tb_usuario();
                    dbUsuario.email = vUsuario.email;
                    dbUsuario.contrasena = vUsuario.contrasena;

                    db.tb_usuario.Add(dbUsuario);
                    db.SaveChanges();
                    MessageBox.Show("!Usuario registrado con éxito!");
                }
            }
            catch  (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
