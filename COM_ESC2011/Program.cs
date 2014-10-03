using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    static class Program
    {
        static void Main()
        {
            Comunicacao C = new Comunicacao();
            C.ComunicacaoOpen();
            while (true)
            {
                C.TransmiteDado (Console.ReadLine()+"\r\n");
            }
            C.TransmiteDado("+++\r\n");
            Console.ReadLine();
            C.FechaComunicacao();
        }
    }
}
