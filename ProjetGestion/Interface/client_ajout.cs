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
    public partial class client_ajout : Form
    {
        User_Control.Gestion_Client1 GC;
       // tous_class.declaration dec = new tous_class.declaration();

        public client_ajout(User_Control.Gestion_Client1 GFormC)
        {
            InitializeComponent();
            this.GC = GFormC;
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

        private async void getRest()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://localhost:59489/api/ClientCRUD");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            tous_class.ClientAjout[] clientsajout = JsonConvert.DeserializeObject<tous_class.ClientAjout[]>(responseBody);

            int max;
            int i = 1;
            max = int.Parse(clientsajout[0].t.ToString());
            txtbxnumClient.Text = (max + i).ToString();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void client_ajout_Load(object sender, EventArgs e)
        {
            getRestVilleCombo();
            getRest();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nclt = txtbxnumClient.Text;
            var nomclt = txtbxNomClient.Text;
            var preclt = txtbxPrenomClient.Text;
            var telclt = txtxbxNumTel.Text;
            var emailclt = textBox1.Text;
            int idvil = Convert.ToInt32(comboBox1.SelectedIndex);

            var json = JsonConvert.SerializeObject(new tous_class.ClassClientCRUD(int.Parse(nclt), nomclt, preclt, telclt, emailclt, idvil));
            var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.PostAsync("http://localhost:59489/api/ClientCRUD", stringContent).Result;
            response.EnsureSuccessStatusCode();

            MessageBox.Show("Ajout réaliser avec succes");
            GC.getRest();
            this.Close();
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
