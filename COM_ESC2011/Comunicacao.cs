using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.IO;
using System.Threading;

namespace ConsoleApplication1
{
    class Comunicacao
    {
        private SerialPort SerialCom = new SerialPort();

        private string Buffer = string.Empty;

        public Comunicacao()
        {
            SerialCom.PortName = "COM7";
            SerialCom.BaudRate=19200;
            SerialCom.Parity = 0;
            SerialCom.DataBits = 8;
            SerialCom.StopBits = (StopBits) 1;

        //    SerialComPort.ReadTimeout = 500;
            SerialCom.DataReceived += new SerialDataReceivedEventHandler(SerialCom_DataReceived);
        }


        public void LeDadosConfig()
        {
            try
            {
                StreamReader rk = new StreamReader(@"D:\Meus Documentos\Documents\Projetos\2014\Projetos Programação\Protocolo de comunicação Zigbee\COM_ESC2011\config.txt");
                while (!rk.EndOfStream)
                {
                    string linha = rk.ReadLine();
                    Console.WriteLine(linha);
                    Thread.Sleep(200);
                    TransmiteDado(linha + "\r");
                    Thread.Sleep(200);
                }
                rk.Close();
            }
            catch { Console.WriteLine("Não foi possível Ler/Escrever no arquivo especificado!"); }
        }


        void SerialCom_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //throw new NotImplementedException();
            Buffer = SerialCom.ReadExisting();
            Console.WriteLine(Buffer);
        }


        public void ComunicacaoOpen()
        {
            try
            {
                SerialCom.Open();
            }
            catch { Console.WriteLine("************Error!!!**********"); }
            if (SerialCom.IsOpen)
            {
                Console.WriteLine("Conexão!");
            }
            else
            {
                Console.WriteLine("Sem conexão!");
            }
        }

        public void TransmiteDado(string Dado)
        {
            if (SerialCom.IsOpen)
            {
                SerialCom.Write(Dado);
            }
            else
            {
                Console.WriteLine("A porta esta fechada!");
            }
        }

        public void FechaComunicacao()
        {
            SerialCom.Close();
        }

    }
        
}
