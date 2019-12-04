using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPOOSeccion3
{
    public abstract class Animal
    {
        public Animal()
        {
            Console.WriteLine("Instancio un animal");
        }

        public Animal(string name)
        {
            Console.WriteLine($"Instancio un animal de nombre {name}");
        }

        public virtual void HacerRuido()
        {
            Console.WriteLine("Hacer ruido generico");
        }
    }

    public class Perro : Animal
    {
        public Perro()
        {
            Console.WriteLine("Instancio un perro");
        }

        // Si queremos ejecutar un constructor del padre concreto hay que indicarlo con base
        public Perro(string name): base(name)
        {
            Console.WriteLine($"Instancio un perro de nombre {name}");
        }

        public override void HacerRuido()
        {
            Console.WriteLine("Guau!!!!");
        }
    }

    public class Gato : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Miau!!!!");
        }
    }

    public class Tortuga: Animal
    {
        // Al no sobreescribir el metodo virtual HacerRuido se ejecutara el default
    }
}
