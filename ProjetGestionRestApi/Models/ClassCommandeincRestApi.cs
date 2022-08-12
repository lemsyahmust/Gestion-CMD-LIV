using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetGestionRestApi.Models
{
    public class ClassCommandeincRestApi
    {
        public int t { get; set; }

        public ClassCommandeincRestApi(int id)
        {
            this.t = id;
        }
    }
}