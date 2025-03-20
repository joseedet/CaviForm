using Models;
using static Validaciones.IValidacion<Models.TipoDocumento>;

namespace Validaciones
{
    public class ValidaTipoDocumento:IValidacion<TipoDocumento>
    {


        public static readonly Predicate<TipoDocumento>[] validations =
      {
            (d) => GlobalValidations<string>.NotNull(d.Descripcion),
            //(d) => GlobalValidations<string>.NotNull(d.Country),
            (d) => d.Descripcion != null && d.Descripcion.Length >=3 && d.Descripcion !="",
            //(d) => d.Country != null && d.Country.Count() < 100,
        };


    }
}
