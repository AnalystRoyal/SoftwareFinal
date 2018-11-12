using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seguridad.Listas
{
   public class Aplicaciones
    {
        public int id_App { get; set; }
        public string descrip_App { get; set; }

        public Aplicaciones() { }

        public Aplicaciones(int id, string desc)
        {
            this.id_App = id;
            this.descrip_App = desc;
        }
    }
}
