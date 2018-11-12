using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seguridad.Listas
{
  public  class Ingreso
    {
      public  string usuario { get; set; }
       public  string pswd { get; set; }

      public Ingreso() { }

        public Ingreso(string usuario, string pswd)
        {
            this.usuario = usuario;
            this.pswd = pswd;
        } 
    }
}
