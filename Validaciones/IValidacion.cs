namespace Validaciones
{
    /// <summary>
    /// Interfaz donde T es una clase.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IValidacion<T> where T : class
    {
        public class GlobalValidations<T> { public static readonly Predicate<T> NotNull = (d) => d != null; };
        public class Validator {           

            public static bool Validate<T> (T data, params Predicate<T>[] validations) =>
        validations
            .ToList()
            .Where(d =>
            {
                return !d(data);
            })
            .Count() == 0;
        }
    }
}
