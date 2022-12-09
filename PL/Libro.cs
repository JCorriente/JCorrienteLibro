using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Libro
    {
        public static void Add(ML.Libro libro)
        {
            ML.Libro libro1 = new ML.Libro(); 

            Console.WriteLine("Ingrese los nuevos datos de su libro");
            Console.WriteLine("Nombre");
            libro.Nombre = Console.ReadLine();
           
        

            
        }
    }
}
