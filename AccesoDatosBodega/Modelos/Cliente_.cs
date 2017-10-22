using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.AccesoDatosBodega.Modelos
{
    /// <summary>
    /// campos: Nombre, Apellido, FechaNacimiento, Dni, Estado
    /// </summary>
    public class Cliente_:BaseEntity
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        public string Dni { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public bool Estado { get; set; }

        //Relacion 1:M con tabla OrdenDeVenta_
        public ICollection<OrdenDeVenta_> OrdenDeVenta { get; set; }

        public Cliente_() : base()
        {
            this.OrdenDeVenta = new HashSet<OrdenDeVenta_>();
        }
    }
}
