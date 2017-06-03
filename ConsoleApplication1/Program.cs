using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario;
            bool aut = false;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Ingrese el usuario");
                usuario = Console.ReadLine();

                if (usuario == "admin")
                {
                    aut = true;

                    break;
                }

            }


            if (aut == true)

                Console.WriteLine("eres admin");

            else
                Console.WriteLine("no eres dmin");

            Console.ReadLine();
        }
    }
}
