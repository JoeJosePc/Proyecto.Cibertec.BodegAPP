using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.AccesoDatosBodega.Modelos
{
    /// <summary>
    /// campos: OrdenDeVentaID(FK), DetalleDeProductoID(FK), Cantidad, PrecioVentaUnidad, ImporteDescuento, PrecioVentaTotal
    /// </summary>
    public class DetalleDeVenta_:BaseEntity
    {
        [ForeignKey("OrdenDeVenta_")]
        public int OrdenDeVentaID { get; set; }
        public virtual OrdenDeVenta_ OrdenDeVenta_ { get; set; }

        [ForeignKey("DetalleDeProducto_")]
        public int DetalleDeProductoID { get; set; }
        public virtual DetalleDeProducto_ DetalleDeProducto_ { get; set; }

        public int Cantidad { get; set; }
        public double PrecioVentaUnidad { get; set; }
        public double ImporteDescuento { get; set; }
        public double PrecioVentaTotal { get; set; }
    }
}
