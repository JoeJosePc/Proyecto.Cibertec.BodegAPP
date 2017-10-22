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
    public class Categoria_:BaseEntity
    {
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public bool Estado { get; set; }

        //Relacion 1:M con tabla Producto_
        public ICollection<Producto_> Producto { get; set; }

        public Categoria_(): base()
        {
            this.Producto = new HashSet<Producto_>();
        }
    }
}
