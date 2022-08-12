using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGestion
{
    public partial class AppGestion : Form
    {
        public AppGestion()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //gestion_Users1.Visible = false;
            //gestion_Client1.Visible = false;
            //gestion_Fournisseur1.Visible = false;
            //gestion_Categorie1.Visible = false;
            //gestion_Produit1.Visible = false;
            //gestion_Ville1.Visible = true;

            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;

            //gestion_Ville1.BringToFront();

            //panel5.Visible = false;
            //btnajout_cmd.Visible = false;
            //btnImpression_cmd.Visible = false;

            //panel6.Visible = false;
            //btnlivrer_ajout.Visible = false;
            //btnlivrer_impression.Visible = false;
        }

        private void AppGestion_Load(object sender, EventArgs e)
        {
            //gestion_Ville1.Visible = false;
            //gestion_Users1.Visible = false;
            //gestion_Client1.Visible = false;
            //gestion_Fournisseur1.Visible = false;
            //gestion_Categorie1.Visible = false;
            //gestion_Produit1.Visible = false;

            //panel5.Visible = false;
            //btnajout_cmd.Visible = false;
            //btnImpression_cmd.Visible = false;

            //panel6.Visible = false;
            //btnlivrer_ajout.Visible = false;
            //btnlivrer_impression.Visible = false;
        }
    }
}
