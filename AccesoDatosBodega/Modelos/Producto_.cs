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
    /// campos: Nombre, StockAnual, StockMinimo, CategoriaID(FK), Estado
    /// </summary>
    public class Producto_:BaseEntity
    {
        [Required]
        public string Nombre { get; set; }
        public int StockAnual { get; set; }
        public int StockMinimo { get; set; }

        [ForeignKey("Categoria_")]
        public int CategoriaID { get; set; }
        public virtual Categoria_ Categoria_ { get; set; }

        public bool Estado { get; set; }

        //Relacion 1:M con tabla DetalleDeProducto_
        public ICollection<DetalleDeProducto_> DetalleDeProducto { get; set; }


        public Producto_() : base()
        {
            this.DetalleDeProducto = new HashSet<DetalleDeProducto_>();
        }
    }
}
