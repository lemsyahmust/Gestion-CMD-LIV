namespace ProjetGestion
{
    partial class Gestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionCategorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionVilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.gestionCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionCategorieToolStripMenuItem,
            this.gestionClientToolStripMenuItem,
            this.gestionVilleToolStripMenuItem,
            this.gestionProduitToolStripMenuItem,
            this.gestionCommandeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1356, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionCategorieToolStripMenuItem
            // 
            this.gestionCategorieToolStripMenuItem.Name = "gestionCategorieToolStripMenuItem";
            this.gestionCategorieToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.gestionCategorieToolStripMenuItem.Text = "Gestion Categorie";
            this.gestionCategorieToolStripMenuItem.Click += new System.EventHandler(this.gestionCategorieToolStripMenuItem_Click);
            // 
            // gestionClientToolStripMenuItem
            // 
            this.gestionClientToolStripMenuItem.Name = "gestionClientToolStripMenuItem";
            this.gestionClientToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.gestionClientToolStripMenuItem.Text = "Gestion Client";
            this.gestionClientToolStripMenuItem.Click += new System.EventHandler(this.gestionClientToolStripMenuItem_Click);
            // 
            // gestionVilleToolStripMenuItem
            // 
            this.gestionVilleToolStripMenuItem.Name = "gestionVilleToolStripMenuItem";
            this.gestionVilleToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.gestionVilleToolStripMenuItem.Text = "Gestion Ville";
            this.gestionVilleToolStripMenuItem.Click += new System.EventHandler(this.gestionVilleToolStripMenuItem_Click);
            // 
            // gestionProduitToolStripMenuItem
            // 
            this.gestionProduitToolStripMenuItem.Name = "gestionProduitToolStripMenuItem";
            this.gestionProduitToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.gestionProduitToolStripMenuItem.Text = "Gestion Produit";
            this.gestionProduitToolStripMenuItem.Click += new System.EventHandler(this.gestionProduitToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1291, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Lemsyah";
            // 
            // gestionCommandeToolStripMenuItem
            // 
            this.gestionCommandeToolStripMenuItem.Name = "gestionCommandeToolStripMenuItem";
            this.gestionCommandeToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.gestionCommandeToolStripMenuItem.Text = "Gestion Commande";
            this.gestionCommandeToolStripMenuItem.Click += new System.EventHandler(this.gestionCommandeToolStripMenuItem_Click);
            // 
            // Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 681);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Gestion";
            this.Text = "Gestioncs";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionCategorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionVilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionProduitToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem gestionCommandeToolStripMenuItem;
    }
}