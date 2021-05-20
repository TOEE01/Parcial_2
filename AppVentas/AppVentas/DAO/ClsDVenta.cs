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

    }
}
