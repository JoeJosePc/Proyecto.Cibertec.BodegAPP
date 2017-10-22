using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.AccesoDatosBodega.Modelos
{
    /// <summary>
    /// campos: NumeralBoleta, CorrelativoBoleta, CorrelativoFin, FechaInicio, FechaFin, Estado
    /// </summary>
    public class BoletaElectronica_:BaseEntity
    {
        [Required]
        public string NumeralBoleta { get; set; }
        public int CorrelativoBoleta { get; set; }
        [Required]
        public int CorrelativoFin { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        [Required]
        public bool Estado { get; set; }

        //Relacion 1:M con tabla BoletaDeVenta_
        public ICollection<BoletaDeVenta_> BoletaDeVenta { get; set; }

        public BoletaElectronica_() : base()
        {
            this.BoletaDeVenta = new HashSet<BoletaDeVenta_>();
        }
    }
}
