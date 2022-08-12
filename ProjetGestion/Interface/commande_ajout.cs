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
    public partial class commande_ajout : Form
    {
        Gestion f1_cmd;
        commande_ajout cmd_fff_ajout;
        Interface.commande_ajout_client GCLT;
        Interface.commande_ajout_produit GPRD_cmd;
      //  tous_class.declaration dec = new tous_class.declaration();

        public string NumClt;
        public string NomClt;
        public string PrenomClt;
        public string TelClt;
        public string EmailClt;
        public string NomVille;

        public string nomcomm_cmd;

        public string IDProduit_cmd;
        public string NomCat_cmd;
        public string NomProduit_cmd;
        public string QTEStock_cmd;
       // public string PrixAchatt_cmd;
        public string PrixVente_cmd;

        public commande_ajout(Gestion ff1_cmd)
        {
            InitializeComponent();
            this.f1_cmd = ff1_cmd;
        }
        public commande_ajout(Interface.commande_ajout cmd_Form_ajout)
        {
            InitializeComponent();
            this.cmd_fff_ajout = cmd_Form_ajout;
        }
        public commande_ajout(Interface.commande_ajout_client GFormCLT)
        {
            InitializeComponent();
            this.GCLT = GFormCLT;
        }
        public commande_ajout(Interface.commande_ajout_produit GFormPRD_cmd)
        {
            InitializeComponent();
            this.GPRD_cmd = GFormPRD_cmd;
        }
        
  
        private async void getRestcmdINC()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://localhost:59489/api/CommandeCRUD");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            tous_class.ClassCommandeinc[] commandeINC = JsonConvert.DeserializeObject<tous_class.ClassCommandeinc[]>(responseBody);

            int max;
            int i = 1;
            max = int.Parse(commandeINC[0].t.ToString());
            txtbxNumFACT_cmd.Text = (max + i).ToString();
        }

        public async void getRest_PrdGrid()
        {
            if (dataGridView1.Rows != null)
            {
                dataGridView1.Rows.Clear();
            }
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://localhost:59489/api/Detail_Cmd/" + txtbxNumFACT_cmd.Text);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            tous_class.ClassDetail_Cmd_Grid[] detail_cmd = JsonConvert.DeserializeObject<tous_class.ClassDetail_Cmd_Grid[]>(responseBody);

            for (int i = 0; i < detail_cmd.Length; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = detail_cmd[i].ID_Produit;
                row.Cells[1].Value = detail_cmd[i].Nom_Produit;
                row.Cells[2].Value = detail_cmd[i].Num_Fact_cmd;
                row.Cells[3].Value = detail_cmd[i].Qte_Vendu_cmd;
                row.Cells[4].Value = detail_cmd[i].Qte_Stock_cmd;
                row.Cells[5].Value = detail_cmd[i].Prix_Vente_cmd;
                row.Cells[6].Value = detail_cmd[i].Remise;
                row.Cells[7].Value = detail_cmd[i].Total_Montant_cmd;
                dataGridView1.Rows.Add(row);
            }
        }

        private async void getRest_Somme()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://localhost:59489/api/Somme_Detail_Fact/" + txtbxNumFACT_cmd.Text);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            tous_class.ClassSomme_Detail_Fact[] somme_fact = JsonConvert.DeserializeObject<tous_class.ClassSomme_Detail_Fact[]>(responseBody);

            float som;
            som = float.Parse(somme_fact[0].t.ToString());
            textBox1.Text = som.ToString();
        }

        public void btnGRIDsupprimer_cmd()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "Suppression";
            btn.Text = "Supprimer";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);
        }
        
        private void commande_ajout_Load(object sender, EventArgs e)
        {
           if (txtbxNumFACT_cmd.Text == "")
            {
                getRestcmdINC();
            }
            txtbxNomCOMM_cmd.Text = nomcomm_cmd;
          
            if (txtbxNumFACT_cmd.Text == "")
            {
                txtbxNomCOMM_cmd.Text = nomcomm_cmd;             
            }

            else if (txtbxNumFACT_cmd.Text != "" && nomcomm_cmd == null && IDProduit_cmd == null)
            {
                try
                {
                 txtbxNumFACT_cmd.Text = GCLT.numfact_cmd;
                 txtbxNomCOMM_cmd.Text = GCLT.nomcomm2_cmd;                
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
                txtbxnumClt.Text = NumClt;
                txtbxNomClt.Text = NomClt;
                txtbxPrenomClt.Text = PrenomClt;
                txtxbxNumTelClt.Text = TelClt;
                txtbxemailClt.Text = EmailClt;
                txtbxville.Text = NomVille;
                
            }

           else if (txtbxNumFACT_cmd.Text != "" && IDProduit_cmd != null)
            {
                txtbxNumFACT_cmd.Text = GPRD_cmd.copiecopienumfact_cmd;
                txtbxNomCOMM_cmd.Text = GPRD_cmd.copiecopienomcomm2_cmd;

                txtbxnumClt.Text = GPRD_cmd.copieIDCLT;
                txtbxNomClt.Text = GPRD_cmd.copieNomCLT;
                txtbxPrenomClt.Text = GPRD_cmd.copiePreCLT;
                txtxbxNumTelClt.Text = GPRD_cmd.copieTelCLT;
                txtbxemailClt.Text = GPRD_cmd.copieEmailCLT;
                txtbxville.Text = GPRD_cmd.copieVilleCLT;

                groupBoxCLT.Visible = true;
                groupBoxProduit.Visible = true;
                
                txtbxnumProduit.Text = IDProduit_cmd;
                txtbxcategorie.Text = NomCat_cmd;
                txtbxNomProduit.Text = NomProduit_cmd;
                txtbxQteStock.Text = QTEStock_cmd;
                txtbxprixVente.Text = PrixVente_cmd;
                               
                try
                {
                    if (GPRD_cmd.copieIDCLT != "")
                    {
                        MessageBox.Show(" *** : " + GPRD_cmd.copieIDCLT);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAnnulerFACTURE_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnClickClt_Click(object sender, EventArgs e)
        {
            cmd_fff_ajout = new commande_ajout(this);
            this.Hide();

            GCLT = new commande_ajout_client();
            GCLT.nomcomm2_cmd = txtbxNomCOMM_cmd.Text;
            GCLT.numfact_cmd = txtbxNumFACT_cmd.Text;
           
            GCLT.ShowDialog();

            this.Close();

            groupBoxProduit.Visible = true;
            groupBoxFact.Enabled = false;
        }

        private void btnValiderFacture_Click(object sender, EventArgs e)
        {
           if (txtbxNumFACT_cmd.Text != "" || this.dateTimePicker1.Text != "")
            {
                var n_fact_cmd = txtbxNumFACT_cmd.Text;
                var date_fact = this.dateTimePicker1.Text;
                var nom_v = txtbxNomCOMM_cmd.Text;
               
                var json = JsonConvert.SerializeObject(new tous_class.ClassCmdImp(n_fact_cmd,Convert.ToDateTime(date_fact), nom_v));
                var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
                HttpClient client = new HttpClient();
                HttpResponseMessage response = client.PostAsync("http://localhost:59489/api/CommandeCRUD", stringContent).Result;
                response.EnsureSuccessStatusCode();

                MessageBox.Show("Ajout réaliser avec succes");
                groupBoxCLT.Visible = true;
                groupBoxFact.Enabled = false;
            }
               
            }

        private void btnClickPRD_Click(object sender, EventArgs e)
        {
            cmd_fff_ajout =  new commande_ajout(this);
            this.Hide();
            GPRD_cmd = new commande_ajout_produit();
            GPRD_cmd.copienomcomm2_cmd = txtbxNomCOMM_cmd.Text;
            GPRD_cmd.copienumfact_cmd = txtbxNumFACT_cmd.Text;

            GPRD_cmd.IDCLT = txtbxnumClt.Text;
            GPRD_cmd.NomCLT = txtbxNomClt.Text;
            GPRD_cmd.PreCLT = txtbxPrenomClt.Text;
            GPRD_cmd.TelCLT = txtxbxNumTelClt.Text;
            GPRD_cmd.EmailCLT = txtbxemailClt.Text;
            GPRD_cmd.VilleCLT =  txtbxville.Text;

            GPRD_cmd.ShowDialog();

            this.Close();

            btnValiderProduit.Enabled = true;
        }
          
        private void btnValiderProduit_Click(object sender, EventArgs e)
        {
            if (txtbxQteVendu.Text == "" || txtbxprixVente.Text == "" || txtbxremise.Text == "")
            {
                MessageBox.Show("Veuillez remplir les champs (Qte,Prix,Remise) ");
            }
            else if (txtbxQteVendu.Text != "" && txtbxprixVente.Text != "" && txtbxremise.Text != "")
            {
                double QteStock = double.Parse(txtbxQteStock.Text);
                double QteVendu = double.Parse(txtbxQteVendu.Text);

                if (QteStock >= QteVendu)
                {
                double New_QteStock = (QteStock) - (QteVendu);
                txtbxQteStock.Text = New_QteStock.ToString();
                
                double qte = double.Parse(txtbxQteVendu.Text);
                double prixa = double.Parse(txtbxprixVente.Text);
                double remise = double.Parse(txtbxremise.Text);
                double ress = (((qte) * (prixa)) / (1 + (remise / 100)));
                txtxbxTotal.Text = ress.ToString("000.00");

                try
                {
                 var id_prd = txtbxnumProduit.Text;
                 var num_fact = txtbxNumFACT_cmd.Text;
                 var qte_v = txtbxQteVendu.Text;
                 var qte_s = txtbxQteStock.Text;
                 var prix_v = txtbxprixVente.Text;
                 var re = txtbxremise.Text;
                 var montant_t = txtxbxTotal.Text;

                 var json = JsonConvert.SerializeObject(new tous_class.ClassCmd_Detail(int.Parse(id_prd), num_fact, qte_v, int.Parse(qte_s), prix_v, re, float.Parse(montant_t)));
                 var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
                 HttpClient client = new HttpClient();
                 HttpResponseMessage response = client.PostAsync("http://localhost:59489/api/Cmd_Ajout_Prd", stringContent).Result;
                 response.EnsureSuccessStatusCode();
                 MessageBox.Show("Ajout réaliser avec succes");

                 dataGridView1.Visible = true;
                 getRest_PrdGrid();
                 btnGRIDsupprimer_cmd();

                 txtbxNomProduit.Text = "";
                 txtbxcategorie.Text = "";
                 txtbxnumProduit.Text = "";
                 txtbxQteStock.Text = "";
                 txtbxQteVendu.Text = "";
                 txtbxprixVente.Text = "";
                 txtbxremise.Text = "";
                 txtxbxTotal.Text = "";
                 btnterminerProduit.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur D'ajouter les Produits dans la Table " + ex.Message);
                }
                }
                else
                {
                    MessageBox.Show("Quantite demander supperieur à la Quantiter du stock");
                }

            }
        }

        private void txtbxremise_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtbxremise_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',')
                e.Handled = false;
           
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnterminerProduit_Click(object sender, EventArgs e)
        {
            string VAR_ID_PRD = dataGridView1.Rows[0].Cells[0].Value.ToString();
            string VAR_Num_Fact = dataGridView1.Rows[0].Cells[2].Value.ToString();
            getRest_Somme();
            groupBoxCLT.Enabled = false;
            groupBoxProduit.Enabled = false;
            groupBoxPaiement.Visible = true;
            rdopayer.Checked = true;
            dataGridView1.Enabled = false;
        }

        private void rdopayer_CheckedChanged(object sender, EventArgs e)
        {
            label12.Visible = false;
            label11.Visible = false;
            txtbxAvanceClt.Visible = false;
            txtbxRestClt.Visible = false;
        }

        private void rdoNONpayer_CheckedChanged(object sender, EventArgs e)
        {
            label12.Visible = true;
            label11.Visible = true;
            txtbxAvanceClt.Visible = true;
            txtbxRestClt.Visible = true;

            txtbxAvanceClt.Text = "";
            txtbxRestClt.Text = "";
        }

        private void btnValiderPaiement_Click(object sender, EventArgs e)
        {
            if (rdoNONpayer.Checked == true)
            {
                if (txtbxAvanceClt.Text != "")
                {
                    double Paie_Montant_cmd = double.Parse(textBox1.Text);
                    double Paie_Avance_cmd = double.Parse(txtbxAvanceClt.Text);
                    double Paie_Reste_cmd = (Paie_Montant_cmd) - (Paie_Avance_cmd);
                    txtbxRestClt.Text = Paie_Reste_cmd.ToString();
                   
                    var num_fact = txtbxNumFACT_cmd.Text;
                    var regl_cmd = textBox1.Text;
                    var av_cmd = txtbxAvanceClt.Text;
                    var rest_cmd = txtbxRestClt.Text;

                    var json = JsonConvert.SerializeObject(new tous_class.Class1Detail_Cmd_Paiement(num_fact, regl_cmd, av_cmd, rest_cmd));
                    var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
                    HttpClient VillesMod = new HttpClient();
                    HttpResponseMessage response = VillesMod.PutAsync("http://localhost:59489/api/Detail_Cmd", stringContent).Result;
                    response.EnsureSuccessStatusCode();

                    MessageBox.Show("Paiement1 réaliser avec succes");


                    Interface.commande_ajout Cmd_ajout_ferme = new Interface.commande_ajout(this);
                    this.Hide();
              }
                else
                {
                    MessageBox.Show("veuillez saissir une avance");
                }
            }
            else
            {
                
                var num_fact = txtbxNumFACT_cmd.Text;
                var regl_cmd = textBox1.Text;
                var av_cmd = 0;
                var rest_cmd = 0;

                var json = JsonConvert.SerializeObject(new tous_class.Class1Detail_Cmd_Paiement(num_fact, regl_cmd, av_cmd.ToString(), rest_cmd.ToString()));
                var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
                HttpClient VillesMod = new HttpClient();
                HttpResponseMessage response = VillesMod.PutAsync("http://localhost:59489/api/Detail_Cmd", stringContent).Result;
                response.EnsureSuccessStatusCode();

                MessageBox.Show("Paiement2 réaliser avec succes");
              
                Interface.commande_ajout Cmd_ajout_ferme = new Interface.commande_ajout(this);
                this.Hide();
            }
    }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Voulez Vous Vraiment Supprimer La Ligne", "Confirmation", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    string vueCode = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string vueDesc = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                    //dec.cnx();
                    //dec.cmd.Connection = dec.con;
                    //dec.cmd.CommandType = CommandType.Text;
                    //dec.cmd.CommandText = "select * from DETAIL_COMMANDE";

                    //dec.cmd.CommandText = "delete from DETAIL_COMMANDE where ID_Produit = '" + vueCode + "' and Num_Fact_cmd = '" + vueDesc + "' ";
                    //dec.cmd.ExecuteNonQuery();
                    //dec.decnx();
                    ////dec.ds.Tables["Detail_Cmd"].Rows[dataGridView1.CurrentRow.Index].Delete();


                    //HttpClient client = new HttpClient();
                    //HttpResponseMessage response = client.DeleteAsync("http://localhost:59489/api/Detail_Cmd/ID_Produit={0}&Num_Fact_cmd={1}",vueCode, vueDesc).Result;
                    //response.EnsureSuccessStatusCode();

                    //MessageBox.Show("Suppression réaliser avec succes");
                   
                    getRest_PrdGrid();

                    MessageBox.Show("Suppression réaliser avec success");
                    btnGRIDsupprimer_cmd();
                }
                else
                {
                    MessageBox.Show("non supprimer");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtbxQteVendu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtbxAvanceClt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '.')
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
