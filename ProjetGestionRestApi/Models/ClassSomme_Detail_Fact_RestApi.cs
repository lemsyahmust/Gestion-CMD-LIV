using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetGestionRestApi.Models
{
    public class ClassSomme_Detail_Fact_RestApi
    {
        public float t { get; set; }

        public ClassSomme_Detail_Fact_RestApi(float som)
        {
            this.t = som;
        }
    }
}