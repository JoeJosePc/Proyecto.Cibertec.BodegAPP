using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.AccesoDatosBodega.Modelos
{
    /// <summary>
    /// campos: FechaEmision, FechaCancelacion, ProveedorID(FK)
    /// </summary>
    public class OrdenDeCompra_ : BaseEntity
    {
        public DateTime FechaEmision { get; set; }
        public DateTime FechaCancelacion { get; set; }

        [ForeignKey("Proveedor_")]
        public int ProveedorID { get; set; }
        public virtual Proveedor_ Proveedor_ { get; set; }

        //Relacion 1:M con tabla DetalleDeCompra_
        public ICollection<DetalleDeCompra_> DetalleDeCompra {get; set;}

        //Relacion 1:M con tabla DocumentoDeCompra_
        public ICollection<DocumentoDeCompra_> DocumentoDeCompra { get; set; }

        public OrdenDeCompra_():base()
        {
            this.DetalleDeCompra = new HashSet<DetalleDeCompra_>();
            this.DocumentoDeCompra = new HashSet<DocumentoDeCompra_>();
        }

    }
}
