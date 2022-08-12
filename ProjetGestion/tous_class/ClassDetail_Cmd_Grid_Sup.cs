using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGestion.tous_class
{
   public class ClassDetail_Cmd_Grid_Sup
    {
        public string ID_Produit { get; set; }
        public string Num_Fact_cmd { get; set; }


        public ClassDetail_Cmd_Grid_Sup(string id_prd, string num_fact)
        {
            this.ID_Produit = id_prd;
            this.Num_Fact_cmd = num_fact;
        }
    }
}
