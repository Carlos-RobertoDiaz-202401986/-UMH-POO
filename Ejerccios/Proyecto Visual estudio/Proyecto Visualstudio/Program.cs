using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace horas_extras
{
    internal class Program
    {
        // Variables de entrada
        static double costoHoraTrabajada;
        static double cantidadHorasTrabajadas;
        static double totalDevengado;

        static void Main(string[] args)
        {
            Console.WriteLine(" CALCULADORA DE SALARIO SEMANAL ");

            LeerDatos();
            CalcularSalario();
            MostrarResultados();

            Console.ReadKey();
        }

        // Método para leer los datos
        static void LeerDatos()
        {
            Console.Write("Costo por hora: L ");
            costoHoraTrabajada = Convert.ToDouble(Console.ReadLine());

            Console.Write("Horas trabajadas: ");
            cantidadHorasTrabajadas = Convert.ToDouble(Console.ReadLine());
        }

        // Método para calcular el salario
        static void CalcularSalario()
        {
            totalDevengado = costoHoraTrabajada * cantidadHorasTrabajadas;
        }

        // Método para mostrar resultados
        static void MostrarResultados()
        {
            Console.WriteLine($"\nCosto por hora: L {costoHoraTrabajada:N2}");
            Console.WriteLine($"Horas trabajadas: {cantidadHorasTrabajadas:N2}");
            Console.WriteLine($"Total devengado: L {totalDevengado:N2}");
        }
    }
}

