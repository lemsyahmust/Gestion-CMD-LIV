using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGestion.tous_class
{
   public class ClassCmd_Prd_Clt
    {
        public int ID_Produit { get; set; }
        public string Nom_Cat { get; set; }
        public string Nom_Produit { get; set; }
        public int Qte_Stock { get; set; }
        public string Prix_Achat { get; set; }
        public string Prix_Vente { get; set; }


        public ClassCmd_Prd_Clt(int id, string nom, String nom_p, int qte_stock, string prix_a, string prix_v)
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
