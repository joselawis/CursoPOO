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
            ejemplo2Abstract();
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
            ProcesarAnimal(perro);
            ProcesarAnimal(new Gato());
        }
        
        private static void ejemplo3Virtual()
        {

        }
        // Utilizamos el polimorfismo para lanzar un metodo abstracto heredado y se ejecuta en funcion del tipo concreto
        static void ProcesarAnimal(Animal animal)
        {
            animal.HacerRuido();
        }
    }
}
