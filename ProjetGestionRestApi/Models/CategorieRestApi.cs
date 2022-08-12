using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetGestionRestApi.Models
{
    public class CategorieRestApi
    {
        public int ID_Cat { get; set; }
        public string Nom_Cat { get; set; }

        public CategorieRestApi(int id, string nom)
        {
            ID_Cat = id;
            this.Nom_Cat = nom;
        }
    }
}