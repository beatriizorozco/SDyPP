using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cliente arrancado.");

            TcpChannel tcpChannel = new TcpChannel();
            ChannelServices.RegisterChannel(tcpChannel);
            Type requiredType = typeof(MovieTicketInterface);
            MovieTicketInterface remoteObject = (MovieTicketInterface)Activator.GetObject(requiredType, "tcp://localhost:9998/MovieTicketBooking");
            Console.WriteLine(remoteObject.GetTicketStatus("Ticket No: 3344"));
            Console.ReadLine();
        }
        public interface MovieTicketInterface
        {
            string GetTicketStatus(string stringToPrint);
        }
    }
}
