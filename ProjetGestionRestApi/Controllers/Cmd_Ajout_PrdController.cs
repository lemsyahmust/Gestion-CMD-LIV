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
    public class Cmd_Ajout_PrdController : ApiController
    {
        // GET: api/Cmd_Ajout_Prd
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Cmd_Ajout_Prd/5
        public DataTable Get(string id)
        {
            DataTable d = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-BETDQGE;Initial Catalog=GestionProjet;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("select prd.ID_Produit, ctg.Nom_Cat, prd.Nom_Produit, prd.Qte_Stock, prd.Prix_Achat,prd.Prix_Vente from PRODUIT prd, CATEGORIE ctg where   prd.ID_Cat = ctg.ID_Cat and prd.ID_Produit not in (select ID_Produit from DETAIL_COMMANDE where Num_Fact_cmd = '" + id + "')", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                d.Load(dr);
                dr.Close();
                cn.Close();
            }
            return d;
        }

        // POST: api/Cmd_Ajout_Prd
        public string Post([FromBody]ClassCmd_Detail_RestApi CD)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection("Data Source=DESKTOP-BETDQGE;Initial Catalog=GestionProjet;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("insert into DETAIL_COMMANDE (ID_Produit,Num_Fact_cmd,Qte_Vendu_cmd,Qte_Stock_cmd,Prix_Vente_cmd,Remise,Total_Montant_cmd) values("+ CD.ID_Produit + ",'"+ CD.Num_Fact_cmd + "','"+ CD.Qte_Vendu_cmd + "',"+ CD.Qte_Stock_cmd + ",'"+ CD.Prix_Vente_cmd + "','"+ CD.Remise + "','"+ CD.Total_Montant_cmd + "')", cn);
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

        // PUT: api/Cmd_Ajout_Prd/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cmd_Ajout_Prd/5
        public void Delete(int id)
        {
        }
    }
}
