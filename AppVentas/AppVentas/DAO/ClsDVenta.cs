using AppVentas.MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVentas.DAO
{
    class ClsDVenta
    {
        public List<tb_venta> UltimaVenta()
        {
            List<tb_venta> consultarUlVenta = new List<tb_venta>();
            using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
            {
                consultarUlVenta = db.tb_venta.ToList();
            }

                return consultarUlVenta;
        }
        public void save(tb_venta ventas)
        {
            using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
            {

                tb_venta veta = new tb_venta();
                veta.iDDocumento = ventas.iDDocumento;
                veta.iDCliente = ventas.iDCliente;
                veta.iDUsuario = ventas.iDUsuario;
                veta.totalVenta = ventas.totalVenta;
                veta.fecha = ventas.fecha;
                db.tb_venta.Add(veta);

                db.SaveChanges();

            }
        }
    }
    
}
