using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGestion.tous_class
{
  public  class Class1Detail_Cmd_Paiement
    {
        public string Num_Fact_cmd { get; set; }
        public string Reglement_cmd { get; set; }
        public string Avance_cmd { get; set; }
        public string Reste_clt { get; set; }


        public Class1Detail_Cmd_Paiement(string num_fact, string regl_cmd, string av_cmd, string rest_cmd)
        {
            this.Num_Fact_cmd = num_fact;
            this.Reglement_cmd = regl_cmd;
            this.Avance_cmd = av_cmd;
            this.Reste_clt = rest_cmd;
        }
    }
}
