using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo3
{
    class Program
    {
        static void Main(String[] args)
        {
            Persona persona = new Persona();
            Producto producto = new Producto();
            producto.Id = 3;
            Console.WriteLine("Hello World");
        }
    }

    public class Entidad
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }

    public class Persona: Entidad
    {
        public string Nombre { get; set; }
    }

    public class Producto: Entidad
    {
        public string Descripcion { get; set; }
        public int Precio { get; set; }
    }
}
