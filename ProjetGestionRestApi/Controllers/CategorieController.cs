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
    public class CategorieController : ApiController
    {
        // GET: api/Categorie
        public DataTable Get()
        {
            DataTable d = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-BETDQGE;Initial Catalog=GestionProjet;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("select * from CATEGORIE", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                d.Load(dr);
                dr.Close();
                cn.Close();
            }
            return d;
        }

        // GET: api/Categorie/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Categorie
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Categorie/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Categorie/5
        public void Delete(int id)
        {
        }
    }
}
