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
    public class CategorieCRUDController : ApiController
    {
        // GET: api/CategorieCRUD
        public DataTable Get()
        {

            DataTable d = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-BETDQGE;Initial Catalog=GestionProjet;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("select Max(ID_Cat) as t from CATEGORIE", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                d.Load(dr);
                dr.Close();
                cn.Close();
            }
            return d;
        }

        // GET: api/CategorieCRUD/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CategorieCRUD
        public string Post([FromBody]CategorieRestApi CR)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-BETDQGE;Initial Catalog=GestionProjet;Integrated Security=True"))
                {
                    // SqlCommand cmd = new SqlCommand("insert into VILLE values(" + VA.ID_Ville + ", '" + VA.Nom_Ville + "')", cn);
                    SqlCommand cmd = new SqlCommand("insert into CATEGORIE(ID_Cat, Nom_Cat) values(" + CR.ID_Cat + ", '" + CR.Nom_Cat + "')", cn);

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


        // PUT: api/CategorieCRUD/5
        public string Put([FromBody]CategorieRestApi CC)
        {
            try
            {
                //Nom_Clt = @Nom_Clt,Prenom_Clt = @Prenom_Clt,Tel_Clt = @Tel_Clt ,Email_Clt = @Email_Clt,Image_Clt = @Image_Clt, ID_Ville = @ID_Ville
                using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-BETDQGE;Initial Catalog=GestionProjet;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("update CATEGORIE set Nom_Cat='" + CC.Nom_Cat + "' where ID_Cat=" + CC.ID_Cat, cn);
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

        // DELETE: api/CategorieCRUD/5
        public string Delete(int id)
        {
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=DESKTOP-BETDQGE;Initial Catalog=GestionProjet;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("delete from CATEGORIE where ID_Cat=" + id, cn);
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
