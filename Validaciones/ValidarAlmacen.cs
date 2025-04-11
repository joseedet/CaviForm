using Models;
using static Validaciones.IValidacion<Models.Almacen>;

namespace Validaciones
{
    /// <summary>
    /// Clase Validar almacen, heredada de la interfaz IValidacion<T>
    /// </summary>
    public class ValidarAlmacen:IValidacion<Almacen>
    {
   
        public static readonly Predicate<Almacen>[] validations =
       {
            (d) => GlobalValidations<string>.NotNull(d.Descripcion),
      
            (d) => d.Descripcion != null && d.Descripcion.Length >3 && d.Descripcion !="",
            (d) => GlobalValidations<string>.NotNull(d.Direccion),
            (d) => d.Direccion != null && d.Direccion.Length >3 && d.Direccion !="",
        
            (d)=>GlobalValidations<string>.NotNull(d.Poblacion),
            (d)=> d.Poblacion !=null && d.Poblacion.Length >2 && d.Direccion !="",
            (d)=>GlobalValidations<string>.NotNull(d.CodPOstal),
            (d)=>d.CodPOstal !=null && d.CodPOstal.Length<5 && d.CodPOstal.Length>4 && d.CodPOstal !="",
            (d)=>GlobalValidations<string>.NotNull(d.Provincia),
            (d)=>d.Provincia !=null && d.Provincia.Length >4 && d.Provincia.Length<50 && d.Provincia !="",
            (d)=>GlobalValidations<string>.NotNull(d.Telefono),
            (d)=>d.Telefono !=null && d.Telefono.Length > 8 && d.Telefono.Length<10 && d.Telefono!=""     
            
          
        };


    }

        
    

    
}
