using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetGestionRestApi.Models
{
    public class Detail_Cmd_Grid_RestApi
    {
        public string ID_Produit { get; set; }
        public string Num_Fact_cmd { get; set; }


        public Detail_Cmd_Grid_RestApi(string id_prd, string num_fact)
        {
            this.ID_Produit = id_prd;
            this.Num_Fact_cmd = num_fact;
        }
    }
}