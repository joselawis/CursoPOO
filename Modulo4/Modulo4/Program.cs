using Libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            var clasePublica = new ClasePublicaDePrueba();
            clasePublica.MetodoPublico();
            //clasePublica.PropiedadInterna = "INTERNAL" -- > ERROR Solo se puede acceder desde su proyecto
            //var claseInterna = new ClaseInternaDePrueba(); --> ERROR Solo se puede acceder desde su proyecto
            //clasePublica.PropiedadProtegida --> ERROR Solo se puede acceder desde la clase o una derivada
            var claseDerivada = new ClaseDerivada();
        }
    }

    public class ClaseDerivada : ClasePublicaDePrueba
    {
        public void Prueba()
        {
            PropiedadProtegida = 27;
            PropiedadProtectedInternal = "Soy tu hija desde otro proyecto";
            //PropiedadPrivateProtected = 1; --> ERROR No se puede acceder aun siendo derivada ya que esta en otro proyecto
        }
    }
}
