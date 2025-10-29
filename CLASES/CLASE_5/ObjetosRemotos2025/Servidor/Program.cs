using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;


namespace Servidor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TicketServer();
            Console.ReadLine();
        }

        static void TicketServer()
        {
            Console.WriteLine("Ticket Server started...");
            TcpChannel tcpChannel = new TcpChannel(9998);
            ChannelServices.RegisterChannel(tcpChannel);
            Type commonInterfaceType = typeof(MovieTicket);
            RemotingConfiguration.RegisterWellKnownServiceType(commonInterfaceType,
            "MovieTicketBooking", WellKnownObjectMode.Singleton);
            System.Console.WriteLine("Press ENTER to quitnn");
            System.Console.ReadLine();
        }
    }
    public interface MovieTicketInterface
    {
        string GetTicketStatus(string stringToPrint);
    }
    public class MovieTicket : MarshalByRefObject, MovieTicketInterface
    {
        public string GetTicketStatus(string stringToPrint)
        {
            string returnStatus = "Ticket Confirmed";
            Console.WriteLine("Enquiry for {0}", stringToPrint);
            Console.WriteLine("Sending back status: {0}", returnStatus);
            return returnStatus;
        }
    }
}
