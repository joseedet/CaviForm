namespace Models
{
    public class Almacen
    {
   
        public int AlmacenId { get; set; }       
        public string Descripcion { get; set; } = "";
        public string Direccion { get; set; } = "";
        public string CodPOstal { get; set; } = "";
        public string Poblacion { get; set; } = "";
        public string Provincia { get; set; } = "";
        public string Telefono { get; set; } = "";
        public bool Activo { get; set; } = true;

    }
}
