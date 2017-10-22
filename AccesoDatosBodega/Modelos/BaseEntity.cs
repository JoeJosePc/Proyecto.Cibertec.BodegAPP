using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.AccesoDatosBodega.Modelos
{
    /// <summary>
    /// Campos: ID (Tipo Identity), FechaDeCreacion
    /// </summary>
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime FechaDeCreacion { get; set; }
        public DateTime FechaDeUltimaModificacion { get; set; }

        public BaseEntity()
        {
            this.FechaDeCreacion = DateTime.Now;
            this.FechaDeUltimaModificacion = DateTime.Now;
        }
    }
}
