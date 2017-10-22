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
    /// campos: DocumentoID(FK), OrdenDeCompraID(FK), NumeroDocumento, FechaEmision, NumeroItem, OperacionGrabada, Igv, ImporteTotal
    /// </summary>
    public class DocumentoDeCompra_:BaseEntity
    {
        [ForeignKey("Documento_")]
        public int  DocumentoID { get; set; }
        public virtual Documento_ Documento_ { get; set; }

        [ForeignKey("OrdenDeCompra_")]
        public int OrdenDeCompraID { get; set; }
        public virtual OrdenDeCompra_ OrdenDeCompra_ { get; set; }

        [Required]
        public string NumeroDocumento { get; set; }

        [Required]
        public DateTime FechaEmision { get; set; }

        [Required]
        public int NumeroItem { get; set; }

        [Required]
        public double OperacionGrabada { get; set; }

        [Required]
        public double Igv { get; set; }

        [Required]
        public double ImporteTotal { get; set; }
    }
}
