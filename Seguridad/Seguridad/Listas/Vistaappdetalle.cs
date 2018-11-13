using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seguridad.Listas
{
   public class Vistaappdetalle
    {
        public int id_perfil { get; set; }
        public string descrip_perfil { get; set; }
        public int create { get; set; }
        public int update { get; set; }
        public int delete { get; set; }

        public Vistaappdetalle() {}
        public Vistaappdetalle(int id, string descri,int cr, int up, int del)
        {
            this.id_perfil = id;
            this.descrip_perfil = descri;
            this.create = cr;
            this.update = up;
            this.delete = del;
        }

    }
}
