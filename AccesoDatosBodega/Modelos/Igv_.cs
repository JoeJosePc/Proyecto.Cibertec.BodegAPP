using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.AccesoDatosBodega.Modelos
{
    /// <summary>
    /// campos: Importe, FechaFin, Estado
    /// </summary>
    public class Igv_:BaseEntity
    {
        public double Importe { get; set; }
        public DateTime? FechaFin { get; set; }
        public bool Estado { get; set; }
    }
}
