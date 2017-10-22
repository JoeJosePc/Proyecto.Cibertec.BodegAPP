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
    public class Documento_:BaseEntity
    {
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public bool Estado { get; set; }

        //Relacion 1:M con tabla DocumentoDeCompra_
        public ICollection<DocumentoDeCompra_> DocumentoDeCompra { get; set; }

        public Documento_() : base()
        {
            this.DocumentoDeCompra = new HashSet<DocumentoDeCompra_>();
        }
    }
}
