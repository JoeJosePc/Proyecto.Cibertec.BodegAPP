using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.AccesoDatosBodega.Modelos
{
    /// <summary>
    /// campos: ConceptoID(FK), SaldoActual, FechaIngreso, SaldoIngreso, OrdenDeVenta, FechaEgreso, SaldoEgreso, OrdenDeCompra, SaldoFinal
    /// </summary>
    public class Caja_:BaseEntity
    {
        [ForeignKey("Concepto_")]
        public int ConceptoID { get; set; }
        public virtual Concepto_ Concepto_ { get; set; }

        public double SaldoActual { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public double SaldoIngreso { get; set; }
        public int OrdenDeVenta { get; set; }
        public DateTime? FechaEgreso { get; set; }
        public double SaldoEgreso { get; set; }
        public int OrdenDeCompra { get; set; }
        public double SaldoFinal { get; set; }
    }
}
