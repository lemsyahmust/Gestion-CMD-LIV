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
    public partial class Gestion_Produit1 : Form
    {
        Interface.produit_modification PROModif;
        Interface.produit_suppression PROSUPP;

        public Gestion_Produit1()
        {
            InitializeComponent();
        }
        public void remplirchampModifPRODUIT()
        {
            PROModif.NomCategorie = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            PROModif.NumProduit = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            PROModif.NomProduit = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            PROModif.QteProduit = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            PROModif.PrixAchat = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            PROModif.PrixVente = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
        public void remplirchampSuppPRODUIT()
        {
            PROSUPP.NomCategorie = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            PROSUPP.NumProduit = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            PROSUPP.NomProduit = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            PROSUPP.QteProduit = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            PROSUPP.PrixAchat = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            PROSUPP.PrixVente = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
        public async void getRest()
        {
            if (dataGridView1.Rows != null)
            {
                dataGridView1.Rows.Clear();
            }
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://localhost:59489/api/Produit");
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

        private void Gestion_Produit1_Load(object sender, EventArgs e)
        {
            getRest();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Interface.produit_ajout PRDAJ = new Interface.produit_ajout(this);
            PRDAJ.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PROModif = new Interface.produit_modification(this);
            remplirchampModifPRODUIT();
            PROModif.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PROSUPP = new Interface.produit_suppression(this);
            remplirchampSuppPRODUIT();
            PROSUPP.ShowDialog();
        }
    }
}
