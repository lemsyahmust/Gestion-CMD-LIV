using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGestion.tous_class
{
    public class ClassProjetGestion
    {
        public int ID_Ville { get; set; }
        public string Nom_Ville { get; set; }

        public ClassProjetGestion(int id, string nom)
        {
            this.ID_Ville = id;
            this.Nom_Ville = nom;
        }
    }
}
