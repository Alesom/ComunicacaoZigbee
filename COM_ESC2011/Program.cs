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
           // C.LeDadosConfig();
            GerenciaDiretorio Cria = new GerenciaDiretorio();
            DateTime Mes = DateTime.Now;
          /*  Console.WriteLine(Mes.Month);
            Console.WriteLine(Mes.Year);*/

            string Nome = (Mes.Month + "-" + Mes.Year);

           /* while (true)
            {
                C.TransmiteDado (Console.ReadLine()+"\r\n");
            }*/
            C.TransmiteDado("+++\r\n");
            Cria.setPath(@"C:\");
            Cria.setNome(Nome);
            if (!Cria.DirJaExist())
                Cria.Cria();
            Console.ReadLine();
            C.FechaComunicacao();
        }
    }
}
