using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seguridad.Listas;
using System.Data.Odbc;

namespace Seguridad
{
  public  class Funciones
    {
        public static int InsertarPerfil(Perfiles add)
        {
            int retorno = 0;
            OdbcCommand comando = new OdbcCommand(String.Format("INSERT into perfil values('{0}','{1}')", add.id_Perfil, add.descrip_Perfil), Conexion.getDB());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
