using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPOOSeccion3
{
    public abstract class Animal
    {
        public virtual void HacerRuido()
        {
            Console.WriteLine("Hacer ruido generico");
        }
    }

    public class Perro : Animal
    {
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
