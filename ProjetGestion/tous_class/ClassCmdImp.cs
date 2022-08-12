using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGestion.tous_class
{
    public class ClassCmdImp
    {
        public String Num_Fact_cmd { get; set; }
        public DateTime Date_Fct_cmd { get; set; }
        public string Nom_Vendeur { get; set; }


        public ClassCmdImp(String num, DateTime date_fct, string nom_v)
        {
            this.Num_Fact_cmd = num;
            this.Date_Fct_cmd = date_fct;
            this.Nom_Vendeur = nom_v;
        }
    }
}
