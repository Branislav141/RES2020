using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Writer;
using ZajednickiElementi;

namespace ReplicatorSender
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string adresa = "net.tcp://localhost:4000/IWriter";

            ServiceHost svc = new ServiceHost(typeof(WriterService));
            svc.AddServiceEndpoint(typeof(IWriter),
            new NetTcpBinding(),
            new Uri(adresa));
            svc.Open();
            Console.WriteLine("started");
            Console.ReadLine();
            svc.Close();
        }
    }
}
