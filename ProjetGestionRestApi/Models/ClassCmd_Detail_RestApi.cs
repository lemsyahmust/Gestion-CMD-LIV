using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetGestionRestApi.Models
{
    public class ClassCmd_Detail_RestApi
    {
        public int ID_Produit { get; set; }
        public string Num_Fact_cmd { get; set; }
        public string Qte_Vendu_cmd { get; set; }
        public int Qte_Stock_cmd { get; set; }
        public string Prix_Vente_cmd { get; set; }
        public string Remise { get; set; }
        public float Total_Montant_cmd { get; set; }

        public ClassCmd_Detail_RestApi(int id_prd, string n_fact_cmd, string qte_v, int qte_s, string prix_v, string re, float montant_tt)
        {
            this.ID_Produit = id_prd;
            this.Num_Fact_cmd = n_fact_cmd;
            this.Qte_Vendu_cmd = qte_v;
            this.Qte_Stock_cmd = qte_s;
            this.Prix_Vente_cmd = prix_v;
            this.Remise = re;
            this.Total_Montant_cmd = montant_tt;
        }
    }
}