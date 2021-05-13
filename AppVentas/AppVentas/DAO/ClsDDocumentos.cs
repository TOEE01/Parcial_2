using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppVentas.MODELO;

namespace AppVentas.DAO
{
    class ClsDDocumentos
    {
        public void GuardarDocumento(tb_documento VDocumento)
        {
            try
            {
                using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
                {
                    tb_documento DBDocumento = new tb_documento();
                    DBDocumento.nombreDocumento = VDocumento.nombreDocumento;
                    db.tb_documento.Add(DBDocumento);
                    db.SaveChanges();

                    MessageBox.Show("Documento guardado exitosamente");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
        public void ActualizarDocumento(tb_documento VDocumento)
        {
            try
            {
                using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
                {
                    int actualizar = VDocumento.iDDocumento;
                    tb_documento DBDocumento = db.tb_documento.Where(x => x.iDDocumento == actualizar).Select(x => x).FirstOrDefault();
                    DBDocumento.nombreDocumento = VDocumento.nombreDocumento;
                    db.SaveChanges();
                    MessageBox.Show("Documento actualizado exitosamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
        public void EliminarDocumento(int Id)
        {
            try
            {
                using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
                {
                    int eliminar = Id;
                    tb_documento DBDocumento = db.tb_documento.Where(x => x.iDDocumento == eliminar).Select(x => x).FirstOrDefault();
                    db.tb_documento.Remove(DBDocumento);
                    db.SaveChanges();
                    MessageBox.Show("Documento eliminado exitosamente");
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
