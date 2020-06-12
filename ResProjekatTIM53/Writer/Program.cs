using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZajednickiElementi;

namespace Writer
{
    class Program
    {

        static void Main(string[] args)
        {

            string adresa = "net.tcp://localhost:4000/IWriter";

            ChannelFactory<IWriter> writerFactory = new ChannelFactory<IWriter>(new NetTcpBinding(), new EndpointAddress(adresa));

            IWriter proxy = writerFactory.CreateChannel();
            
            Console.WriteLine("unesite string:");
           
                string a = Console.ReadLine();

            

            while (true)
            {
                proxy.SlanjePodataka(a);
                Thread.Sleep(2000);
            }
            
            
        }
        
    }
}
