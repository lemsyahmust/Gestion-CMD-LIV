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
    public partial class commande_ajout_client : Form
    {
        Interface.commande_ajout cmd_frs;
       
        public string nomcomm2_cmd;
        public string numfact_cmd;

        public string copienomcomm2_cmd;
        public string copienumfact_cmd;

        public commande_ajout_client()
        {
            InitializeComponent();
        }

        public async void getRestGridCLT()
        {
            if (dataGridView1.Rows != null)
            {
                dataGridView1.Rows.Clear();
            }

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://localhost:59489/api/Client");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            tous_class.ClassClient[] Clients = JsonConvert.DeserializeObject<tous_class.ClassClient[]>(responseBody);

            for (int i = 0; i < Clients.Length; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);

                row.Cells[0].Value = Clients[i].ID_Clt;
                row.Cells[1].Value = Clients[i].Nom_Clt;
                row.Cells[2].Value = Clients[i].Prenom_Clt;
                row.Cells[3].Value = Clients[i].Tel_Clt;
                row.Cells[4].Value = Clients[i].Email_Clt;
                row.Cells[5].Value = Clients[i].Nom_Ville;
                dataGridView1.Rows.Add(row);
            }
        }

        public void remplirchamp_CLT_CMD()
        {
            cmd_frs.NumClt = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cmd_frs.NomClt = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cmd_frs.PrenomClt = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cmd_frs.TelClt = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmd_frs.EmailClt = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cmd_frs.NomVille = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            cmd_frs.txtbxNumFACT_cmd.Text = copienumfact_cmd;
            cmd_frs.txtbxNomCOMM_cmd.Text = copienomcomm2_cmd;
        }
       
        private void commande_ajout_fournisseur_Load(object sender, EventArgs e)
        {
            getRestGridCLT();

            copienomcomm2_cmd = nomcomm2_cmd;
            copienumfact_cmd = numfact_cmd;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        /*    if (textBox1.Text != "")
            {
                try
                {
                    if (dec.dt.Rows != null)
                    {
                        dec.dt.Clear();
                    }

                    dec.cnx();
                    dec.cmd = new SqlCommand("select ID_Clt, Nom_Clt, Prenom_Clt, Tel_Clt, Email_Clt, Nom_Ville from CLIENT clt,VILLE vl where clt.ID_Ville = vl.ID_Ville and (Nom_Clt Like '" + textBox1.Text + "%' or Prenom_Clt Like '" + textBox1.Text + "%') ", dec.con);
                    dec.cmd.Connection = dec.con;
                    dec.dr = dec.cmd.ExecuteReader();
                    dec.dt = new DataTable("CLIENT");
                    dec.dt.Load(dec.dr);
                    dataGridView1.DataSource = dec.dt;
                    
                    dataGridView1.Columns["ID_Clt"].HeaderText = "Numero";
                    dataGridView1.Columns["Nom_Clt"].HeaderText = "Nom";
                    dataGridView1.Columns["Prenom_Clt"].HeaderText = "Prenom";
                    dataGridView1.Columns["Tel_Clt"].HeaderText = "Telephone ";
                    dataGridView1.Columns["Email_Clt"].HeaderText = "Email  ";
                    dataGridView1.Columns["Nom_Ville"].HeaderText = "Ville";

                    dec.dr.Close();
                    dec.decnx();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    dec.dr.Close();
                    dec.decnx();
                }
            }
            else
            {
                //remplirGRIDG_CLT_Cmd();
                getRestGridCLT();
            }*/
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            cmd_frs = new Interface.commande_ajout(this);

            remplirchamp_CLT_CMD();

            cmd_frs.groupBoxCLT.Visible = true;
            this.Hide();
                       
            var IDClt = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            var json = JsonConvert.SerializeObject(new tous_class.ClassCmd_Clt(copienumfact_cmd, int.Parse(IDClt)));
            var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            HttpClient VillesMod = new HttpClient();
            HttpResponseMessage response = VillesMod.PutAsync("http://localhost:59489/api/CommandeCRUD", stringContent).Result;
            response.EnsureSuccessStatusCode();

            MessageBox.Show("Modification réaliser avec succes");
            this.Close();

            cmd_frs.groupBoxFact.Enabled = false;
            cmd_frs.groupBoxProduit.Visible = true;

            cmd_frs.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
