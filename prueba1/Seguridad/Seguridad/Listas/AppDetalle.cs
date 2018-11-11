using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seguridad.Listas
{
   public class AppDetalle
    {
        public int id_Perfil { get; set; }
        public int id_app { get; set; }
        public int create { get; set; }
        public int update { get; set; }
        public int delete { get; set; }
        public AppDetalle() { }

        public AppDetalle(int id, int idApp, int c, int u, int d)
        {
            this.id_Perfil = id;
            this.id_app = idApp;
            this.create = c;
            this.update = u;
            this.delete = d;
        }
    }
}
