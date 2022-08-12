using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetGestionRestApi.Models
{
    public class ClassProduitCRUDRestApi
    {
        //ID_Produit, Nom_Cat, Nom_Produit, Qte_Stock, Prix_Achat, Prix_Vente
        public int ID_Produit { get; set; }
        public string Nom_Cat { get; set; }
        public string Nom_Produit { get; set; }
        public int Qte_Stock { get; set; }
        public string Prix_Achat { get; set; }
        public string Prix_Vente { get; set; }


        public ClassProduitCRUDRestApi (int id, string nom,String nom_p, int qte_stock, string prix_a, string prix_v)
        {
            this.ID_Produit = id;
            this.Nom_Cat = nom;
            this.Nom_Produit = nom_p;
            this.Qte_Stock = qte_stock;
            this.Prix_Achat = prix_a;
            this.Prix_Vente = prix_v;
        }
    }
}