using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPOOSeccion3
{
    public abstract class Animal
    {
        public abstract void HacerRuido();
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
}
