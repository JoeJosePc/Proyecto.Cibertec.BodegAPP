using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.AccesoDatosBodega.Modelos
{ 
    /// <summary>
    /// campos: Descripcion, Estado
    /// </summary>
    public class Concepto_:BaseEntity
    {
        [Required]
        public string Descripcion { get; set; }
        public bool Estado { get; set; }

        //Relacion 1:M con Tabla Caja
        public ICollection<Caja_> Caja { get; set; }

        public Concepto_() : base()
        {
            this.Caja = new HashSet<Caja_>();
        }
    }
}
