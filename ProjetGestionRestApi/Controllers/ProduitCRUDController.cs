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
    public class ProduitCRUDController : ApiController
    {
        // GET: api/ProduitCRUD
        public DataTable Get()
        {

            DataTable d = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-BETDQGE;Initial Catalog=GestionProjet;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("select Max(ID_Produit) as t from PRODUIT", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                d.Load(dr);
                dr.Close();
                cn.Close();
            }
            return d;
        }

        // GET: api/ProduitCRUD/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ProduitCRUD
        public string Post([FromBody]ClassProduitAjoutRestApi VA)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-BETDQGE;Initial Catalog=GestionProjet;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("insert into PRODUIT(ID_Produit,ID_Cat,Nom_Produit,Qte_Stock,Prix_Achat,Prix_Vente) values(" + VA.ID_Produit + ", " + VA.ID_Cat + ", '" + VA.Nom_Produit + "', " + VA.Qte_Stock + ", '" + VA.Prix_Achat + "','" + VA.Prix_Vente + "')", cn);
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

        // PUT: api/ProduitCRUD/5
        public string Put([FromBody]ClassProduitAjoutRestApi CC)
        {
            try
            {    
                using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-BETDQGE;Initial Catalog=GestionProjet;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("update PRODUIT set ID_Cat='" + CC.ID_Cat + "', Nom_Produit='" + CC.Nom_Produit + "', Qte_Stock='" + CC.Qte_Stock + "',Prix_Achat='" + CC.Prix_Achat + "' ,Prix_Vente=" + CC.Prix_Vente + " where ID_Produit=" + CC.ID_Produit, cn);
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

        // DELETE: api/ProduitCRUD/5
        public string Delete(int id)
        {
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=DESKTOP-BETDQGE;Initial Catalog=GestionProjet;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("delete from PRODUIT where ID_Produit=" + id, cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                return "Suppression avec succès";
            }
            catch (Exception)
            {
                return "erreur delete";
            }
        }
    }
}
