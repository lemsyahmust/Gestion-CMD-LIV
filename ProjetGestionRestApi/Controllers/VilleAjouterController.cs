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
    public class VilleAjouterController : ApiController
    {
        // GET: api/VilleAjouter
        public DataTable Get()
        {

            DataTable d = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-BETDQGE;Initial Catalog=GestionProjet;Integrated Security=True"))
            {
              //  int max;
                SqlCommand cmd = new SqlCommand("select Max(ID_Ville) as t from VILLE", cn);
                cn.Open();
           //     max = Convert.ToInt16(cmd.ExecuteScalar());
                SqlDataReader dr = cmd.ExecuteReader();
                d.Load(dr);
                dr.Close();
                cn.Close();
            }
            return d;
        }

        // GET: api/VilleAjouter/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/VilleAjouter
        public string Post([FromBody]ClassAjoutVilleVrai VA)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-BETDQGE;Initial Catalog=GestionProjet;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("insert into VILLE values(" + VA.ID_Ville + ", '" + VA.Nom_Ville + "')", cn);
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

        // PUT: api/VilleAjouter/5
        public string Put([FromBody]ClassAjoutVilleVrai VV)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-BETDQGE;Initial Catalog=GestionProjet;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("update VILLE set Nom_Ville='" + VV.Nom_Ville + "' where ID_Ville=" + VV.ID_Ville, cn);
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

        // DELETE: api/VilleAjouter/5
        public string Delete(int id)
        {
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=DESKTOP-BETDQGE;Initial Catalog=GestionProjet;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("delete from VILLE where ID_Ville=" + id, cn);
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
