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
    public partial class produit_ajout : Form
    {
       User_Control.Gestion_Produit1 GPRO;
     //  tous_class.declaration dec = new tous_class.declaration();

        public produit_ajout(User_Control.Gestion_Produit1 GFormPRO)
        {
            InitializeComponent();
            this.GPRO = GFormPRO;
        }

      /*  public void RempCBXCATEGORIE()
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

        /*     public void IncremIDPRODUIT()
             {
                 try
                 {
                     int max;
                     dec.cnx();
                     dec.cmd.CommandText = "select Max(ID_Produit) from PRODUIT";
                     dec.cmd.Connection = dec.con;
                     max = Convert.ToInt16(dec.cmd.ExecuteScalar());
                     int i = 1;
                     int numcategorie;
                     numcategorie = max + i;
                     txtbxnumProduit.Text = numcategorie.ToString();
                     dec.decnx();
                 }
                 catch (Exception)
                 {
                     MessageBox.Show("Erreur dans L'Incrementation des Numero Produits");
                 }
             }
             */

        private async void getRestinc()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://localhost:59489/api/ProduitCRUD");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            tous_class.ClassProduitinc[] clientsajout = JsonConvert.DeserializeObject<tous_class.ClassProduitinc[]>(responseBody);

            int max;
            int i = 1;
            max = int.Parse(clientsajout[0].t.ToString());
            txtbxnumProduit.Text = (max + i).ToString();
        }

        private void produit_ajout_Load(object sender, EventArgs e)
        {
          //  dec.cnx();
          //  RempCBXCATEGORIE();
            // IncremIDPRODUIT(); 
            getRestinc();
            getRestCatCombo();       
        }

   /*     private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Images Files|*.JPG; *.PNG; *.GIF; *.BMP";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(op.FileName);
            }
        }
        */
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
         }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (txtbxnumProduit.Text == "" || txtbxNomProduit.Text == "" || txtbxQteStock.Text == "" || txtbxprixachat.Text == "" || txtbxprixvente.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Les Champs il sont vide");
                dec.decnx();
            } 
            else if (txtbxnumProduit.Text != "" || txtbxNomProduit.Text != "" || txtbxQteStock.Text != "" || txtbxprixachat.Text != "" || txtbxprixvente.Text != "" || comboBox1.Text != "")
            {
                try
                {
                dec.cnx();
                dec.cmd = new SqlCommand("insert into PRODUIT(ID_Produit,ID_Cat,Nom_Produit,Qte_Stock,Prix_Achat,Prix_Vente,Image_Produit) values(@ID_Produit,@ID_Cat,@Nom_Produit,@Qte_Stock,@Prix_Achat,@Prix_Vente,@Image_Produit)", dec.con);
                dec.cmd.Parameters.Add(new SqlParameter("@ID_Produit", SqlDbType.Int)).Value = txtbxnumProduit.Text;
                dec.cmd.Parameters.Add(new SqlParameter("@ID_Cat", SqlDbType.Int)).Value = comboBox1.SelectedValue;
                dec.cmd.Parameters.Add(new SqlParameter("@Nom_Produit", SqlDbType.VarChar, 50)).Value = txtbxNomProduit.Text;
                dec.cmd.Parameters.Add(new SqlParameter("@Qte_Stock", SqlDbType.Int)).Value = txtbxQteStock.Text;
                dec.cmd.Parameters.Add(new SqlParameter("@Prix_Achat", SqlDbType.VarChar, 50)).Value = txtbxprixachat.Text;
                dec.cmd.Parameters.Add(new SqlParameter("@Prix_Vente", SqlDbType.VarChar, 50)).Value = txtbxprixvente.Text;

                MemoryStream ms = new MemoryStream();
             //   pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] byteImage;
                byteImage = ms.ToArray();
                dec.cmd.Parameters.Add(new SqlParameter("@Image_Produit", SqlDbType.Image)).Value = byteImage;
 
                dec.cmd.ExecuteNonQuery();
                dec.decnx();
                MessageBox.Show("Ajouter realiser avec succes");

                GPRO.remplirGRIDGPRODUIT();
                this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    dec.decnx();
                }
            } */

            var nprd = txtbxnumProduit.Text;
            int idcat = Convert.ToInt32(comboBox1.SelectedIndex);
            var nomprd = txtbxNomProduit.Text;
            var qteprd = txtbxQteStock.Text;
            var prixaprd = txtbxprixachat.Text;
            var prixvprd = txtbxprixvente.Text;
            

            var json = JsonConvert.SerializeObject(new tous_class.ClassProduitAjout(int.Parse(nprd),idcat, nomprd, int.Parse(qteprd), prixaprd, prixvprd));
            var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.PostAsync("http://localhost:59489/api/ProduitCRUD", stringContent).Result;
            response.EnsureSuccessStatusCode();

            MessageBox.Show("Ajout réaliser avec succes");
            GPRO.getRest();
            this.Close();


        }

        private void txtbxprixachat_TextChanged(object sender, EventArgs e)
        {
        
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

        private void txtbxQteStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

    }
}
