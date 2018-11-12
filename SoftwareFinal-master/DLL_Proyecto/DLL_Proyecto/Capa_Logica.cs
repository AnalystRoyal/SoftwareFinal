using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace DLL_Proyecto
{
    public class Capa_Logica
    {
        OdbcCommand comando;
        OdbcDataReader lector;

        public void buscar(TextBox name)
        {

            string sentencia = "SELECT MAX(idProyecto) AS ID FROM proyecto";

            comando = new OdbcCommand(sentencia, Capa_Datos.conex());
            Capa_Datos.conex();

            lector = comando.ExecuteReader();

            if (lector.Read() == true)
            {
                name.Text = lector["ID"].ToString();
            }
        }
    }
}
