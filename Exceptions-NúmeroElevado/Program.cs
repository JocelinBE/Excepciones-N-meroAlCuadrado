using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_NúmeroElevadoAlCuadrado
{
    class Program
    {
        //Programa que recibe un número entero y lo eleva al cuadrado.
        //Se utilizan excepciones para arrojar los posibles errores en la ejecución del programa.
        static void Main(string[] args)
        { //variables auxiliares
            int Número;
            double Resultado;
            try
            { //Captura de datos
                Console.Write("\nDígite un número entero: ");
                Número = Int32.Parse(Console.ReadLine());

                //llamada a la funcion matemática
                Resultado = Math.Pow(Número, 2);

                //despliegue del resultado
                Console.WriteLine("\nEl resultado es: {0}", Resultado);
                Console.Write("\npresione <enter> para continuar."); Console.ReadKey();
            }
            catch (FormatException f)
            {
                Console.WriteLine("\nMensaje del Error: " + f.Message);
                Console.WriteLine("\nRuta del Error: " + f.StackTrace);
                Console.Write("\npresione <enter> para continuar."); Console.ReadKey();
            }
            catch (OverflowException o)
            {
                Console.WriteLine("\n Mensaje del error: " + o.Message);
                Console.WriteLine("\n Ruta del error: " + o.StackTrace);
                Console.WriteLine("\n Teclee <enter> para continuar... "); Console.ReadKey();

            }
            finally
            {
                Console.WriteLine("\n\nEl bloque finally siempre se ejecuta.");
                Console.Write("\nPresione <enter> para Salir del Programa"); Console.ReadKey();
            }
        }

    }
}
