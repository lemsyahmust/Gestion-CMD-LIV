using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetGestionRestApi.Models
{
    public class ClassAjoutVilleVrai
    {
        public int ID_Ville { get; set; }
        public string Nom_Ville { get; set; }

        public ClassAjoutVilleVrai(int id_v, string nom)
        {
            this.ID_Ville = id_v;
            this.Nom_Ville = nom;
        }
    }
}