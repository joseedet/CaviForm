using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AlmacenDetalle
    {

        public int AlmacenDetalleId { get; set; }
        public int AlmacenId {  get; set; }
        public string ? Direccion { get; set; }
        public string ? CodPOstal { get; set; }
        public string ? Poblacion { get; set; }
        public string ? Provincia { get; set; }
        public string ? Telefono { get; set; }

    }
}
