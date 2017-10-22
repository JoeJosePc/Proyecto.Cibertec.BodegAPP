using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.AccesoDatosBodega.Modelos
{
    /// <summary>
    /// campos: CodigoBarra, ProductoID(FK), CantidadAcumulada, PrecioPonderadoUnidad, PrecioVentaUnidad, ImporteDescuento
    /// </summary>
    public class DetalleDeProducto_:BaseEntity
    {
        [Required]
        public string CodigoBarra { get; set; }

        [ForeignKey("Producto_")]
        public int ProductoID { get; set; }
        public virtual Producto_ Producto_ { get; set; }

        public int CantidadAcumulada { get; set; }
        public double PrecioPonderadoUnidad { get; set; }
        public double PrecioVentaUnidad { get; set; }
        public double ImporteDescuento { get; set; }

        //Relacion 1:M con tabla DetalleDeCompra_
        public ICollection<DetalleDeCompra_> DetalleDeCompra { get; set; }

        //Relacion 1:M con tabla Kardex_
        public ICollection<Kardex_> Kardex { get; set; }

        //Relacion 1:M con tabla DetalleDeVenta_
        public ICollection<DetalleDeVenta_> DetalleDeVenta { get; set; }

        public DetalleDeProducto_() : base()
        {
            this.DetalleDeCompra = new HashSet<DetalleDeCompra_>();
            this.Kardex = new HashSet<Kardex_>();
            this.DetalleDeVenta = new HashSet<DetalleDeVenta_>();
        }
    }
}
