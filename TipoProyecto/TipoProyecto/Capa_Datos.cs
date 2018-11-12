using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.Odbc;
using System.Windows.Forms;


namespace TipoProyecto
{
    public class Capa_Datos
    {
        static OdbcConnection conector = null;
        OdbcDataReader da;
        OdbcCommand selector;
        OdbcDataReader lector;

        public static OdbcConnection conex()
        {

            try
            {
                conector = new OdbcConnection("Driver ={ MySQL ODBC 3.51 Driver }; Dsn=sis; UID=root; Pwd=");
                conector.Open();
                //MessageBox.Show("Conexion Exitosa");
            }
            catch (OdbcException e)
            {
                MessageBox.Show("Error al Conectar" + e);
            }
            return conector;
        }

        
    }
}
