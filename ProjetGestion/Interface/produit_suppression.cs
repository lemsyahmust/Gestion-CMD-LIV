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
    public partial class produit_suppression : Form
    {
        User_Control.Gestion_Produit1 GPRODUITSUPP;

        public string NomCategorie;
        public string NumProduit;
        public string NomProduit;
        public string QteProduit;
        public string PrixAchat;
        public string PrixVente;

        public produit_suppression(User_Control.Gestion_Produit1 GFormPRODUITSUPP)
        {
            InitializeComponent();
            this.GPRODUITSUPP = GFormPRODUITSUPP;
        }
       
     /*   public void RempCBXCATEGORIESUPP()
        {
            comboBox1.Items.Clear();
            dec.da = new SqlDataAdapter("select ID_Cat,Nom_Cat from CATEGORIE", dec.con);
            dec.da.Fill(dec.ds, "TABCATEGORIE");
            comboBox1.DataSource = dec.ds.Tables["TABCATEGORIE"];
            comboBox1.ValueMember = dec.ds.Tables["TABCATEGORIE"].Columns[0].ToString();
            comboBox1.DisplayMember = dec.ds.Tables["TABCATEGORIE"].Columns[1].ToString();
        }
        */
        public async void getRestCatCombo()
        {
            //  comboBox1.Items.Clear();

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


        private void produit_suppression_Load(object sender, EventArgs e)
        {
            //dec.cnx();
            //RempCBXCATEGORIESUPP();

            comboBox1.Text = NumProduit;
            txtbxnumProduit.Text = NomCategorie;
            txtbxNomProduit.Text = NomProduit;
            txtbxQteStock.Text = QteProduit;
            txtbxprixachat.Text = PrixAchat;
            txtbxprixvente.Text = PrixVente;
            getRestCatCombo();

            //try
            //{
            //    if (txtbxnumProduit.Text != "")
            //    {
            //        dec.da = new SqlDataAdapter("Select ID_Produit,Image_Produit from PRODUIT where ID_Produit ='" + txtbxnumProduit.Text + "'", dec.con);
            //        dec.da.Fill(dec.dt);
            //        MemoryStream ms = new MemoryStream((byte[])dec.dt.Rows[0]["Image_Produit"]);
            //        pictureBox1.Image = Image.FromStream(ms);
            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Ce Produit ne contient pas de photo");
            //}
         }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog opp = new OpenFileDialog();
            //opp.Filter = "Images Files|*.JPG; *.PNG; *.GIF; *.BMP";
            //if (opp.ShowDialog() == DialogResult.OK)
            //{
            //    pictureBox1.Image = Image.FromFile(opp.FileName);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*try
            {
                if (txtbxnumProduit.Text != "")
                {
                    dec.cnx();
                    dec.cmd.Connection = dec.con;
                    dec.cmd.CommandType = CommandType.Text;
                    dec.cmd.CommandText = "select * from PRODUIT";
                    dec.dr = dec.cmd.ExecuteReader();

                    dec.cmd.CommandText = "delete from PRODUIT where ID_Produit = '" + txtbxnumProduit.Text + "'";
                    dec.dr.Close(); 
                    dec.cmd.ExecuteNonQuery();
                    MessageBox.Show("Suppression réaliser avec success");
                    dec.decnx();

                    GPRODUITSUPP.remplirGRIDGPRODUIT();

                    this.Close();
                }
            }

            catch (Exception )
            {
                MessageBox.Show("Impossible de supprimer ce Produit il a une attachement avec un ou plusieur Facture");
                dec.decnx();

            }*/

            var nclt = txtbxnumProduit.Text;
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.DeleteAsync("http://localhost:59489/api/ProduitCRUD/" + nclt).Result;
            response.EnsureSuccessStatusCode();

            MessageBox.Show("Suppression réaliser avec succes");
            GPRODUITSUPP.getRest();
            this.Close();


        }

    }
    }


