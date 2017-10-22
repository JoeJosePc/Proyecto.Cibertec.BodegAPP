using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.AccesoDatosBodega.Modelos
{
    /// <summary>
    /// campos: DetalleDeProductoID(FK), Ingreso, FechaIngreso, Salida, FechaSalida, OrdenDeCompraID(flag), OrdenDeVentaID(flag)
    /// </summary>
    public class Kardex_:BaseEntity
    {
        [ForeignKey("DetalleDeProducto_")]
        public int DetalleDeProductoID { get;  set; }
        public virtual DetalleDeProducto_ DetalleDeProducto_ { get; set; }

        public int Ingreso { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public int Salida { get; set; }
        public DateTime? FechaSalida { get; set; }
        public int OrdenDeCompraID { get; set; }
        public int OrdenDeVentaID { get; set; } 
    }
}
