using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.AccesoDatosBodega.Modelos
{
    /// <summary>
    /// campos: ClienteID(FK), FechaEmision, FechaCancelacion
    /// </summary>
    public class OrdenDeVenta_:BaseEntity
    {
        [ForeignKey("Cliente_")]
        public int ClienteID { get; set; }
        public virtual Cliente_ Cliente_ { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaCancelacion { get; set; }

        //Relacion 1:M con tabla BoletaDeVenta_
        public ICollection<BoletaDeVenta_> BoletaDeVenta { get; set; }

        //Relacion 1:M con tabla DetalleDeVenta_
        public ICollection<DetalleDeVenta_> DetalleDeVenta { get; set; }

        public OrdenDeVenta_() : base()
        {
            this.BoletaDeVenta = new HashSet<BoletaDeVenta_>();
            this.DetalleDeVenta = new HashSet<DetalleDeVenta_>();
        }
    }
}
