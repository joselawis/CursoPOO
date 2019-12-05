using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class ClienteDentroDeLibreria
    {
        public void Prueba()
        {
            var clasePublica = new ClasePublicaDePrueba();
            //clasePublica.MetodoPrivado(); ---> ERROR El metodo solo se puede invocar desde la propia clase
            clasePublica.MetodoPublico();
            clasePublica.PropiedadInterna = "INTERNAL";
            clasePublica.PropiedadProtectedInternal = "PROINT";
            var claseInterna = new ClaseInternaDePrueba();

            //clasePublica.PropiedadPrivateProtected = 5; --> ERROR Solo se puede acceder desde la clase o sus hijas
        }
    }

    public class ClasePublicaDePrueba
    {
        public int PropiedadPublica { get; set; }                           // Acceso total
        internal string PropiedadInterna { get; set; }                      // Acceso a nivel de proyecto
        protected int PropiedadProtegida { get; set; }                      // Acceso a nivel de clase y sus hijas (independiente de proyecto)
        protected internal string PropiedadProtectedInternal { get; set; }  // Acceso a nivel de clase y sus hijas y para todos los miembros del proyecto
        private protected int PropiedadPrivateProtected { get; set; }       // Acesso a nivel de clase y sus hijas solo en este proyecto

        // public void MetodoRecibeClaseInterna(ClaseInternaDePrueba claseInterna) --> ERROR ya que hay inconsistencia de accesibilidad


        public void MetodoPublico()
        {
            PropiedadPublica = 1;
            PropiedadInterna = "EE!!";
            PropiedadProtegida = 4;
            PropiedadProtectedInternal = "b";
            PropiedadPrivateProtected = 3;
            MetodoPrivado();
        }

        private void MetodoPrivado()
        {

        }
    }

    public class ClaseDerivada: ClasePublicaDePrueba
    {
        public void Prueba()
        {
            PropiedadPrivateProtected = 1;
        }
    }

    internal class ClaseInternaDePrueba
    {

    }
}
