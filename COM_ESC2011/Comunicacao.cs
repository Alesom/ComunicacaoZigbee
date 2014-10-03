using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
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
