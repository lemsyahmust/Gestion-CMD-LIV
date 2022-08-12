using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetGestionRestApi.Models
{
    public class ClassVilleAjoutRestApi
    {
        public int t { get; set; }

        public ClassVilleAjoutRestApi(int id)
        {
            this.t = id;           
        }
    }
}