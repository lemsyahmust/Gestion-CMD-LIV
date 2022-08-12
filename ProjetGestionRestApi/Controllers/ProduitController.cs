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
    public class ProduitController : ApiController
    {
        // GET: api/Produit
        public DataTable Get()
        {
            DataTable d = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-BETDQGE;Initial Catalog=GestionProjet;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("select ID_Produit, Nom_Cat, Nom_Produit, Qte_Stock, Prix_Achat, Prix_Vente from PRODUIT prd,CATEGORIE ctg where prd.ID_Cat = ctg.ID_Cat", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                d.Load(dr);
                dr.Close();
                cn.Close();
            }
            return d;
        }

        // GET: api/Produit/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Produit
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Produit/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Produit/5
        public void Delete(int id)
        {
        }
    }
}
