using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPOOSeccion3
{
    class Program
    {
        static void Main(String[] args)
        {
            ejemplo5();
        }

        private static void ejemplo1Herencia()
        {
            Persona persona = new Persona();
            Producto producto = new Producto();
            producto.Id = 3;
            Console.WriteLine("Hello World");
        }

        private static void ejemplo2Abstract()
        {
            Animal perro = new Perro();
            Animal.ProcesarAnimal(perro);
            Animal.ProcesarAnimal(new Gato());
        }
        
        private static void ejemplo3Virtual()
        {
            Animal.ProcesarAnimal(new Perro());
            Animal.ProcesarAnimal(new Tortuga());
        }

        private static void ejemplo4Constructor()
        {
            // Por defecto se ejecuta el constructor default del padre y despues el del hijo
            Animal perro = new Perro("Thor");
        }
        
        private static void ejemplo5()
        {
            LoggerBase.ProbarLogger(new LoggerConsola());
            LoggerBase.ProbarLogger(new LoggerArchivo());
        }        
    }
}
