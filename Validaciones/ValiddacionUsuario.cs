using System.Text.RegularExpressions;
using Models;
using static Validaciones.IValidacion<Models.Usuario>;

namespace Validaciones
{
    public class ValiddacionUsuario:IValidacion<Usuario>
    {
        
        public static readonly Predicate<Usuario>[] validations =
       {
            (d) => GlobalValidations<string>.NotNull(d.UsuarioId),          
            (d) => d.UsuarioId != null && d.UsuarioId.Length >3 && d.UsuarioId !="",
            (d)=> GlobalValidations<string>.NotNull(d.Nombre),
            (d)=>d.Nombre !=null && d.Nombre.Length >3 && d.Nombre!="",
            (d)=>GlobalValidations<string>.NotNull(d.Apellidos),
            (d)=>d.Apellidos!=null && d.Apellidos.Length >8 && d.Apellidos!="", 
            (d)=>GlobalValidations<string>.NotNull(d.Contrasenya),
            (d)=>d.Contrasenya!=null && d.Contrasenya.Length>8 && d.Contrasenya!="",
            (d)=>GlobalValidations<string>.NotNull(d.RepetirContra),
            (d)=>d.RepetirContra!=null && d.RepetirContra.Length>8 && d.RepetirContra.Length<10 && d.RepetirContra!="" && d.RepetirContra==d.Contrasenya,
            (d)=>GlobalValidations<DateTime>.NotNull(d.FechaModificacionContra),
            (d)=>GlobalValidations<int>.NotNull(d.RolId),
            (d)=>GlobalValidations<string>.NotNull(d.Correo),
            (d)=>d.Correo!=null &&  Regex.IsMatch(d.Correo, @"^[^\s@]+@[^\s@]+\.[^\s@]+$")



            //(d) => d.Country != null && d.Country.Count() < 100,
        };

    }
}
