using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ZajednickiElementi
{
    [ServiceContract]
   public interface IWriter
    {
        [OperationContract]
        void SlanjePodataka(string a);

        [OperationContract]
        void OtvaranjeNovogWritera();

    }
}
