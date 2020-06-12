using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZajednickiElementi;

namespace Writer
{
    public class WriterService : IWriter
    {

        public void OtvaranjeNovogWritera()
        {
            System.Diagnostics.Process.Start("Writer.exe");
        }

        public void SlanjePodataka(string a)
        {
            Console.WriteLine(a);
        }
    }
}