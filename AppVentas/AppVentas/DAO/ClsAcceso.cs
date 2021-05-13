using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppVentas.MODELO;

namespace AppVentas.DAO
{
    class ClsAcceso
    {
        //acceso a BDD
        public Boolean Acceso(String usuario, String pass)
        {
            Boolean variableAcceso = false;
            //traer la conexio a la BDD
            using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
            {
                var consulta = from user in db.tb_usuario
                               where user.email == usuario && user.contrasena == pass
                               select user;
                if (consulta.Count()>0)
                {
                    variableAcceso = true;
                }
            }

            return variableAcceso;
        }
        //verificar si el email ya ha sido registrado
        public Boolean VerificarEmail(String usuario)
        {
            Boolean variableAcceso = false;
            //traer la conexio a la BDD
            using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
            {
                var consulta = from user in db.tb_usuario
                               where user.email == usuario
                               select user;
                if (consulta.Count() > 0)
                {
                    variableAcceso = true;
                }
            }

            return variableAcceso;
        }
        public Boolean VerificarPass(String pass, string correo)
        {
            Boolean variableAcceso = false;
            //traer la conexio a la BDD
            using (sistema_ventasEntities1 db = new sistema_ventasEntities1())
            {
                var consulta = from user in db.tb_usuario
                               where user.contrasena == pass && user.email == correo
                               select user;
                if (consulta.Count() > 0)
                {
                    variableAcceso = true;
                }
            }

            return variableAcceso;
        }
    }
}
