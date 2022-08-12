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
    public class ClientCRUDController : ApiController
    {
        // GET: api/ClientCRUD
        public DataTable Get()
        {

            DataTable d = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-BETDQGE;Initial Catalog=GestionProjet;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("select Max(ID_Clt) as t from CLIENT", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                d.Load(dr);
                dr.Close();
                cn.Close();
            }
            return d;
        }

        // GET: api/ClientCRUD/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ClientCRUD
        public string Post([FromBody]ClassClientCRUDRestApi VA)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-BETDQGE;Initial Catalog=GestionProjet;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("insert into CLIENT(ID_Clt, Nom_Clt, Prenom_Clt, Tel_Clt, Email_Clt, ID_Ville) values(" + VA.ID_Clt + ", '" + VA.Nom_Clt + "', '" + VA.Prenom_Clt + "', '" + VA.Tel_Clt + "', '" + VA.Email_Clt + "'," + VA.ID_Ville + ")", cn);
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

        // PUT: api/ClientCRUD/5
        public string Put([FromBody]ClassClientCRUDRestApi CC)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-BETDQGE;Initial Catalog=GestionProjet;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("update CLIENT set Nom_Clt='" + CC.Nom_Clt + "', Prenom_Clt='"+ CC.Prenom_Clt + "', Tel_Clt='"+ CC.Tel_Clt + "',Email_Clt='"+ CC.Email_Clt +"' ,ID_Ville="+ CC.ID_Ville + " where ID_Clt=" + CC.ID_Clt, cn);
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

        // DELETE: api/ClientCRUD/5
        public string Delete(int id)
        {
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=DESKTOP-BETDQGE;Initial Catalog=GestionProjet;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("delete from CLIENT where ID_Clt=" + id, cn);
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
