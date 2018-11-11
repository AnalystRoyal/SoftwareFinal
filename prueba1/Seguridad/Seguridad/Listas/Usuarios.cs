using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seguridad.Listas
{
  public  class Usuarios
    {
        public int ID { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public int TELEFONO { get; set; }
        public string CORREO { get; set; }
        public string USUARIO { get; set; }
        public string PSWD { get; set; }

        public Usuarios() { }

        public Usuarios(int id, string nom, string ape, int tel, string correo, string usu, string pswd)
        {
            this.ID = id;
            this.NOMBRE = nom;
            this.APELLIDO = ape;
            this.TELEFONO = tel;
            this.CORREO = correo;
            this.USUARIO = usu;
            this.PSWD = pswd;
        }
    }
}
