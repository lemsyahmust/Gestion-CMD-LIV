using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using ProjetGestionRestApi.Models;

namespace ProjetGestionRestApi.Controllers
{
    public class CommandeCRUDController : ApiController
    {
        // GET: api/CommandeCRUD
        public DataTable Get()
        {

            DataTable d = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-BETDQGE;Initial Catalog=GestionProjet;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("select Max(Num_Fact_cmd) as t from COMMANDE", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                d.Load(dr);
                dr.Close();
                cn.Close();
            }
            return d;
        }

        // GET: api/CommandeCRUD/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CommandeCRUD
        public string Post([FromBody]ClasseCmdImp CI)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-BETDQGE;Initial Catalog=GestionProjet;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("insert into COMMANDE(Num_Fact_cmd,Date_Fct_cmd,Nom_Vendeur) values(" + CI.Num_Fact_cmd + ", '" + CI.Date_Fct_cmd + "', '" + CI.Nom_Vendeur + "')", cn);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
                return "Insertion est réaliser avec succès !!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // PUT: api/CommandeCRUD/5
        public string Put([FromBody]ClassCmd_CLT_RestApi CC)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-BETDQGE;Initial Catalog=GestionProjet;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("update COMMANDE set ID_Clt=" + CC.ID_Clt + " where Num_Fact_cmd=" + CC.Num_Fact_cmd, cn);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
                return "Modification avec succès";
            }
            catch (Exception)
            {
                return "Problème update";
            }
        }

        // DELETE: api/CommandeCRUD/5
        public void Delete(int id)
        {
        }
    }
}
