using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;

namespace GTIKANTAR.Helpers
{
    class SeriIletisim
    {
        SerialPort _port;
        SeriIletisim(SerialPort seriPort)
        {
            _port = seriPort;
        }
        private void OpenPort()
        {
            if(!_port.IsOpen)
            {
                _port.Open();
            }
        }
        private void ClosePort()
        {
            if (_port.IsOpen)
            {
                _port.Close();
            }
        }
        string SeriPortOku()
        {
            OpenPort();
            string _data = _port.ReadLine();
            ClosePort();
            return _data;
        }
    }
}
