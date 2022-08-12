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
    public partial class client_suppression : Form
    {
        User_Control.Gestion_Client1 GCLT;
   //     tous_class.declaration dec = new tous_class.declaration();

        public string NumClt;
        public string NomClt;
        public string PrenomClt;
        public string TelClt;
        public string EmailClt;
        public string NomVille;

        public client_suppression(User_Control.Gestion_Client1 GFormCLT)
        {
            InitializeComponent();
            this.GCLT = GFormCLT;
        }
  
/*        public void RempCBXVilleModi()
        {
            comboBox1.Items.Clear();
            dec.da = new SqlDataAdapter("select ID_Ville,Nom_Ville from VILLE", dec.con);
            dec.da.Fill(dec.ds, "TABVille");
            comboBox1.DataSource = dec.ds.Tables["TABVille"];
            comboBox1.ValueMember = dec.ds.Tables["TABVille"].Columns[0].ToString();
            comboBox1.DisplayMember = dec.ds.Tables["TABVille"].Columns[1].ToString();
        }
*/
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

        private void client_suppression_Load(object sender, EventArgs e)
        {
            // dec.cnx();
            //RempCBXVilleModi();
            getRestVilleCombo();

            txtbxnumClient.Text = NumClt;
            txtbxNomClient.Text = NomClt;
            txtbxPrenomClient.Text = PrenomClt;
            txtxbxNumTel.Text = TelClt;
            textBox1.Text = EmailClt;
            comboBox1.Text = NomVille;
      }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*   try
               {
                   if (txtbxnumClient.Text != "")
                   {
                       dec.cmd.Connection = dec.con;
                       dec.cmd.CommandType = CommandType.Text;
                       dec.cmd.CommandText = "select * from CLIENT";
                       dec.cnx();

                       dec.dr = dec.cmd.ExecuteReader();

                       dec.cmd.CommandText = "delete from CLIENT where ID_Clt = '" + txtbxnumClient.Text + "'";
                       dec.dr.Close(); 
                       dec.cmd.ExecuteNonQuery();
                       MessageBox.Show("Suppression réaliser avec success");
                       dec.decnx();

                     //  GCLT.RempGRIDClient();
                       this.Close();
                   }
               }

               catch (Exception)
               {
                   MessageBox.Show("Impossible de supprimer ce Client il a déjà acheter des produits");
                   dec.decnx();

               }
               */
            var nclt = txtbxnumClient.Text;
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.DeleteAsync("http://localhost:59489/api/ClientCRUD/" + nclt).Result;
            response.EnsureSuccessStatusCode();

            MessageBox.Show("Suppression réaliser avec succes");
            GCLT.getRest();
            this.Close();

        }
    }
}
