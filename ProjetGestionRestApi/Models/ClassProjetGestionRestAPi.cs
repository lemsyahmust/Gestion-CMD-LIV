using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetGestionRestApi.Models
{
    public class ClassProjetGestionRestAPi
    {
        public int ID_Ville { get; set; }
        public string Nom_Ville { get; set; }

        public ClassProjetGestionRestAPi(int id, string nom)
        {
            ID_Ville = id;
            this.Nom_Ville = nom;
        }
    }
}