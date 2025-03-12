using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Validaciones
{
    public class ValidaDNINIE
    {
        //public required string DNI_NIE{ get; set; }


        /// <summary>
        /// Valida DNI,NIE y CIF
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="dnicifnie"></param>
        /// <returns>bool</returns>
        public static bool CheckDniNifCif(int tipo,string dnicifnie)
        {
          
            switch (tipo)
            {
                //DNI
                case 1:
                    if (dnicifnie.Length > 9 || dnicifnie.Length < 9) { return false; }

                    string dniNumeros = dnicifnie.Substring(0, dnicifnie.Length - 1);
                    string dniLetra = dnicifnie.Substring(dnicifnie.Length - 1, 1);

                    var numeroValido = int.TryParse(dniNumeros, out int NumeroDNI);

                    if (!numeroValido) return false;
                    if (CalcularLetraDNI(NumeroDNI) != dniLetra) return false; else return true;

                //NIE
                case 2:

                    return true;
                   
                    

                //CIF
                case 3:
                    return true;
            

                   

                 default:
                    return false;
                 


            }
           
         }



        /// <summary>
        /// Cálculo de la letra DNI,NIE,CIF.
        /// </summary>
        /// <param name="NumeroDNI"></param>
        /// <returns>string o cadena</returns>
        private static string CalcularLetraDNI(int NumeroDNI)
        {

            string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            var mod = NumeroDNI % 23;
            return control[mod];

        }

    }
}
