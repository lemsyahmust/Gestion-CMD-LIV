using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetGestionRestApi.Models
{
    public class CategorieincRestApi
    {
        public int t { get; set; }

        public CategorieincRestApi(int id)
        {
            this.t = id;
        }
    }
}