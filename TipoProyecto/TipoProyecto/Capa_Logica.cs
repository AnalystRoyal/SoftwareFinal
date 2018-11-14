using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Data;

namespace TipoProyecto
{
    public class Capa_Logica
    {
        public static OdbcCommand comando;
        public static OdbcDataReader lector;
        OdbcDataAdapter da;
        DataTable dt;
        DataRow dr;

        public void LlenaCombobox(ComboBox Cmb, String Mensaje, String query, String CampoNombre, String CampoCodigo)
        {
            Capa_Datos.conex();

            comando = new OdbcCommand(query, Capa_Datos.conex());
            da = new OdbcDataAdapter(comando);
            dt = new DataTable();
            da.Fill(dt);

            dr = dt.NewRow();
            dr[CampoNombre] = Mensaje;
            dt.Rows.InsertAt(dr, 0);

            Cmb.ValueMember = CampoCodigo;
            Cmb.DisplayMember = CampoNombre;
            Cmb.DataSource = dt;

            Capa_Datos.conex().Close();
        }

        public String EjecutarQuery(String Query)
        {
            try
            {
                Capa_Datos.conex();

                comando = new OdbcCommand();
                comando.Connection = Capa_Datos.conex();

                comando.CommandText = Query;

                comando.ExecuteNonQuery();

                return "No Hubo Error";
            }
            catch (OdbcException ex)
            {
                return ex.Message;
            }
        }

        public void ObtieneEnfoque(int codigo, TextBox Nombre, TextBox Descripcion)
        {
            Capa_Datos.conex();

            String query_select = "SELECT Nombre, Descripcion FROM ENFOQUE WHERE idEnfoque = " + codigo;

            comando = new OdbcCommand(query_select, Capa_Datos.conex());
            lector = comando.ExecuteReader();

            if (lector.Read() == true)
            {
                Nombre.Text = lector["Nombre"].ToString();
                Descripcion.Text = lector["Descripcion"].ToString();
            }
            else
            {
                MessageBox.Show("No se encuentra registrado en la base de datos");
            }
        }

        public void ObtieneMetodologia(int codigo, TextBox Nombre, TextBox Descripcion)
        {
            Capa_Datos.conex();

            String query_select = "SELECT Nombre, Descripcion FROM METODOLOGIAS WHERE idMetodologias = " + codigo;

            comando = new OdbcCommand(query_select, Capa_Datos.conex());
            lector = comando.ExecuteReader();

            if (lector.Read() == true)
            {
                Nombre.Text = lector["Nombre"].ToString();
                Descripcion.Text = lector["Descripcion"].ToString();
            }
            else
            {
                MessageBox.Show("No se encuentra registrado en la base de datos");
            }
        }

        public void ObtieneTipoProyecto(int codigo, TextBox Nombre, TextBox Descripcion, ComboBox Enfoque, ComboBox Metodologia, Label CodigoEnfoque, Label CodigoMetodologia)
        {
            Capa_Datos.conex();

            String query_select = "SELECT tipoproyecto.Nombre AS TNombre, tipoproyecto.Descripcion AS TProyecto, tipoproyecto.Enfoque_idEnfoque AS CodEnfoque, tipoproyecto.Metodologias_idMetodologias AS CodMeto, enfoque.Nombre AS ENombre metodologias.Nombre AS MNombre FROM TIPOPROYECTO, ENFOQUE, METODOLOGIAS WHERE tipoproyecto.Enfoque_idEnfoque = enfoque.idEnfoque AND tipoproyecto.Metodologias_idMetodologias = metodologias.idMetodologias AND idtipoProyecto = " + codigo;

            comando = new OdbcCommand(query_select, Capa_Datos.conex());
            lector = comando.ExecuteReader();

            if (lector.Read() == true)
            {
                Nombre.Text = lector["TNombre"].ToString();
                Descripcion.Text = lector["TProyecto"].ToString();
                Enfoque.Text = lector["ENombre"].ToString();
                Metodologia.Text = lector["MNombre"].ToString();
                CodigoEnfoque.Text = lector["CodEnfoque"].ToString();
                CodigoMetodologia.Text = lector["CodMeto"].ToString();
            }
            else
            {
                MessageBox.Show("No se encuentra registrado en la base de datos");
            }
        }
    }
}
