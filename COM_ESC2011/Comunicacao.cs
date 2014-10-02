using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
namespace ConsoleApplication1
{
    class Comunicacao
    {
        public Comunicacao()
        {
            SerialCom.PortName = "COM8";
            SerialCom.BaudRate=19200;
            SerialCom.Parity = 0;
            SerialCom.DataBits = 8;
            SerialCom.StopBits = (StopBits) 1;

        //    SerialComPort.ReadTimeout = 500;
            
        }

        private SerialPort SerialCom = new SerialPort();

        public void Comunica()
        {
            try
            {
                SerialCom.Open();
            }
            catch { Console.WriteLine("************Error!!!**********"); }
        }
    }
        
}
