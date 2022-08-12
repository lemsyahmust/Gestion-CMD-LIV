using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetGestionRestApi.Models
{
    public class ClassClientCRUDRestApi
    {

        //ID_Clt, Nom_Clt, Prenom_Clt, Tel_Clt, Email_Clt, ID_Ville

        public int ID_Clt { get; set; }
        public string Nom_Clt { get; set; }
        public string Prenom_Clt { get; set; }
        public string Tel_Clt { get; set; }
        public string Email_Clt { get; set; }
        public int ID_Ville { get; set; }


        public ClassClientCRUDRestApi(int id, string nom, string prenom, string tel, string email, int idville)
        {
            this.ID_Clt = id;
            this.Nom_Clt = nom;
            this.Prenom_Clt = prenom;
            this.Tel_Clt = tel;
            this.Email_Clt = email;
            this.ID_Ville = idville;

        }
    }
}