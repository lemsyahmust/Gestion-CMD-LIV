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
    public partial class Form1 : Form
    {

     //  Interface.livraison_ajout liv;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //gestion_Ville1.Visible = false;
            //gestion_Client1.Visible = false;
            //gestion_Fournisseur1.Visible = false;
            //gestion_Categorie1.Visible = false;
            //gestion_Produit1.Visible = false;
            //gestion_Users1.Visible = true;
            
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;

          //  gestion_Users1.BringToFront();

            panel5.Visible = false;
            btnajout_cmd.Visible = false;
            btnImpression_cmd.Visible = false;

            panel6.Visible = false;
            btnlivrer_ajout.Visible = false;
            btnlivrer_impression.Visible = false;

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

        //    gestion_Ville1.BringToFront();

            panel5.Visible = false;
            btnajout_cmd.Visible = false;
            btnImpression_cmd.Visible = false;

            panel6.Visible = false;
            btnlivrer_ajout.Visible = false;
            btnlivrer_impression.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //gestion_Ville1.Visible = false;
            //gestion_Client1.Visible = false;
       //     gestion_Fournisseur1.Visible = false;
            //gestion_Users1.Visible = false;
            //gestion_Produit1.Visible = false;
            //gestion_Categorie1.Visible = true; 

            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;

         //   gestion_Categorie1.BringToFront();
            panel5.Visible = false;
            btnajout_cmd.Visible = false;
            btnImpression_cmd.Visible = false;

            panel6.Visible = false;
            btnlivrer_ajout.Visible = false;
            btnlivrer_impression.Visible = false;
        }

        private void gestion_Users1_Load(object sender, EventArgs e)
        {
            //gestion_Ville1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

         //   gestion_Ville1.Visible = false;
            //gestion_Users1.Visible = false;
            //gestion_Client1.Visible = false;
            //gestion_Fournisseur1.Visible = false;
            //gestion_Categorie1.Visible = false;
            //gestion_Produit1.Visible = false;

            panel5.Visible = false;
            btnajout_cmd.Visible = false;
            btnImpression_cmd.Visible = false;

            panel6.Visible = false;
            btnlivrer_ajout.Visible = false;
            btnlivrer_impression.Visible = false;
      }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {

            /*
            gestion_Users1.Visible = false;
            gestion_Client1.Visible = false;
            gestion_Fournisseur1.Visible = false;

            ajoutUser2.Visible = true;

           SidePanel.Height = button3.Height;
           SidePanel.Top = button3.Top;

            ajoutUser2.BringToFront();

          */
        }

        private void button12_Click(object sender, EventArgs e)
        {
            

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
           
        }

        //private void button10_Click(object sender, EventArgs e)
        ////{
        ////    Interface.Identification login = new Interface.Identification();
        ////    login.Show();
        ////    this.Close();
        //}

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    //gestion_Ville1.Visible = false;
        //    //gestion_Client1.Visible = false;
        //    //gestion_Users1.Visible = false;
        //    //gestion_Categorie1.Visible = false;
        //    //gestion_Produit1.Visible = false;
        //    //gestion_Fournisseur1.Visible = true;
            
        //    SidePanel.Height = button6.Height;
        //    SidePanel.Top = button6.Top;

        // //   gestion_Fournisseur1.BringToFront();

        //    panel5.Visible = false;
        //    btnajout_cmd.Visible = false;
        //    btnImpression_cmd.Visible = false;

        //    panel6.Visible = false;
        //    btnlivrer_ajout.Visible = false;
        //    btnlivrer_impression.Visible = false;

        //}

        //private void button5_Click(object sender, EventArgs e)
        //{
        //    //gestion_Users1.Visible = false;
        //    //gestion_Ville1.Visible = false;
        //    //gestion_Fournisseur1.Visible = false;
        //    //gestion_Categorie1.Visible = false;
        //    //gestion_Produit1.Visible = false;
        //    //gestion_Client1.Visible = true;

        //    SidePanel.Height = button5.Height;
        //    SidePanel.Top = button5.Top;

        //   // gestion_Client1.BringToFront();

        //    panel5.Visible = false;
        //    btnajout_cmd.Visible = false;
        //    btnImpression_cmd.Visible = false;

        //    panel6.Visible = false;
        //    btnlivrer_ajout.Visible = false;
        //    btnlivrer_impression.Visible = false;

        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    //gestion_Ville1.Visible = false;
        //    //gestion_Client1.Visible = false;
        //    //gestion_Fournisseur1.Visible = false;
        //    //gestion_Users1.Visible = false;
        //    //gestion_Categorie1.Visible = false;
        //    //gestion_Produit1.Visible = true;
          

        //    SidePanel.Height = button2.Height;
        //    SidePanel.Top = button2.Top;

        //    panel5.Visible = false;
        //    btnajout_cmd.Visible = false;
        //    btnImpression_cmd.Visible = false;

        //    panel6.Visible = false;
        //    btnlivrer_ajout.Visible = false;
        //    btnlivrer_impression.Visible = false;

        //    // gestion_Produit1.BringToFront();
        //}

        //private void button8_Click(object sender, EventArgs e)
        //{
        //    //gestion_Ville1.Visible = false;
        //    //gestion_Client1.Visible = false;
        //    //gestion_Users1.Visible = false;
        //    //gestion_Categorie1.Visible = false;
        //    //gestion_Fournisseur1.Visible = false;
        //    //gestion_Produit1.Visible = false;

        //    panel5.Visible = false;
        //    btnajout_cmd.Visible = false;
        //    btnImpression_cmd.Visible = false;

        //    panel6.Visible = true;
        //    btnlivrer_ajout.Visible = true;
        //    btnlivrer_impression.Visible = true;

        //    SidePanel.Height = button8.Height;
        //    SidePanel.Top = button8.Top;
        //}

        //private void button7_Click(object sender, EventArgs e)
        //{
        //    //gestion_Ville1.Visible = false;
        //    //gestion_Client1.Visible = false;
        //    //gestion_Users1.Visible = false;
        //    //gestion_Categorie1.Visible = false;
        //    //gestion_Fournisseur1.Visible = false;
        //    //gestion_Produit1.Visible = false;

        //    SidePanel.Height = button7.Height;
        //    SidePanel.Top = button7.Top;

        //    panel5.Visible = true;
        //    btnajout_cmd.Visible = true;
        //    btnImpression_cmd.Visible = true;

        //    panel6.Visible = false;
        //    btnlivrer_ajout.Visible = false;
        //    btnlivrer_impression.Visible = false;
        //}

        //private void button11_Click_2(object sender, EventArgs e)
        //{

        //}

        //private void button12_Click_1(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

        //private void button9_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnajout_cmd_Click(object sender, EventArgs e)
        //{
        //    Interface.commande_ajout cmd_ajout = new Interface.commande_ajout(this);

        //    SidePanel.Height = button7.Height;
        //    SidePanel.Top = button7.Top;

        //    cmd_ajout.nomcomm_cmd = label6.Text;
        //    cmd_ajout.ShowDialog();

        //    panel5.Visible = false;
        //    btnajout_cmd.Visible = false;
        //    btnImpression_cmd.Visible = false;

        //    panel6.Visible = false;
        //    btnlivrer_ajout.Visible = false;
        //    btnlivrer_impression.Visible = false;

            //gestion_Ville1.Visible = false;
            //gestion_Users1.Visible = false;
            //gestion_Client1.Visible = false;
            //gestion_Fournisseur1.Visible = false;
            //gestion_Categorie1.Visible = false;
            //gestion_Produit1.Visible = false;
        }

        //private void btnImpression_cmd_Click(object sender, EventArgs e)
        //{
        //    Interface.comande_impression imp_cmd = new Interface.comande_impression();

        //    SidePanel.Height = button7.Height;
        //    SidePanel.Top = button7.Top;

        //    imp_cmd.ShowDialog();

        //    panel5.Visible = false;
        //    btnajout_cmd.Visible = false;
        //    btnImpression_cmd.Visible = false;

        //    panel6.Visible = false;
        //    btnlivrer_ajout.Visible = false;
        //    btnlivrer_impression.Visible = false;

            //gestion_Ville1.Visible = false;
            //gestion_Users1.Visible = false;
            //gestion_Client1.Visible = false;
            //gestion_Fournisseur1.Visible = false;
            //gestion_Categorie1.Visible = false;
            //gestion_Produit1.Visible = false;
        }

        //private void btnlivrer_ajout_Click(object sender, EventArgs e)
        //{
            //gestion_Ville1.Visible = false;
            //gestion_Users1.Visible = false;
            //gestion_Client1.Visible = false;
            //gestion_Fournisseur1.Visible = false;
          //  gestion_Categorie1.Visible = false;
            //gestion_Produit1.Visible = false;

            //panel6.Visible = false;
            //btnlivrer_ajout.Visible = false;
            //btnlivrer_impression.Visible = false;

            //panel5.Visible = false;
            //btnajout_cmd.Visible = false;
            //btnImpression_cmd.Visible = false;

            //SidePanel.Height = button8.Height;
            //SidePanel.Top = button8.Top;

            //Interface.livraison_ajout ffee = new Interface.livraison_ajout(this);
            //ffee.nomcomm = label6.Text;
            //ffee.ShowDialog();
        //}

        //private void btnlivrer_impression_Click(object sender, EventArgs e)
        //{
        //    Interface.livraison_impression imp_Liv = new Interface.livraison_impression();

        //    SidePanel.Height = button8.Height;
        //    SidePanel.Top = button8.Top;

        //    imp_Liv.ShowDialog();

        //    panel5.Visible = false;
        //    btnajout_cmd.Visible = false;
        //    btnImpression_cmd.Visible = false;

        //    panel6.Visible = false;
        //    btnlivrer_ajout.Visible = false;
        //    btnlivrer_impression.Visible = false;

        //    //gestion_Ville1.Visible = false;
        //    //gestion_Users1.Visible = false;
        //    //gestion_Client1.Visible = false;
        //    //gestion_Fournisseur1.Visible = false;
        //    //gestion_Categorie1.Visible = false;
        //    //gestion_Produit1.Visible = false;
        //}
//    }
//}
