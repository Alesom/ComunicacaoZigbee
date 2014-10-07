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
            if (C.IsComu())
                C.LeDadosConfig();
            GerenciaDiretorio Cria = new GerenciaDiretorio();
            DateTime Mes = DateTime.Now;

            //string Nome = (Mes.Month + "-" + Mes.Year);

           /* while (true)
            {
                C.TransmiteDado (Console.ReadLine()+"\r\n");
            }*/

            Cria.setPath(@"C:\");
            Cria.setNome(Mes.Month + "-" + Mes.Year);
            if (!Cria.DirJaExist())
                Cria.Cria();
            Console.ReadLine();
            C.FechaComunicacao();
        }
    }
}
