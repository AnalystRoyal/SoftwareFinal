using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seguridad.Listas;
using System.Data.Odbc;
using System.Net;

namespace Seguridad
{
  public  class Funciones
    {
        public static int InsertarPerfil(Perfiles add)
        {
            int retorno = 0;
            try
            {
                OdbcCommand comando = new OdbcCommand(String.Format("INSERT into perfil values('{0}','{1}')", add.id_Perfil, add.descrip_Perfil), Conexion.getDB());
                retorno = comando.ExecuteNonQuery();
                return retorno;
            }
            catch (Exception)
            {

                return retorno;
            }
            
        }

        public static int InsertarApp(Aplicaciones add)
        {
            int retorno = 0;
            try
            {
               OdbcCommand comando = new OdbcCommand(String.Format("INSERT into aplicaciones_encabezado values('{0}','{1}')", add.id_App, add.descrip_App), Conexion.getDB());
                retorno = comando.ExecuteNonQuery();
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
            
        }
        public static List<Aplicaciones> MostarApp ()
        {
            List<Aplicaciones> App = new List<Aplicaciones>();
            OdbcCommand comando = new OdbcCommand(String.Format("Select * from aplicaciones_encabezado;"), Conexion.getDB());
            OdbcDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Aplicaciones api = new Aplicaciones();
                api.id_App = reader.GetInt32(0);
                api.descrip_App = reader.GetString(1);
              App.Add(api);
            }
            return App;
        }
        public static List<Perfiles> MostarPerfiles()
        {
            List<Perfiles> Per = new List<Perfiles>();
            OdbcCommand comando = new OdbcCommand(String.Format("Select * from perfil;"), Conexion.getDB());
            OdbcDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Perfiles perf = new Perfiles();
                perf.id_Perfil= reader.GetInt32(0);
                perf.descrip_Perfil = reader.GetString(1);
                Per.Add(perf);
            }
            return Per;
        }
        public static int InsertarAppDetalle(AppDetalle add)
        {
            int retorno = 0;
            try
            {
                OdbcCommand comando = new OdbcCommand(String.Format("INSERT into aplicaciones_detalle values('{0}','{1}','{2}','{3}','{4}')", add.id_Perfil, add.id_app, add.create, add.update,add.delete), Conexion.getDB());
                retorno = comando.ExecuteNonQuery();
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }

        }

        public static bool IngresoSesion(string usuario, string pswd)
        {
           
                OdbcCommand comando = new OdbcCommand(String.Format("Select * from usuarios where nickname_Usuario = '{0}' and pswd_Usuario ='{1}'", usuario, pswd), Conexion.getDB());
                OdbcDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {

                    return true;
            }else
            {
                return false;
            }
            
        }

        public static int IngresoUsuario(Usuarios add)
        {
            int retorno = 0;
            try
            {
                OdbcCommand comando = new OdbcCommand(String.Format("INSERT into usuarios(nombre_usuario,apellido_usuario,telefono_usuario,correo_usuario,nickname_usuario,pswd_usuario) values('{0}','{1}','{2}','{3}','{4}','{5}')", add.NOMBRE, add.APELLIDO, add.TELEFONO, add.CORREO, add.USUARIO, add.PSWD ), Conexion.getDB());
                retorno = comando.ExecuteNonQuery();
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        public static List<Usuarios> LlenarDgvUsuarios()
        {
            List<Usuarios> usu = new List<Usuarios>();
            OdbcCommand comando = new OdbcCommand(String.Format("Select * from usuarios"), Conexion.getDB());
            OdbcDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Usuarios us = new Usuarios();
                us.ID = Convert.ToInt32(reader.GetString(0));
                us.NOMBRE = reader.GetString(1);
                us.APELLIDO = reader.GetString(2);
                us.TELEFONO = Convert.ToInt32(reader.GetString(3));
                us.CORREO = reader.GetString(4);
                us.USUARIO = reader.GetString(5);
                usu.Add(us);
            }
            return usu;
        }
        public static int IngresoDetalleAsigPerfil(DetalleAsigPerfil add)
        {
            int retorno = 0;
            try
            {
                OdbcCommand comando = new OdbcCommand(String.Format("INSERT into asignacion_perfil values('{0}','{1}')", add.IDUsuario, add.IDPerfil), Conexion.getDB());
                retorno = comando.ExecuteNonQuery();
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        public static List<Perfiles> mostrarAsignacion(int idu)
        {
            List<Perfiles> det = new List<Perfiles>();
            OdbcCommand comando = new OdbcCommand(String.Format("select p.idPerfil, p.descrip_Perfil from perfil p,asignacion_perfil a where a.id_Perfil = p.idPerfil and a.id_Usuario = '{0}'",idu), Conexion.getDB());
            OdbcDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Perfiles per = new Perfiles();
                per.id_Perfil = Convert.ToInt32(reader.GetString(0));
                per.descrip_Perfil = reader.GetString(1);
                det.Add(per);
            }
            return det;
        }
        public static int IngresoDetalleApp(AppDetalle add)
        {
            int retorno = 0;
            try
            {
                OdbcCommand comando = new OdbcCommand(string.Format("insert into aplicaciones_detalle values ('{0}','{1}','{2}','{3}','{4}')",add.id_Perfil,add.id_app,add.create,add.update,add.delete), Conexion.getDB());
                retorno = comando.ExecuteNonQuery();
                return retorno;
            }
            catch (Exception)
            {

                return retorno;
            }

        }
        public static List<Vistaappdetalle> MostrarAsigApp(int per)
        {
            List<Vistaappdetalle> appdet = new List<Vistaappdetalle>();
            OdbcCommand comando = new OdbcCommand(String.Format("select a.idAplicaciones, a.descrip_Aplicacion,d.create, d.update,d.delete from aplicaciones_encabezado a, aplicaciones_detalle d where a.idAplicaciones = d.id_Aplicacion and d.id_Perfil = '{0}';", per), Conexion.getDB());
            OdbcDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Vistaappdetalle app = new Vistaappdetalle();
                app.id_perfil = Convert.ToInt32(reader.GetString(0));
                app.descrip_perfil = reader.GetString(1);
                app.create = Convert.ToInt16( reader.GetString(2));
                app.update = Convert.ToInt16(reader.GetString(3));
                app.delete = Convert.ToInt16(reader.GetString(4));
                appdet.Add(app);
            }
            return appdet;
        }
        public static string obtenerIP()
        {
            string ipr = "";
            IPHostEntry host;

            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    ipr = ip.ToString();
                    return ipr;
                }
            }
            return ipr;
            //MessageBox.Show(Globales.localIP);
        }
        public static void IngresoBitacora(string accion, string app)
        {
            string ip = obtenerIP();
            string fecha = DateTime.Now.ToString("yyyyMMdd");
            string hora = DateTime.Now.ToString("HH:mm:ssss");
            try
            {
                OdbcCommand comando = new OdbcCommand(string.Format("Insert into bitacora(id_Usuario, fecha_bitacora, hora_bitacora, accion_bitacora, aplicacion_bitacora,error_bitacora) values('{0}','{1}','{2}','{3}','{4}','{5}')", Globales.idUsuario, fecha, hora, accion, app, ip), Conexion.getDB());
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public static int ObtenerUsuario(string usuario, string pswd)
        {
            int ret = 0;
            OdbcCommand comando = new OdbcCommand(String.Format("Select * from usuarios where nickname_Usuario = '{0}' and pswd_Usuario ='{1}'", usuario, pswd), Conexion.getDB());
            OdbcDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                ret = Convert.ToInt32(reader.GetString(0));
                return ret;
            }
            else
            {
                return ret;
            }

        }
       public static class Globales
        {
            public static int idUsuario;
        }
    }
}
