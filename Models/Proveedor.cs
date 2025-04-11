using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Proveedor
    {
        public int ProveedorId { get; set; }
        public int TipoDocumentoId { get; set; }
        public string Documento { get; set; } = "";
        public string RazonSocial { get; set; } = "";
        public string NombreComercial { get; set; } = "";
        public string NombreContacto { get; set; } = "";
        public string ApellidosContacto { get; set; } = "";
        public string Direccion { get; set; } = "";
        public string CodPostal { get; set; } = "";
        public string Provincia { get; set; } = "";
        public string Telefono { get; set; } = "";
        public string Movil { get; set; } = "";
        public string Correo { get; set; } = "";
        public bool Activo { get; set; }
    }
    
}
