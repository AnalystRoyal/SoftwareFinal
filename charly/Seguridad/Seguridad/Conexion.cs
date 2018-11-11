using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;

namespace Seguridad
{
    class Conexion
    {
        public static OdbcConnection getDB()
        {

            OdbcConnection cnx = new OdbcConnection(Properties.Settings.Default.ruta);
            cnx.Open();
            return cnx;
        }
        public static bool comprobacionConexion()
        {
            try
            {
                getDB();
                return true;
            }
            catch (OdbcException)
            {
                return false;
            }
        }
    }
}
