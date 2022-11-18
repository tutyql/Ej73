using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej73
{
    class Program
    {
        static void Main(string[] args)
        {
            string Cad;

            Queue colastring = new Queue();

            Console.WriteLine("ingrese la cadena a agregar a la cola:");

            Cad = Console.ReadLine();


            while (Cad != string.Empty)
            {
                colastring.Enqueue(Cad);
                Console.WriteLine("Ingrese próxima cadena:");
                Cad = Console.ReadLine();
            }

            while (colastring.Count > 0)
            {
                
                string cadena = (string) colastring.Dequeue();
                Console.WriteLine(cadena);
            }

           

            Console.ReadKey();

        }
    }
}
