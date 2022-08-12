using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetGestionRestApi.Models
{
    public class ClassCmd_CLT_RestApi
    {
        public String Num_Fact_cmd { get; set; }
        public int ID_Clt { get; set; }


        public ClassCmd_CLT_RestApi(String num,int id_clt)
        {
            this.Num_Fact_cmd = num;
            this.ID_Clt = id_clt;
        }
    }
}