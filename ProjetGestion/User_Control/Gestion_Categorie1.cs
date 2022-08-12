using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;

namespace ProjetGestion.User_Control
{
    public partial class Gestion_Categorie1 : Form
    {
        public Gestion_Categorie1()
        {
            InitializeComponent();
        }
        private async void getRestIncremente()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://DESKTOP-SAN3PBB/SQLEXPRESS:59489/api/CategorieCRUD");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            tous_class.Categoriein[] CategorieAjout = JsonConvert.DeserializeObject<tous_class.Categoriein[]>(responseBody);

            int max;
            int i = 1;
            max = int.Parse(CategorieAjout[0].t.ToString());
            txtbxnumClient.Text = (max + i).ToString();
        }

        private async void getRest()
        {
            if (dataGridView1.Rows != null)
            {
                dataGridView1.Rows.Clear();
            }

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://DESKTOP-SAN3PBB/SQLEXPRESS:59489/api/Categorie");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            tous_class.ClassCategorieCRUD[] categorie = JsonConvert.DeserializeObject<tous_class.ClassCategorieCRUD[]>(responseBody);

            txtbxnumClient.Text = categorie[0].ID_Cat.ToString();
            txtbxNomFournisseur.Text = categorie[0].Nom_Cat;


            for (int i = 0; i < categorie.Length; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);

                row.Cells[0].Value = categorie[i].ID_Cat;
                row.Cells[1].Value = categorie[i].Nom_Cat;
                dataGridView1.Rows.Add(row);
            }



        }
        private void Gestion_Categorie1_Load(object sender, EventArgs e)
        {
            getRest();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            var nclt = txtbxnumClient.Text;
            var nomclt = txtbxNomFournisseur.Text;

            var json = JsonConvert.SerializeObject(new tous_class.ClassCategorieCRUD(int.Parse(nclt), nomclt));
            var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.PostAsync("http://DESKTOP-SAN3PBB/SQLEXPRESS:59489/api/CategorieCRUD", stringContent).Result;
            response.EnsureSuccessStatusCode();


            MessageBox.Show("Ajout réaliser avec succes");
            btnajouter.Enabled = false;
            button1.Enabled = true;
            getRest();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnajouter.Enabled = true;
            button1.Enabled = false;
            txtbxNomFournisseur.Text = "";
            getRestIncremente();
        }

        private void btnmodif_Click(object sender, EventArgs e)
        {
            var nclt = txtbxnumClient.Text;
            var nomclt = txtbxNomFournisseur.Text;

            var json = JsonConvert.SerializeObject(new tous_class.ClassCategorieCRUD(int.Parse(nclt), nomclt));
            var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            HttpClient VillesMod = new HttpClient();
            HttpResponseMessage response = VillesMod.PutAsync("http://DESKTOP-SAN3PBB/SQLEXPRESS:59489/api/CategorieCRUD", stringContent).Result;
            response.EnsureSuccessStatusCode();

            MessageBox.Show("Modification réaliser avec succes");
            getRest();
        }

        private void btnsupp_Click(object sender, EventArgs e)
        {
            var nclt = txtbxnumClient.Text;

            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.DeleteAsync("http://DESKTOP-SAN3PBB/SQLEXPRESS:59489/api/CategorieCRUD/" + nclt).Result;
            response.EnsureSuccessStatusCode();

            MessageBox.Show("Suppression réaliser avec succes");

            getRest();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbxnumClient.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtbxNomFournisseur.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
