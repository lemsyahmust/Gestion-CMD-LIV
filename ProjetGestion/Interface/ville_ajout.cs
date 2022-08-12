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
    public partial class ville_ajout : Form
    {
        User_Control.Gestion_Ville1 GUV;

        public ville_ajout(User_Control.Gestion_Ville1 GFormV)
        {
            InitializeComponent();
            this.GUV = GFormV;
        }

        private async void getRest()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://localhost:59489/api/VilleAjouter");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            tous_class.ClassVilleAjout[] villesajout = JsonConvert.DeserializeObject<tous_class.ClassVilleAjout[]>(responseBody);

            int  max;
            int i = 1;
            max = int.Parse(villesajout[0].t.ToString());

            txtbxnumVille.Text = (max + i).ToString();
        }
        
        private void ville_ajout_Load(object sender, EventArgs e)
        {
            getRest();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var yy = txtbxnumVille.Text;
            var pp = txtbxnomVille.Text;

            var json = JsonConvert.SerializeObject(new tous_class.ClassAjoutVilleVraiCLT(int.Parse(yy), pp));
            var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.PostAsync("http://localhost:59489/api/VilleAjouter", stringContent).Result;
            response.EnsureSuccessStatusCode();

            MessageBox.Show("Ajout réaliser avec succes");
            GUV.getRest();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
