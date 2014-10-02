using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace ConsoleApplication1
{
    public bool isOpen
    {
        get
        {
                return SerialComPort.IsOpen;
        }
    }

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
