using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetGestionRestApi.Models
{
    public class ClassProduitincRestApi
    {
        public int t { get; set; }

        public ClassProduitincRestApi(int id)
        {
            this.t = id;
        }
    }
}