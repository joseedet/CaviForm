using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaviForm
{
    public class Estado
    {
        private bool Guardar{ get; set; }
        private bool Nuevo { get; set; }
        private bool Modificar{ get; set; }
        private bool Deshacer{ get; set; }
        private bool Eliminar { get; set; }
    }
}
