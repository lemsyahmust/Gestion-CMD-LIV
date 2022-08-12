﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetGestionRestApi.Models
{
    public class ClassDetail_Cmd_RestApi
    {
        public int ID_Produit { get; set; }
        public string Nom_Produit { get; set; }
        public string Num_Fact_cmd { get; set; }
        public string Qte_Vendu_cmd { get; set; }
        public int Qte_Stock_cmd { get; set; }
        public string Prix_Vente_cmd { get; set; }
        public string Remise { get; set; }
        public float Total_Montant_cmd { get; set; }

        public ClassDetail_Cmd_RestApi(int id_prd, string nom_prd, string num_fact, string qte_v, int qte_s, string prix_v,string remise,  float montant_tt)
        {
            this.ID_Produit = id_prd;
            this.Nom_Produit = nom_prd;
            this.Num_Fact_cmd = num_fact;
            this.Qte_Vendu_cmd = qte_v;
            this.Qte_Stock_cmd = qte_s;
            this.Prix_Vente_cmd = prix_v;
            this.Remise = remise;
            this.Total_Montant_cmd = montant_tt;

        }
    }
}