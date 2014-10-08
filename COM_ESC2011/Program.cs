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
            GerenciaDiretorio CriaPastaDoMes = new GerenciaDiretorio();
            GerenciaDiretorio CriaDiretorioSANICK = new GerenciaDiretorio();
            CriaDiretorioSANICK.setNome("SANICK");
            CriaDiretorioSANICK.setPath(@"C:\");


            if (!CriaDiretorioSANICK.DirJaExist())
                CriaDiretorioSANICK.Cria();


            DateTime Mes = DateTime.Now;

            CriaPastaDoMes.setPath(@"C:\SANICK");
            CriaPastaDoMes.setNome(Mes.Month + "-" + Mes.Year);
            if (!CriaPastaDoMes.DirJaExist())
                CriaPastaDoMes.Cria();

            Console.ReadLine();
            C.FechaComunicacao();
        }
    }
}
