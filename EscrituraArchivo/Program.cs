using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraArchivo
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("Ejemplo.txt");
            //si el archivo no existe lo creara
            //si ya existe, escribira en el

            string[] Lines ={
                "Esta n la informacion de la primera linea",
                "Esta es la segunda linea",
                "Fin del tetxto"
            };
            foreach (string Line in Lines)
            {
                sw.WriteLine(Line);
            }
            sw.Close();//se debe cerrare el archivo

            Console.WriteLine("Escrbiendo en el archivo.....");
            Console.ReadLine();
        }
    }
}
