using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Libro
    {
        public static void Add()
        {
            ML.Libro libro = new ML.Libro(); 

            Console.WriteLine("Ingrese los nuevos datos de su libro");
            Console.WriteLine("Nombre");
            libro.Nombre = Console.ReadLine();
            Console.WriteLine("IdAutor");
            libro.Autor = new ML.Autor();
            libro.Autor.IdAutor = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero de Paginas");
            libro.NumeroPaginas =int.Parse( Console.ReadLine());
            Console.WriteLine("Fecha de Publicacion");
            libro.FechaPublicacion = Console.ReadLine();
            Console.WriteLine("Id Editorial");
            libro.Editorial = new ML.Editorial();
            libro.Editorial.IdEditorial = int.Parse(Console.ReadLine());
            Console.WriteLine("Edicion");
            libro.Edicion = Console.ReadLine();
            Console.WriteLine("Id Genero");
            libro.Genero = new ML.Genero();
            libro.Genero.IdGenero = int.Parse(Console.ReadLine());

            ML.Result result = BL.Libro.Add(libro);//enviamos el objeto con informacion 

            if (result.Correct)
            {
                Console.WriteLine("Mensaje: " + result.Message);
                Console.ReadLine();
            }

        }
    }
}
