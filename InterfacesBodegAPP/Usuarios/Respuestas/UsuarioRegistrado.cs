using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesBodegAPP.Usuarios.Respuestas
{
    public class UsuarioRegistrado
    {
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Responsable { get; set; }
        public string Nivel { get; set; }
        public bool Estado { get; set; }
    }
}
