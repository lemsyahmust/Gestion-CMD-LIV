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
    public class Detail_CmdController : ApiController
    {
        // GET: api/Cmd_CLT_Sauve
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Cmd_CLT_Sauve/5
        public DataTable Get(int id)
        {

            DataTable d = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-BETDQGE;Initial Catalog=GestionProjet;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("select dcmd.ID_Produit,Nom_Produit,Num_Fact_cmd,dcmd.Qte_Vendu_cmd,dcmd.Qte_Stock_cmd,dcmd.Prix_Vente_cmd,Remise,Total_Montant_cmd from DETAIL_COMMANDE dcmd,PRODUIT PRD where dcmd.ID_Produit=PRD.ID_Produit and Num_Fact_cmd = " + id + "", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                d.Load(dr);
                dr.Close();
                cn.Close();
            }
            return d;
        }


        // POST: api/Cmd_CLT_Sauve
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Cmd_CLT_Sauve/5
        public string Put([FromBody]Detail_Cmd_Paiement_RestApi DCP)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-BETDQGE;Initial Catalog=GestionProjet;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("update COMMANDE set Reglement_cmd='" + DCP.Reglement_cmd + "', Avance_cmd='" + DCP.Avance_cmd + "', Reste_clt='" + DCP.Reste_clt + "'  where Num_Fact_cmd=" + DCP.Num_Fact_cmd, cn);
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

        // DELETE: api/Cmd_CLT_Sauve/5
        public string Delete(String id_prd, string num_fact )
        {
            try
            {
                SqlConnection cn = new SqlConnection("Data Source=DESKTOP-BETDQGE;Initial Catalog=GestionProjet;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("delete from DETAIL_COMMANDE where ID_Produit='" + id_prd +"' and Num_Fact_cmd = '"+ num_fact , cn);
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
