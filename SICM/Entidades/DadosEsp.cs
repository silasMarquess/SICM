using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICM.Entidades
{
   public class DadosEsp
    {
        public DateTime DataBatismal { get; set; }
        public string LocalBatismo { get; set; }

        public DadosEsp(DateTime dataBatismal, string localBatismo)
        {
            DataBatismal = dataBatismal;
            LocalBatismo = localBatismo;
        }
    }
}
