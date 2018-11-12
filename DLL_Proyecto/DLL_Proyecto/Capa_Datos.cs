using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Data;

namespace DLL_Proyecto
{
    public class Capa_Datos
    {
        static OdbcConnection conector = null;
        OdbcCommand comando;
        OdbcDataReader da;
        OdbcCommand selector;

        public static OdbcConnection conex()
        {

            try
            {
                conector = new OdbcConnection("Driver ={ MySQL ODBC 3.51 Driver }; Dsn=auditoria; UID=root; Pwd=");
                conector.Open();
                //MessageBox.Show("Conexion Exitosa");
            }
            catch (OdbcException e)
            {
                MessageBox.Show("Error al Conectar" + e);
            }
            return conector;
        }

        public void mostrar_dgv(DataGridView sentencia, String consulta, String tabla)
        {
            try
            {
                selector = new OdbcCommand();
                selector.Connection = conector;
                selector.CommandText = consulta;
                DataSet ds = new DataSet();
                OdbcDataAdapter dg = new OdbcDataAdapter(selector);
                dg.Fill(ds, tabla);
                sentencia.DataSource = ds;
                sentencia.DataMember = tabla;
            }
            catch (OdbcException e)
            {
                MessageBox.Show("No se puede conectar a la base de datos dg");
            }
        }

        public void llenar_dvg(DataGridView busqueda, String sentencia, String tabla)
        {
            conex();
            mostrar_dgv(busqueda, sentencia, tabla);
            conex().Close();
        }
    }
}
