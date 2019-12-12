using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace Csharp_verbinding
{
    class receiveData
    {
        
        private void startConnection()
        {
            bool connectedToArduino = false;
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                while connectedToArduino == false)
                {
                    SerialPort poort = new SerialPort(port, 9600, Parity.None, 8, StopBits.One);
                    poort.Open();
                    poort.Write(">test<");
                    if (poort.Read())
                        
            }
            }
        }
    }
}
