using Models;
using static Validaciones.IValidacion<Models.Almacen>;

namespace Validaciones
{
    public class ValidarAlmacen:IValidacion<Almacen>
    {
        public static readonly Predicate<Almacen>[] validations =
       {
            (d) => GlobalValidations<string>.NotNull(d.Descripcion),
            //(d) => GlobalValidations<string>.NotNull(d.Country),
            (d) => d.Descripcion != null && d.Descripcion.Length >3 && d.Descripcion !="",
            
            //(d) => d.Country != null && d.Country.Count() < 100,
        };


    }

        
    

    
}
