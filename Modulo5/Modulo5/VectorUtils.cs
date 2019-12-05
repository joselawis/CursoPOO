using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo5
{
    public static class VectorUtils
    {
        // Funcion binaria IN <int,int> => OUT <int>
        private static Func<int, int, int> Addition = (i1, i2) => i1 + i2;
        private static Func<int, int, int> Substraction = (i1, i2) => i1 - i2;

        // Suma 2 vectores
        public static Vector SumarVector(this Vector v1, Vector v2)
        {
            if (v1.Dimension != v2.Dimension) throw new ApplicationException("No puedes sumar vectores de distintas dimensiones");

            return new Vector(v1.ToEnumerable().DefaultIfEmpty(0).Zip(v2.ToEnumerable().DefaultIfEmpty(0), Addition).ToArray());
        }

        // Suma una lista de vectores
        public static Vector SumarVectores(this IEnumerable<Vector> vectors)
        {
            return vectors.Aggregate(new Vector(vectors.First().Dimension), (acc, next) => next.SumarVector(acc));
        }

        // Pinta por consola un vector en formato [i1, ... ,iN]
        public static void PrintVector(this Vector vector)
        {
            Console.WriteLine($"[{vector.ToEnumerable().DefaultIfEmpty(0).First()}{vector.ToEnumerable().DefaultIfEmpty(0).Skip(1).Aggregate<int, string>(String.Empty, (acc, i) => acc + "," + i)}]");
        }
    }
}
