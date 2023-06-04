using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICM
{
    class DomainsExcpetion: ApplicationException
    {
        public DomainsExcpetion(string messagem) :base(messagem)
        {
        }
    }
}
