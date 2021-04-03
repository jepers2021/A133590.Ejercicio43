using System;
using System.Collections.Generic;

namespace A133590.Ejercicio43
{
    class Program
    {
        static double validarIngreso(string ingreso)
        {
            double numero;
            while (!Double.TryParse(ingreso, out numero))
            {
                Console.Write("Ingreso inválido, intente nuevamente: ");
                ingreso = Console.ReadLine();
            }

            return numero;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 43");
            List<double> lista = new List<double>();
            double numero;
            Console.Write("Por favor, ingrese un número, ingrese -1 para terminar: ");
            while( (numero = validarIngreso(Console.ReadLine())) != -1 )
            {
                lista.Add(numero);
                Console.Write("Por favor, ingrese un número, ingrese -1 para terminar: ");
            }

            double suma = 0, minimo = Double.MaxValue, maximo = Double.MinValue;

            foreach(double elemento in lista)
            {
                suma += elemento;
                minimo = Math.Min(minimo, elemento);
                maximo = Math.Max(maximo, elemento);
            }

            if(lista.Count == 0)
            {
                Console.WriteLine("Lista vacía.");
            }
            else
            {
                Console.WriteLine($"Máximo: {maximo}");
                Console.WriteLine($"Minimo: {minimo}");
                Console.WriteLine($"Suma: {suma}");
                Console.WriteLine($"Promedio: {suma/lista.Count}");
            }

            Console.WriteLine("Presione cualquier tecla para continuar..");
            Console.ReadKey();
        }
    }
}
