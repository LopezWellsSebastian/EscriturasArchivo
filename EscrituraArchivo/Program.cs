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
            string Nom;
            StreamWriter sw = new StreamWriter("Ejemplo.txt", true);
            //si el archivo no existe lo creara
            //si ya existe, escribira en el

            Console.Write("Dame un nombre con apellidos: ");
            Nom = Convert.ToString(Console.ReadLine());

            string[] Lines ={
                Nom

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
