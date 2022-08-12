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
    public partial class Gestion_Client1 : Form
    {
        Interface.client_modification CLTM;
        Interface.client_suppression CLTS;

        public Gestion_Client1()
        {
            InitializeComponent();
        }

        public void remplirchampModif()
        {
            CLTM.NumClt = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            CLTM.NomClt = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            CLTM.PrenomClt = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            CLTM.TelClt = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            CLTM.EmailClt = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            CLTM.NomVille = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
        public void remplichampSupp()
        {
            CLTS.NumClt = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            CLTS.NomClt = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            CLTS.PrenomClt = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            CLTS.TelClt = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            CLTS.EmailClt = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            CLTS.NomVille = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
        public async void getRest()
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
        private void Gestion_Client1_Load(object sender, EventArgs e)
        {
            getRest();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Interface.client_ajout UA = new Interface.client_ajout(this);
            UA.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLTM = new Interface.client_modification(this);
            remplirchampModif();
            CLTM.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CLTS = new Interface.client_suppression(this);
            remplichampSupp();
            CLTS.ShowDialog();
        }
    }
}
