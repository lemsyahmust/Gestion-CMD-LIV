using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGestion.tous_class
{
    public class ClassCmd_Clt
    {
        public String Num_Fact_cmd { get; set; }
        public int ID_Clt { get; set; }


        public ClassCmd_Clt(String num, int id_clt)
        {
            this.Num_Fact_cmd = num;
            this.ID_Clt = id_clt;
        }
    }
}
