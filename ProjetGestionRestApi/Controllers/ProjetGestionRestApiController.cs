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
    public class ProjetGestionRestApiController : ApiController
    {
        // GET: api/ProjetGestionRestApi
        public DataTable Get()
        {

            DataTable d = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-BETDQGE;Initial Catalog=GestionProjet;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("select * from VILLE", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                d.Load(dr);
                dr.Close();
                cn.Close();
            }
            return d;
        }

        // GET: api/ProjetGestionRestApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ProjetGestionRestApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ProjetGestionRestApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ProjetGestionRestApi/5
        public void Delete(int id)
        {
        }
    }
}
