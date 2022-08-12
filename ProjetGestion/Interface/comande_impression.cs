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
    public partial class comande_impression : Form
    {
        //tous_class.declaration dec = new tous_class.declaration();
        public comande_impression()
        {
            InitializeComponent();
        }
        string num_fact_imp;

        //public void remplirGRIDG_CMD()
        //{
        //    try
        //    {
        //        if (dec.dt.Rows != null)
        //        {
        //            dec.dt.Clear();
        //        }
        //        dec.da = new SqlDataAdapter("select Num_Fact_cmd,Date_Fct_cmd,Nom_Vendeur from COMMANDE", dec.con);
        //        dec.da.Fill(dec.dt);
        //        //*****remplir dataGridView1 apartir du datatable
        //        dataGridView1.DataSource = dec.dt;
        //        ////*****pour changer le titre de cahque colonne 
        //        dataGridView1.Columns["Num_Fact_cmd"].HeaderText = "Numero Facture";
        //        dataGridView1.Columns["Date_Fct_cmd"].HeaderText = "Date Facture";
        //        dataGridView1.Columns["Nom_Vendeur"].HeaderText = "Nom Vendeur";
        //        dec.decnx();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private async void getRest()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://localhost:59489/api/CommandeImp");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            tous_class.ClassCmdImp[] cmdImp = JsonConvert.DeserializeObject<tous_class.ClassCmdImp[]>(responseBody);
            
            for (int i = 0; i < cmdImp.Length; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);

                row.Cells[0].Value = cmdImp[i].Num_Fact_cmd;
                row.Cells[1].Value = cmdImp[i].Date_Fct_cmd;
                row.Cells[2].Value = cmdImp[i].Nom_Vendeur;
                dataGridView1.Rows.Add(row);

            }


        }

        private void comande_impression_Load(object sender, EventArgs e)
        {
              getRest();
        }

        private void btnImprimerCMD_Click(object sender, EventArgs e)
        {
            //Crystal.commande_crystalreport cry_cmd = new Crystal.commande_crystalreport();
            //num_fact_imp = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            //cry_cmd.cmd_imp_crystal = num_fact_imp;
            
            //cry_cmd.ShowDialog();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
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
            //        //la syntaxe du like permet de rechercher toutes les lignes de “colonne” qui commence par le caractere saisie dans le textbox
            //        dec.cmd = new SqlCommand("select Num_Fact_cmd,Date_Fct_cmd,Nom_Vendeur from COMMANDE  where Num_Fact_cmd Like '" + textBox1.Text + "%' ", dec.con);
            //        dec.cmd.Connection = dec.con;
            //        dec.dr = dec.cmd.ExecuteReader();
            //        dec.dt = new DataTable("COMMANDE");
            //        dec.dt.Load(dec.dr);
            //        dataGridView1.DataSource = dec.dt;

            //        //*****pour changer le titre de cahque colonne 
            //        dataGridView1.Columns["Num_Fact_cmd"].HeaderText = "Numero Facture";
            //        dataGridView1.Columns["Date_Fct_cmd"].HeaderText = "Date Facture";
            //        dataGridView1.Columns["Nom_Vendeur"].HeaderText = "Nom Vendeur";

            //        dec.dr.Close();
            //        dec.decnx();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //        dec.dr.Close();
            //        dec.decnx();
            //    }
            //}
            //else
            //{
            //    remplirGRIDG_CMD();
            //}

        }
    }
}
