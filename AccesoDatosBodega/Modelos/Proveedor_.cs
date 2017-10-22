using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.AccesoDatosBodega.Modelos
{
    /// <summary>
    /// Campos: Ruc, RazonSocial, ContactoVenta, TelefonoVenta, Direccion, Estado
    /// </summary>
    public class Proveedor_:BaseEntity
    {
        public string Ruc { get; set; }
        [Required]
        public string RazonSocial { get; set; }
        public string ContactoVenta { get; set; }
        public string TelefonoVenta { get; set; }
        public string Direccion { get; set; }
        public bool Estado { get; set; }

        //Relacion 1:M con tabla OrdenDeCompra_
        public ICollection<OrdenDeCompra_> OrdenDeCompra { get; set; }

        public Proveedor_():base()
        {
            this.OrdenDeCompra = new HashSet<OrdenDeCompra_>();
        }
    }
}
