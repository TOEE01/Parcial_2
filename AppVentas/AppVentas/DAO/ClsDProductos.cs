using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppVentas.MODELO;

namespace AppVentas.DAO
{
    class ClsDProductos
    {
        public void GuardarProducto(tb_producto VProducto)
        {
            try
            {
                using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
                {
                    tb_producto DBProducto = new tb_producto();
                    DBProducto.nombreProducto = VProducto.nombreProducto;
                    DBProducto.precioProducto = VProducto.precioProducto;
                    DBProducto.estadoProducto = VProducto.estadoProducto;
                    db.tb_producto.Add(DBProducto);
                    db.SaveChanges();
                    MessageBox.Show("Producto guardado exitosamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
        public void ActualizarProducto(tb_producto VProducto)
        {
            try
            {
                using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
                {
                    int actualizar = VProducto.idProducto;
                    tb_producto DBProducto = db.tb_producto.Where(x => x.idProducto == actualizar).Select(x => x).FirstOrDefault();
                    DBProducto.nombreProducto = VProducto.nombreProducto;
                    DBProducto.precioProducto = VProducto.precioProducto;
                    DBProducto.estadoProducto = VProducto.estadoProducto;
                    db.SaveChanges();
                    MessageBox.Show("Producto actualizado exitosamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
        public void EliminarProducto(int Id)
        {
            try
            {
                using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
                {
                    int eliminar = Id;
                    tb_producto DBProducto = db.tb_producto.Where(x => x.idProducto == eliminar).Select(x => x).FirstOrDefault();
                    db.tb_producto.Remove(DBProducto);
                    db.SaveChanges();
                    MessageBox.Show("Producto eliminado exitosamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }

        }
        public List<tb_producto> MostrarProducto(String filtro)
        {
            List<tb_producto> tb_Productos = new List<tb_producto>();
            using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
            {
                tb_Productos = (from listadoProductos in db.tb_producto
                                where listadoProductos.nombreProducto.Contains(filtro)
                                select listadoProductos).ToList();
            }

            return tb_Productos;
        }


        public List<tb_producto> BuscarProducto(int Codigo)
        {
            List<tb_producto> tb_Productos = new List<tb_producto>();
            using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
            {
                tb_Productos = (from listadoProductos in db.tb_producto
                                where listadoProductos.idProducto == Codigo
                                select listadoProductos).ToList();
            }
            return tb_Productos;
        }
    }
}
