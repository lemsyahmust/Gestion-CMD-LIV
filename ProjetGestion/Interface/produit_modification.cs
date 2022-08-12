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
    public partial class produit_modification : Form
    {
        User_Control.Gestion_Produit1 GPRODUIT;

        public string NomCategorie;
        public string NumProduit;
        public string NomProduit;
        public string QteProduit;
        public string PrixAchat;
        public string PrixVente;

        public produit_modification(User_Control.Gestion_Produit1 GFormPRODUIT)
        {
            InitializeComponent();
            this.GPRODUIT = GFormPRODUIT;
        }
        
        public async void getRestCatCombo()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://localhost:59489/api/Categorie");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            tous_class.ClassCategorieCRUD[] villes = JsonConvert.DeserializeObject<tous_class.ClassCategorieCRUD[]>(responseBody);

            foreach (var name in villes)
            {
                comboBox1.Items.Add(name.Nom_Cat);
                comboBox1.ValueMember = (name.ID_Cat).ToString();
                comboBox1.DisplayMember = (name.Nom_Cat).ToString();
            }
        }

        private void produit_modification_Load(object sender, EventArgs e)
        {
            txtbxnumProduit.Text = NomCategorie;
            comboBox1.Text = NumProduit;
            txtbxNomProduit.Text = NomProduit;
            txtbxQteStock.Text = QteProduit;
            txtbxprixachat.Text = PrixAchat;
            txtbxprixvente.Text = PrixVente;
            getRestCatCombo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
              if (txtbxnumProduit.Text == "" || txtbxNomProduit.Text == "" || txtbxQteStock.Text == "" || txtbxprixachat.Text == "" || txtbxprixvente.Text == "" || comboBox1.Text == "")
              {
                  MessageBox.Show("Les Champs il sont vide");
              }
              else if (txtbxnumProduit.Text != "" || txtbxNomProduit.Text != "" || txtbxQteStock.Text != "" || txtbxprixachat.Text != "" || txtbxprixvente.Text != "" || comboBox1.Text != "")
              {
                  try
                  {
                      var nprd = txtbxnumProduit.Text;
                      int idvil = Convert.ToInt32(comboBox1.SelectedIndex);
                      var nomprd = txtbxNomProduit.Text;
                      var qteS = txtbxQteStock.Text;
                      var prixA = txtbxprixachat.Text;
                      var prixV = txtbxprixvente.Text;
            
                      var json = JsonConvert.SerializeObject(new tous_class.ClassProduitAjout(int.Parse(nprd), idvil, nomprd, int.Parse(qteS), prixA, prixV));
                      var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
                      HttpClient VillesMod = new HttpClient();
                      HttpResponseMessage response = VillesMod.PutAsync("http://localhost:59489/api/ProduitCRUD", stringContent).Result;
                      response.EnsureSuccessStatusCode();

                      MessageBox.Show("Modification réaliser avec succes");
                      GPRODUIT.getRest();
                      this.Close();
                  }
                  catch (Exception ex)
                  {
                      MessageBox.Show(ex.Message);
                  }
              }
        }

        private void txtbxQteStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtbxprixachat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '.')
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtbxprixvente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '.')
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
