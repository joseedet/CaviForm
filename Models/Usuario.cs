using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Usuario
    {
        public string UsuarioId { get; set; } = "";
        public string Nombre { get; set; }= "";
        public string Apellidos { get; set; } = "";
        public string Contrasenya { get; set; } = "";
        public DateOnly FechaModificacionContra { get; set; }
        public int RolId { get; set; }
        public string Correo { get; set; } = "";

    }
}
