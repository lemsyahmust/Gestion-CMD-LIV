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
    public partial class ville_modification : Form
    {
        User_Control.Gestion_Ville1 GV;
       // tous_class.declaration dec = new tous_class.declaration();

        public string IDVille;
        public string NomVille;
       
        public ville_modification(User_Control.Gestion_Ville1 GFormV)
        {
            InitializeComponent();
            this.GV = GFormV;
        }
        

        private void ville_modification_Load(object sender, EventArgs e)
        {
          //  dec.cnx();
            txtbxnumville.Text = IDVille;
            txtbxnomVille.Text = NomVille;
        }

        private void btnAnnulerUSERS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifUSERS_Click(object sender, EventArgs e)
        {
              try
              {
                  if (txtbxnumville.Text == "" || txtbxnomVille.Text == "")
                  {
                      MessageBox.Show("Les Champs il sont vide");    
                  }
                  else if (txtbxnumville.Text != "" || txtbxnomVille.Text != "")
                  {
                    var yy = txtbxnumville.Text;
                    var pp = txtbxnomVille.Text;

                    var json = JsonConvert.SerializeObject(new tous_class.ClassAjoutVilleVraiCLT(int.Parse(yy), pp));
                    var stringContent = new StringContent(json, UnicodeEncoding.UTF8, "application/json");
                    HttpClient VillesMod = new HttpClient();
                    HttpResponseMessage response = VillesMod.PutAsync("http://localhost:59489/api/VilleAjouter", stringContent).Result;
                    response.EnsureSuccessStatusCode();

                    MessageBox.Show("Modification réaliser avec succes");
                    GV.getRest();
                    this.Close();
                }           
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
