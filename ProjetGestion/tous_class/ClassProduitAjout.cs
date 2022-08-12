using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGestion.tous_class
{
   public class ClassProduitAjout
    {
        public int ID_Produit { get; set; }
        public int ID_Cat { get; set; }
        public string Nom_Produit { get; set; }
        public int Qte_Stock { get; set; }
        public string Prix_Achat { get; set; }
        public string Prix_Vente { get; set; }


        public ClassProduitAjout(int id, int id_cat, String nom_p, int qte_stock, string prix_a, string prix_v)
        {
            this.ID_Produit = id;
            this.ID_Cat = id_cat;
            this.Nom_Produit = nom_p;
            this.Qte_Stock = qte_stock;
            this.Prix_Achat = prix_a;
            this.Prix_Vente = prix_v;
        }
    }
}
