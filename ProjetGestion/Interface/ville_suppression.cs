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
    public partial class ville_suppression : Form
    {
        User_Control.Gestion_Ville1 GVV;

        public string IDVille;
        public string NOMVille;

        public ville_suppression(User_Control.Gestion_Ville1 GFormVV)
        {
            InitializeComponent();
            this.GVV = GFormVV;
        }

        private void ville_suppression_Load(object sender, EventArgs e)
        {
            txtbxnumVille.Text = IDVille;
            txtbxnomVille.Text = NOMVille; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var yy = txtbxnumVille.Text;
            var pp = txtbxnomVille.Text;

            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.DeleteAsync("http://localhost:59489/api/VilleAjouter/" + int.Parse(yy)).Result;
            response.EnsureSuccessStatusCode();
            
            MessageBox.Show("Suppression réaliser avec succes");
            GVV.getRest();
            this.Close();
        }
    }
}
