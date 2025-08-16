using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {

        static void Main(string[] args)

        {

            string nombre;
            string apellido;

            nombre = "Carlos Roberto";
            apellido = "Diaz";

            int numeroEntero = 5;
            double numeroDecimal = 2.5;
            double suma = 0;
            double resta = 0;
            double multiplicacion = 0;
            double division = 0;


            suma = numeroEntero + numeroDecimal;
            resta = numeroEntero - numeroDecimal;
            multiplicacion = numeroEntero * numeroDecimal;
            division = numeroEntero / numeroDecimal;

            double div1 = 5 / 2;
            double div2 = 5.0 / 2.0;
            double div3 = 5.0 / 2.0;

            Console.WriteLine($"Resultados {div1} {div2} {div3} ");


            /*Console.WriteLine(" Nombre completo: " + nombre + " " + apellido);

           Console.WriteLine($" Nombre completo: {nombre} {apellido}" );   
            */

            Console.WriteLine($"Resultado de la suma es: {suma} ");
            Console.WriteLine($"Resultado de la resta es: {resta} ");
            Console.WriteLine($"Resultado de la multiplicacion es: {multiplicacion} ");
            Console.WriteLine($"Resultado de la division es: {division} ");


            Console.ReadLine();

        }
    }
}
