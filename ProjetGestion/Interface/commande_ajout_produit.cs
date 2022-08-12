using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;

namespace ProjetGestion.Interface
{
    public partial class commande_ajout_produit : Form
    {
        Interface.commande_ajout cmd_ajout_prd;
       // tous_class.declaration dec = new tous_class.declaration();

        public string copienomcomm2_cmd;
        public string copienumfact_cmd;

        public string copiecopienomcomm2_cmd;
        public string copiecopienumfact_cmd;

        // ************************************* donnée client
        public string IDCLT;
        public string copieIDCLT;

        public string NomCLT;
        public string copieNomCLT;

        public string PreCLT;
        public string copiePreCLT;

        public string TelCLT;
        public string copieTelCLT;

        public string EmailCLT;
        public string copieEmailCLT;

        public string VilleCLT;
        public string copieVilleCLT;

        // *************************************


        public commande_ajout_produit()
        {
            InitializeComponent();
        }
        
        public void remplirchampPRDLiv_cmd()
        {
            cmd_ajout_prd.IDProduit_cmd = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cmd_ajout_prd.NomCat_cmd = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cmd_ajout_prd.NomProduit_cmd = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cmd_ajout_prd.QTEStock_cmd = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmd_ajout_prd.PrixVente_cmd = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            cmd_ajout_prd.txtbxNumFACT_cmd.Text = copiecopienumfact_cmd;
            cmd_ajout_prd.txtbxNomCOMM_cmd.Text = copiecopienomcomm2_cmd;
            cmd_ajout_prd.txtbxnumClt.Text = copieIDCLT;
        }

        public async void getRest()
        {
            if (dataGridView1.Rows != null)
            {
                dataGridView1.Rows.Clear();
            }
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://localhost:59489/api/Cmd_Ajout_Prd/" + copienumfact_cmd);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            tous_class.ClassProduitCRUD[] produits = JsonConvert.DeserializeObject<tous_class.ClassProduitCRUD[]>(responseBody);

            for (int i = 0; i < produits.Length; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = produits[i].ID_Produit;
                row.Cells[1].Value = produits[i].Nom_Cat;
                row.Cells[2].Value = produits[i].Nom_Produit;
                row.Cells[3].Value = produits[i].Qte_Stock;
                row.Cells[4].Value = produits[i].Prix_Achat;
                row.Cells[5].Value = produits[i].Prix_Vente;
                dataGridView1.Rows.Add(row);
            }
        }

        private void commande_ajout_produit_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Veuillez Faire un double click dans la liste pour realiser un ajout");

           // dec.cnx();
            copiecopienomcomm2_cmd = copienomcomm2_cmd;
            copiecopienumfact_cmd = copienumfact_cmd;

            copieIDCLT = IDCLT;
            copieNomCLT = NomCLT;
            copiePreCLT = PreCLT;
            copieTelCLT = TelCLT;
            copieEmailCLT = EmailCLT;
            copieVilleCLT = VilleCLT;

            getRest();

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            cmd_ajout_prd = new Interface.commande_ajout(this);
            
            remplirchampPRDLiv_cmd();
           
            this.Hide();
            cmd_ajout_prd.groupBoxFact.Enabled = false;
            cmd_ajout_prd.btnValiderProduit.Enabled = true;
            cmd_ajout_prd.btnterminerProduit.Visible = true;

            cmd_ajout_prd.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (textBox1.Text != "")
            //{
            //    try
            //    {
            //        if (dec.dt.Rows != null)
            //        {
            //            dec.dt.Clear();
            //        }

            //        dec.cnx();
            //        dec.cmd = new SqlCommand(" select prd.ID_Produit, ctg.Nom_Cat, prd.Nom_Produit, prd.Qte_Stock, prd.Prix_Vente from PRODUIT prd, CATEGORIE ctg where   prd.ID_Cat = ctg.ID_Cat and prd.ID_Produit not in (select ID_Produit from DETAIL_COMMANDE where Num_Fact_cmd = '" + copienumfact_cmd + "') and (Nom_Cat Like '" + textBox1.Text + "%' or Nom_Produit Like '" + textBox1.Text + "%') ", dec.con);
            //        dec.cmd.Connection = dec.con;
            //        dec.dr = dec.cmd.ExecuteReader();
            //        dec.dt = new DataTable("PRODUIT");
            //        dec.dt.Load(dec.dr);
            //        dataGridView1.DataSource = dec.dt;
            //        dataGridView1.Columns["ID_Produit"].HeaderText = "Numero";
            //        dataGridView1.Columns["Nom_Cat"].HeaderText = "Categorie";
            //        dataGridView1.Columns["Nom_Produit"].HeaderText = "Produit";
            //        dataGridView1.Columns["Qte_Stock"].HeaderText = "QTE Stock";
            //        dataGridView1.Columns["Prix_Vente"].HeaderText = "Prix_Vente";

            //        dec.dr.Close();
            //        dec.decnx();
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show("Introuvable");
            //        dec.dr.Close();
            //        dec.decnx();
            //    }
            //}
            //else
            //{
            //    remplirGRIDGPRODUITLiv_cmd();
            //}
        }
    }
}
