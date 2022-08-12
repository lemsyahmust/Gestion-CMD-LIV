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
    public partial class Gestion : Form
    {
        public Gestion()
        {
            InitializeComponent();
        }

        private void gestionCategorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if(f.Text == "Gestion_Categorie1")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if(IsOpen == false)
            {
                User_Control.Gestion_Categorie1 f2 = new User_Control.Gestion_Categorie1();
                f2.MdiParent = this;
                f2.Show();  
            }
        }

        private void gestionClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Gestion_Client1")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                User_Control.Gestion_Client1 f3 = new User_Control.Gestion_Client1();
                f3.MdiParent = this;
                f3.Show();
            }
        }

        private void gestionVilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Gestion_Ville1")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                User_Control.Gestion_Ville1 f4 = new User_Control.Gestion_Ville1();
                f4.MdiParent = this;
                f4.Show();
            }
        }

        private void gestionProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Gestion_Produit1")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                User_Control.Gestion_Produit1 f5 = new User_Control.Gestion_Produit1();
                f5.MdiParent = this;
                f5.Show();
            }
        }

        private void gestionCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Gestion_Produit1")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                Interface.commande_ajout cmd_ajout = new Interface.commande_ajout(this);
                cmd_ajout.nomcomm_cmd = label6.Text;
                cmd_ajout.MdiParent = this;
                cmd_ajout.Show();
            }

        }
    }
}
