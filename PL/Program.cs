using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Elige una opcion: ");
                Console.WriteLine("\n1.-Agregar un nuevo Libro: " + "\n2.-Eliminar libro");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Libro.Add();
                        break;
                    case 2:
                        Libro.Delete();
                        break;
                }
                Console.ReadKey();
            } while (opcion != 15);

        }
    }
}
