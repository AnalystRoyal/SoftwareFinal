using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seguridad.Listas
{
   public class Perfiles
    {
        public int id_Perfil { get; set; }
        public string descrip_Perfil { get; set; }

        public Perfiles(){}

        public Perfiles(int id, string desc)
        {
            this.id_Perfil = id;
            this.descrip_Perfil = desc;
        }
    }
}
