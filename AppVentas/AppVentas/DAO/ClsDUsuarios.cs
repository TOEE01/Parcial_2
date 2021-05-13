using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppVentas.MODELO;

namespace AppVentas.DAO
{
    class ClsDUsuarios
    {
        public void GuardarUsuario(tb_usuario Vusuario)
        {
            try
            {
                using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
                {
                    tb_usuario Busuario = new tb_usuario();
                    Busuario.email = Vusuario.email;
                    Busuario.contrasena = Vusuario.contrasena;
                    db.tb_usuario.Add(Busuario);
                    db.SaveChanges();
                    MessageBox.Show("Usuario guardado existosamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
        public void ActualizarUsuario(tb_usuario Vusuario)
        {
            try
            {
                using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
                {
                    int actualizar = Vusuario.iDUsuario;
                    tb_usuario Busuario = db.tb_usuario.Where(x => x.iDUsuario == actualizar).Select(x => x).FirstOrDefault();

                    Busuario.email = Vusuario.email;
                    Busuario.contrasena = Vusuario.contrasena;
                    db.SaveChanges();

                    MessageBox.Show("Usuario actualizado existosamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
        public void EliminarUsuario(int Id)
        {
            try
            {
                using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
                {
                    int eliminar = Id;
                    tb_usuario Busuario = db.tb_usuario.Where(x => x.iDUsuario == eliminar).Select(x => x).FirstOrDefault();
                    db.tb_usuario.Remove(Busuario);
                    db.SaveChanges();

                    MessageBox.Show("Usuario eliminado existosamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
    }
}
