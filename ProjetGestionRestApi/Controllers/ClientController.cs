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
    public class ClientController : ApiController
    {
        // GET: api/Client
        public DataTable Get()
        {

            DataTable d = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-BETDQGE;Initial Catalog=GestionProjet;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("select ID_Clt, Nom_Clt, Prenom_Clt, Tel_Clt, Email_Clt, Nom_Ville from CLIENT clt,VILLE vl where clt.ID_Ville = vl.ID_Ville", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                d.Load(dr);
                dr.Close();
                cn.Close();
            }
            return d;
        }

        // GET: api/Client/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Client
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Client/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Client/5
        public void Delete(int id)
        {
        }
    }
}
