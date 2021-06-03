using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppVentas.MODELO;

namespace AppVentas.DAO
{
    class ClsDClientes
    {
        public void GuardarCliente(tb_cliente vCliente)
        {
            using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
            {
                tb_cliente dbCliente = new tb_cliente();
                dbCliente.nombreCliente = vCliente.nombreCliente;
                dbCliente.direccionCliente = vCliente.direccionCliente;
                dbCliente.duiCliente = vCliente.duiCliente;

                db.tb_cliente.Add(dbCliente);
                db.SaveChanges();
                MessageBox.Show("¡Nuevo cliente agregado exitosamente!");
            }

        }
        public void ActualizarCliente(tb_cliente vCliente)
        {
            try
            {
                using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
                {
                    int actualizar = vCliente.iDCliente;                                       
                    tb_cliente dbCliente = db.tb_cliente.Where(x => x.iDCliente == actualizar).Select(x => x).FirstOrDefault();
                    dbCliente.nombreCliente = vCliente.nombreCliente;
                    dbCliente.direccionCliente = vCliente.direccionCliente;
                    dbCliente.duiCliente = vCliente.duiCliente;
                    db.SaveChanges();
                    MessageBox.Show("¡Información del cliente actualizada exitosamente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void BorrarCliente(int Id)
        {
            try
            {
                using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
                {
                    int idBorrar = Id;
                    tb_cliente cliente = db.tb_cliente.Where(x => x.iDCliente == idBorrar).Select(x => x).FirstOrDefault();
                    db.tb_cliente.Remove(cliente);
                    db.SaveChanges();
                    MessageBox.Show("¡Cliente eliminado con éxito!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
        public List<tb_cliente> MostrarCliente()
        {
            List<tb_cliente> tb_Clientes = new List<tb_cliente>();
            using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
            {
                tb_Clientes = db.tb_cliente.ToList();
            }
                return tb_Clientes;
        }
    }
}
