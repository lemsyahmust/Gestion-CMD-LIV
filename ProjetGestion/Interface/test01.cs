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


namespace ProjetGestion
{
    public partial class test01 : Form
    {
        // CLS_LOGIN user = new CLS_LOGIN();

        public string Identidiant;
        public string MotPasse;
        public string UserType;
        
        public test01()
        {
            InitializeComponent();
        }
        SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-BETDQGE;Initial Catalog=GestionProjet;Integrated Security=True;");
        SqlCommand cmd = new SqlCommand();

        //SqlDataReader dr;
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        

        private void miseAJourToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtbxNomUsers.Text == "" || txtbxmotpasse.Text == "" || txtbxconfmotpasse.Text == "" || cbxtypeusers.Text == "")
            {
                MessageBox.Show(" Veuillez remplir les champs ", "avertissement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (button1.Text == "Ajouter")
            {
                // users.Ajout_USER(txtbxNomUsers.Text, txtbxmotpasse.Text, cbxtypeusers.Text);
                //users.AJOUT_USER(txtbxNomUsers.Text, txtbxmotpasse.Text, cbxtypeusers.SelectedText);
                MessageBox.Show("L'utilisateur a été créé avec succès", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            /* else if (button1.Text == "Mise à Jour")
            {
                users.Modif_USER(txtbxNomUsers.Text, txtbxmotpasse.Text, cbxtypeusers.Text);
                MessageBox.Show("Il a Mise à Jour avec succès", "Processus Mise à Jour", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            */

            txtbxNomUsers.Clear();
            txtbxmotpasse.Clear();
            txtbxconfmotpasse.Clear();
            cbxtypeusers.Text = null;
            txtbxNomUsers.Focus();
        }

        private void test01_Load(object sender, EventArgs e)
        {

            txtbxNomUsers.Text = Identidiant;
            txtbxmotpasse.Text = MotPasse;
            txtbxconfmotpasse.Text = MotPasse;
            cbxtypeusers.Text = UserType;



            try
            {
                da = new SqlDataAdapter("select * from USERS", cnx);
                da.Fill(dt);
                //*****remplir dataGridView1 apartir du datatable
                dataGridView1.DataSource = dt;

               
            //*****pour changer le titre de cahque colonne 
            dataGridView1.Columns[0].HeaderText = "Identifiant";
            dataGridView1.Columns[1].HeaderText = "PassW";
            dataGridView1.Columns[2].HeaderText = "Type";
           

      

        cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }

