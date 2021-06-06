using AppVentas.MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVentas.DAO
{
    class ClsDDetalle
    {
        public void Guardardetalleventa(tb_detalleVenta dtalle)
        {
            using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
            {
                tb_detalleVenta detalleVenta = new tb_detalleVenta();
                detalleVenta.iDVenta = dtalle.iDVenta;
                detalleVenta.iDProducto = dtalle.iDProducto;
                detalleVenta.cantidad = dtalle.cantidad;
                detalleVenta.precio = dtalle.precio;
                detalleVenta.total = dtalle.total;
                db.tb_detalleVenta.Add(detalleVenta);
                db.SaveChanges();

            }
        }
    }
}
