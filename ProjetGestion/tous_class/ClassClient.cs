using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGestion.tous_class
{
    public class ClassClient
    {
        public int ID_Clt { get; set; }
        public string Nom_Clt { get; set; }
        public string Prenom_Clt { get; set; }
        public string Tel_Clt { get; set; }
        public string Email_Clt { get; set; }
        public string Nom_Ville { get; set; }


        public ClassClient(int id, string nom, string prenom, string tel, string email, string nomville)
        {
            this.ID_Clt = id;
            this.Nom_Clt = nom;
            this.Prenom_Clt = prenom;
            this.Tel_Clt = tel;
            this.Email_Clt = email;
            this.Nom_Ville = nomville;

        }
    }
}
