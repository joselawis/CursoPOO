﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.Nombre = "Felipe";
            persona1.SalarioMensual = 1000;
            Console.WriteLine($"Nombre: {persona1.Nombre}");
            Console.WriteLine($"Salario mensual: {persona1.SalarioMensual}");
            Console.WriteLine($"Salario anual: {persona1.SalarioAnual}");
            CambiarNombre(persona1);
            Console.WriteLine($"Nombre cambiado: {persona1.Nombre}");

            // Utilizamos ref para pasar un parametro por referencia
            int numero = 5;
            Aumentar(ref numero);
            Console.WriteLine(numero);

        }

        // Se pasa por parametro la referencia del objeto persona
        public static void CambiarNombre(Persona persona)
        {
            persona.Nombre = "Nombre cambiado";
        }

        // Se pasa por parametro el valor, con ref indicamos que se pasa por referencia
        public static void Aumentar(ref int numero)
        {
            numero++;
        }
    }

    public class Persona
    {
        // Constructor por defecto
        public Persona()
        {
            Telefonos = new List<string>();
            Console.WriteLine("Constructor persona");
        }

        // : this() indica que se tiene que ejecutar el constructor por defecto
        public Persona(string nombre, decimal salarioMensual) : this()
        {
            Nombre = nombre;
            SalarioMensual = salarioMensual;
        }

        // Propiedad autoimplementada
        public string Nombre { get; set; }
        public decimal SalarioMensual { get; set; }
        public decimal SalarioAnual {
            get {
                return SalarioMensual * 12;
            }
        }
        public List<string> Telefonos { get; set; }

        // Sobrecarga de metodos
        public void Hablar()
        {

        }

        public void Hablar(string mensaje)
        {

        }
    }
}
