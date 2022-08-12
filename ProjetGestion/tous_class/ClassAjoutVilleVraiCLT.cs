using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGestion.tous_class
{
    class ClassAjoutVilleVraiCLT
    {
        public int ID_Ville { get; set; }
        public string Nom_Ville { get; set; }

        public ClassAjoutVilleVraiCLT(int id_v, string nom)
        {
            this.ID_Ville = id_v;
            this.Nom_Ville = nom;
        }
    }
}
