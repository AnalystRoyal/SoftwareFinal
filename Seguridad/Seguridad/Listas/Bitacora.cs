using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seguridad.Listas
{
   public class Bitacora
    {
        public int IDBitacora { get; set; }
        public int IDUsuario { get; set; }
        public string FechaBitacora { get; set; }
        public string HoraBitacora { get; set; }
        public string AccionBitacora { get; set; }
        public string AplicacionBitacora { get; set; }

        public Bitacora() { }

        public Bitacora(int idb, int idu, string fechab, string horab, string accion, string app)
        {
            this.IDBitacora = idb;
            this.IDUsuario = idu;
            this.FechaBitacora = fechab;
            this.HoraBitacora = horab;
            this.AccionBitacora = accion;
            this.AplicacionBitacora = app;
        }
    }
}
