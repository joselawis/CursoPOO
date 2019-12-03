using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo2
{
    /*
     * Cuando se debe usar una clase estatica?
     * -Cuando es una funcionalidad invariable
     * -Cuando es una funcionalidad universal
     * -Cuando no es fundamental para la ejecucion
     * */
    public static class UtilidadesDeFechas
    {
        // Para que el metodo sea de extension tiene que pertenecer a una clase estatica y 
        // el primer parametro debe tener el keyword this con el tipo de dato.
        public static int CalcularEdad(this DateTime fechaNacimiento, string param)
        {
            var edad = DateTime.Today.Year - fechaNacimiento.Year;
            var temp = new DateTime(DateTime.Today.Year, fechaNacimiento.Month, fechaNacimiento.Day);

            if(temp > DateTime.Today)
            {
                edad--;
            }

            return edad;
        }
    }

    public static class UtilidadesDeStrings
    {
        // Metodo de extension
        public static int ContarVocales(this string valor)
        {
            if (valor == null)
            {
                throw new ArgumentException("El parametro no puede ser nulo");
            }

            var resultado = 0;
            string vocales = "aeiou";
            valor = valor.ToLower();

            valor.Where(x => vocales.Contains(x))
                .ToList()
                .ForEach(x => resultado++);

            return resultado;
        }
    }
}
