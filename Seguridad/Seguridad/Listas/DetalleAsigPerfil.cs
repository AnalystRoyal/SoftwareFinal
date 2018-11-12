using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seguridad.Listas
{
     public class DetalleAsigPerfil
    {
        public int IDUsuario { get; set; }
        public int IDPerfil { get; set; }

        public DetalleAsigPerfil() { }

        public DetalleAsigPerfil(int idu, int idp)
        {
            this.IDPerfil = idu;
            this.IDUsuario = idp;
        }
    }
}
