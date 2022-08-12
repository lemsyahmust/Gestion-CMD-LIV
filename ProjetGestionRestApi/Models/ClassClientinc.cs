using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetGestionRestApi.Models
{
    public class ClassClientinc
    {
        public int t { get; set; }

        public ClassClientinc(int id)
        {
            this.t = id;
        }
    }
}