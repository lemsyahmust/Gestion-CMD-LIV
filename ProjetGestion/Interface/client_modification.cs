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
    public partial class client_modification : Form
    {
        User_Control.Gestion_Client1 GClt;
       // tous_class.declaration dec = new tous_class.declaration();

        public string NumClt;
        public string NomClt;
        public string PrenomClt;
        public string TelClt;
        public string EmailClt;
        public string NomVille;


        public client_modification(User_Control.Gestion_Client1 GFormClt)
        {
            InitializeComponent();
            this.GClt = GFormClt;
        }
       
        public async void getRestVilleCombo()
        {

          //  comboBox1.Items.Clear();

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://localhost:59489/api/ProjetGestionRestApi");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            tous_class.ClassProjetGestion[] villes = JsonConvert.DeserializeObject<tous_class.ClassProjetGestion[]>(responseBody);
            foreach (var name in villes)
            {
                comboBox1.Items.Add(name.Nom_Ville);
                comboBox1.ValueMember = (name.ID_Ville).ToString();
                comboBox1.DisplayMember = (name.Nom_Ville).ToString();
            }
        }

        private void client_modification_Load(object sender, EventArgs e)
        {
            txtbxnumClient.Text = NumClt;
            txtbxNomClient.Text = NomClt;
            txtbxPrenomClient.Text = PrenomClt;
            txtxbxNumTel.Text = TelClt;
            textBox1.Text = EmailClt;
            comboBox1.Text = NomVille;
            getRestVilleCombo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            // traitement si les champs sont vide
            if (txtbxnumClient.Text == "" || txtbxNomClient.Text == "" || txtbxPrenomClient.Text == "" || txtxbxNumTel.Text == "" || textBox1.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Les Champs il sont vide");
                dec.decnx();
            }
            // Le Troisieme traitement si les champs sont tous remplies
            else if (txtbxnumClient.Text != "" || txtbxNomClient.Text != "" || txtbxPrenomClient.Text != "" || txtxbxNumTel.Text != "" || textBox1.Text != "" || comboBox1.Text != "")
            {
          
                */

               var nclt = txtbxnumClient.Text;
               var nomclt = txtbxNomClient.Text;
               var preclt = txtbxPrenomClient.Text;
               var telclt = txtxbxNumTel.Text;
               var emailclt = textBox1.Text;
               int idvil = Convert.ToInt32(comboBox1.SelectedIndex);

                var json = JsonConvert.SerializeObject(new tous_class.ClassClientCRUD(int.Parse(nclt), nomclt, preclt, telclt, emailclt, idvil));
                var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
                HttpClient VillesMod = new HttpClient();
                HttpResponseMessage response = VillesMod.PutAsync("http://localhost:59489/api/ClientCRUD", stringContent).Result;
                response.EnsureSuccessStatusCode();

                MessageBox.Show("Modification réaliser avec succes");
                GClt.getRest();
                this.Close();
            }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

