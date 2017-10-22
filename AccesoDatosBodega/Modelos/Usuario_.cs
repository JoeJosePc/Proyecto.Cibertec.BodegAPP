using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.AccesoDatosBodega.Modelos
{
    /// <summary>
    /// campos: Usuario, Password, Responsable, nivel, Estado
    /// </summary>
    public class Usuario_
    {
        [Key]
        public string Usuario { get; set; }
        [Required]
        public string Contrasena { get; set; }
        [Required]
        public string Responsable { get; set; }
        [Required]
        public string Nivel { get; set; }
        [Required]
        public bool Estado { get; set; }
        public DateTime FechaDeCreacion { get; set; }
        public DateTime FechaDeUltimaModificacion { get; set; }

        public Usuario_()
        {
            this.Estado = true;
            this.FechaDeCreacion = DateTime.Now;
            this.FechaDeUltimaModificacion = DateTime.Now;
        }
    }
}
