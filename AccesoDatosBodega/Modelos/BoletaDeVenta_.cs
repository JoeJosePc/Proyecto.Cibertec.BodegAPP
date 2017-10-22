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
    /// campos: OrdenDeVentaID(FK), BoletaElectronicaID(FK), NumeroBoleta, FechaEmision, NumeroItem, OperacionGrabada, Igv, ImporteTotal
    /// </summary>
    public class BoletaDeVenta_:BaseEntity
    {
        [ForeignKey("OrdenDeVenta_")]
        public int OrdenDeVentaID { get; set; }
        public virtual OrdenDeVenta_ OrdenDeVenta_ { get; set; }

        [ForeignKey("BoletaElectronica_")]
        public int BoletaElectronicaID { get; set; }
        public virtual BoletaElectronica_ BoletaElectronica_ { get; set; }

        [Required]
        public string NumeroBoleta { get; set; }
        public DateTime FechaEmision { get; set; }
        public int NumeroItem { get; set; }
        public double OperacionGrabada { get; set; }
        public double Igv { get; set; }
        public double ImporteTotal { get; set; }
    }
}
