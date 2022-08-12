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
    public class Somme_Detail_FactController : ApiController
    {
        // GET: api/Somme_Detail_Fact
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Somme_Detail_Fact/5
        public DataTable Get(int id)
        {
            DataTable d = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-BETDQGE;Initial Catalog=GestionProjet;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("select SUM(Total_Montant_cmd) as t from DETAIL_COMMANDE where Num_Fact_cmd= " + id + "", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                d.Load(dr);
                dr.Close();
                cn.Close();
            }
            return d;
        }

        // POST: api/Somme_Detail_Fact
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Somme_Detail_Fact/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Somme_Detail_Fact/5
        public void Delete(int id)
        {
        }
    }
}
