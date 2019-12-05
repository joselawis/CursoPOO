using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo5
{
    class Program
    {
        static void Main(string[] args)
        {
            var vector1 = new Vector(new int[] { 1, 4 });
            var vector2 = new Vector(new int[] { 2, 5 });
            var vector3 = new Vector(new int[] { 1, 2, 3 });

            // Sumamos los vectores y los pintamos
            Vector vectorSuma = vector1.SumarVector(vector2);
            Console.WriteLine($"[{vectorSuma[0]},{vectorSuma[1]}]");

            // Metodo PrintVector para pintar los vectores
            vectorSuma.PrintVector();

            // Sumamos con el operador
            (vector1 + vector2).PrintVector();
            new Vector[] { vector1, vector2, vectorSuma }.SumarVectores().PrintVector();

            new Vector(3).PrintVector();

            Vector vectorSumaError = (vector1 + vector3); // --> Salta Excepcion
        }
    }

    public class Vector
    {
        private int[] Valores { get; set; }

        public int Dimension { get { return Valores.Length; } }

        public Vector(int[] valores)
        {
            Valores = valores;
        }

        public Vector(int dimension)
        {
            Valores = new int[dimension].DefaultIfEmpty(0).ToArray();
        }

        public int this[int i] {
            get { return Valores[i]; }
            set { Valores[i] = value; }
        }

        public IEnumerable<int> ToEnumerable()
        {
            return Valores.AsEnumerable();
        }

        public static Vector operator + (Vector v1, Vector v2)
        {
            return v1.SumarVector(v2);
        }
    }
}
