﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraArchivo
{
    class Program
    {
        public class Clientes
        {
            //Campos
            public string Nom, ciudad;
            public int ID;
            public long Tel;

            public Clientes(string Nom, string ciudad, int ID, long Tel)
            {
                this.Nom = Nom;
                this.ciudad = ciudad;
                this.ID = ID;
                this.Tel = Tel;
            }

            ~Clientes()
            {
                Console.WriteLine("Clase clientes destruida");
            }
        }
        static void Main(string[] args)
        {
            //Variables
            string Nom, ciudad;
            int ID, Registro;
            long Tel;

            StreamWriter sw = new StreamWriter("NombresDeUsuario.txt", true); //Texto de registro de clientes
            //si el archivo no existe lo creara
            //si ya existe, escribira en el

            Console.Write("Dame un nombre con apellidos: ");
            Nom = Convert.ToString(Console.ReadLine());
            Console.Write("Ciudad en la que recide: ");
            ciudad = Convert.ToString(Console.ReadLine());
            Console.Write("Dame el Telefono: ");
            Tel = long.Parse(Console.ReadLine());
            Console.Write("Dame el ID: ");
            ID = int.Parse(Console.ReadLine());

            //Creacion de un objeto
            Clientes C1 = new Clientes(Nom, ciudad, ID, Tel);

            //Uso de streamreader
            StreamReader sr = new StreamReader("NumR.txt");

            //La cantidad de Registros que lea es el numero de registros que escribira
            Registro = int.Parse(sr.ReadLine());
            sr.Close();

            //Es el texto que se escribira despues del texto que ya esta en el archivo
            string[] Lines ={
               "Registro: "+Registro,
               "Nombre: "+C1.Nom
               ,"Ciudad: "+C1.ciudad
               ,"ID: "+C1.ID.ToString()
               ,"\n"
            };

            //Se escribe en el archivo
            foreach (string Line in Lines)
            {
                sw.WriteLine(Line);
            }
            sw.Close();//se debe cerrare el archivo

            //Aumentamos las cantidades de registro
            Registro++;

            //Abrimos un StreamWriter para sobrescribir el texto
            StreamWriter R = new StreamWriter("NumR.txt", false);
            //Sobreescribe en el archivo de textos para saber que cantidad de registros hay
            R.WriteLine(Registro);
            R.Close();
            Console.WriteLine("Escrbiendo en el archivo.....");
            Console.ReadLine();
        }
    }
}
