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
    public partial class Gestion_Ville1 : Form
    {
        public Gestion_Ville1()
        {
            InitializeComponent();
        }
        public async void getRest()
        {
            if (dataGridView1.Rows != null)
            {
                dataGridView1.Rows.Clear();
            }
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://localhost:59489/api/ProjetGestionRestApi");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            tous_class.ClassProjetGestion[] villes = JsonConvert.DeserializeObject<tous_class.ClassProjetGestion[]>(responseBody);

            for (int i = 0; i < villes.Length; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);

                row.Cells[0].Value = villes[i].ID_Ville;
                row.Cells[1].Value = villes[i].Nom_Ville;
                dataGridView1.Rows.Add(row);
            }
        }

        private void Gestion_Ville1_Load(object sender, EventArgs e)
        {
            getRest();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Interface.ville_ajout VAA = new Interface.ville_ajout(this);
            VAA.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Interface.ville_modification VM = new Interface.ville_modification(this);

                VM.IDVille = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                VM.NomVille = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                VM.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Interface.ville_suppression VS = new Interface.ville_suppression(this);

            VS.IDVille = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            VS.NOMVille = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            VS.ShowDialog();
        }
    }
}
