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
            Console.WriteLine("\nNome do Cliente:");
            string nome = Console.ReadLine();
            Console.WriteLine(String.Format("\nO cliente {0} foi cadastrado com sucesso", nome));
            Console.ReadLine();
        }
    }
}
