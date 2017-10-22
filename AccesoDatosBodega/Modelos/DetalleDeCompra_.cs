using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.AccesoDatosBodega.Modelos
{
    /// <summary>
    /// campos: OrdenDeCompraID(FK), CodigoDeBarra(FK), Cantidad, PrecioUnitario, PrecioTotal
    /// </summary>
    public class DetalleDeCompra_:BaseEntity
    {
        [ForeignKey("OrdenDeCompra_")]
        public int OrdenDeCompraID { get; set; }
        public virtual OrdenDeCompra_ OrdenDeCompra_ { get; set; }

        [ForeignKey("DetalleDeProducto_")]
        public int DetalleDeProductoID { get; set; }
        public virtual DetalleDeProducto_ DetalleDeProducto_ { get; set; }

        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }
        public double PrecioTotal { get; set; }
    }
}
