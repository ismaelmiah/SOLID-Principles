using System;

namespace DIP
{
    public class Monitor
    {
        private IConnector _connector;
        public Monitor(IConnector connector)
        {
            _connector = connector;
        }

        private string _port;

        public void GeneratePort()
        {
            _port = _connector.Port();
        }

        public void StarMonitor()
        {
            Console.WriteLine($"Monitor Start using {_port}");
        }
    }
}