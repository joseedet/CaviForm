﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    public interface ICliPro
    {
        public int TipoDocumento { get; set; }
        public string Documento { get; set; } 
        public string NombreComercial { get; set; } 
        public string NombreContacto { get; set; } 
        public string ApellidosContacto { get; set; } 
        public string Direcion { get; set; } 
        public string CodPostal { get; set; } 
        public string Poblacion { get; set; } 
        public string Provincia { get; set; } 
        public string Telefono { get; set; } 
        public string Movil { get; set; } 
        public string Correo { get; set; } 
        public string Notas { get; set; }
        public bool Activo { get; set; }
    }
}
