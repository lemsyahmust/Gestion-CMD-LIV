using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGestion.tous_class
{
   public class ClassCategorieCRUD
    {
        public int ID_Cat { get; set; }
        public string Nom_Cat { get; set; }

        public ClassCategorieCRUD(int id, string nom)
        {
            ID_Cat = id;
            this.Nom_Cat = nom;
        }
    }
}
