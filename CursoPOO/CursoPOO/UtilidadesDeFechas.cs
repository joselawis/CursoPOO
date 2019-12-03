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
        public static int CalcularEdad(DateTime fechaNacimiento)
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
}
