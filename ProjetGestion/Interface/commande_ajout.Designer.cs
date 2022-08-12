namespace ProjetGestion.Interface
{
    partial class commande_ajout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(commande_ajout));
            this.groupBoxFact = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnValiderFacture = new System.Windows.Forms.Button();
            this.btnAnnulerFACTURE = new System.Windows.Forms.Button();
            this.txtbxNomCOMM_cmd = new System.Windows.Forms.TextBox();
            this.txtbxNumFACT_cmd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxCLT = new System.Windows.Forms.GroupBox();
            this.txtbxville = new System.Windows.Forms.TextBox();
            this.btnClickClt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxnumClt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbxNomClt = new System.Windows.Forms.TextBox();
            this.txtbxemailClt = new System.Windows.Forms.TextBox();
            this.txtbxPrenomClt = new System.Windows.Forms.TextBox();
            this.txtxbxNumTelClt = new System.Windows.Forms.TextBox();
            this.groupBoxProduit = new System.Windows.Forms.GroupBox();
            this.txtbxcategorie = new System.Windows.Forms.TextBox();
            this.txtxbxTotal = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnterminerProduit = new System.Windows.Forms.Button();
            this.txtbxQteVendu = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnClickPRD = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtbxnumProduit = new System.Windows.Forms.TextBox();
            this.btnValiderProduit = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtbxremise = new System.Windows.Forms.TextBox();
            this.txtbxprixVente = new System.Windows.Forms.TextBox();
            this.txtbxQteStock = new System.Windows.Forms.TextBox();
            this.txtbxNomProduit = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxPaiement = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnValiderPaiement = new System.Windows.Forms.Button();
            this.rdoNONpayer = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rdopayer = new System.Windows.Forms.RadioButton();
            this.txtbxRestClt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbxAvanceClt = new System.Windows.Forms.TextBox();
            this.ID_Produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_Fact_cmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qte_Vendu_cmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qte_Stock_cmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix_Vente_cmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Montant_cmd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxFact.SuspendLayout();
            this.groupBoxCLT.SuspendLayout();
            this.groupBoxProduit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxPaiement.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFact
            // 
            this.groupBoxFact.Controls.Add(this.dateTimePicker1);
            this.groupBoxFact.Controls.Add(this.btnValiderFacture);
            this.groupBoxFact.Controls.Add(this.btnAnnulerFACTURE);
            this.groupBoxFact.Controls.Add(this.txtbxNomCOMM_cmd);
            this.groupBoxFact.Controls.Add(this.txtbxNumFACT_cmd);
            this.groupBoxFact.Controls.Add(this.label8);
            this.groupBoxFact.Controls.Add(this.label9);
            this.groupBoxFact.Controls.Add(this.label10);
            this.groupBoxFact.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFact.Location = new System.Drawing.Point(710, 134);
            this.groupBoxFact.Name = "groupBoxFact";
            this.groupBoxFact.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxFact.Size = new System.Drawing.Size(617, 166);
            this.groupBoxFact.TabIndex = 86;
            this.groupBoxFact.TabStop = false;
            this.groupBoxFact.Text = "Donnée Facture";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(255, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 32);
            this.dateTimePicker1.TabIndex = 85;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnValiderFacture
            // 
            this.btnValiderFacture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnValiderFacture.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderFacture.ForeColor = System.Drawing.Color.White;
            this.btnValiderFacture.Location = new System.Drawing.Point(489, 41);
            this.btnValiderFacture.Name = "btnValiderFacture";
            this.btnValiderFacture.Size = new System.Drawing.Size(109, 44);
            this.btnValiderFacture.TabIndex = 87;
            this.btnValiderFacture.Text = "Valider";
            this.btnValiderFacture.UseVisualStyleBackColor = false;
            this.btnValiderFacture.Click += new System.EventHandler(this.btnValiderFacture_Click);
            // 
            // btnAnnulerFACTURE
            // 
            this.btnAnnulerFACTURE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAnnulerFACTURE.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerFACTURE.ForeColor = System.Drawing.Color.White;
            this.btnAnnulerFACTURE.Location = new System.Drawing.Point(489, 95);
            this.btnAnnulerFACTURE.Name = "btnAnnulerFACTURE";
            this.btnAnnulerFACTURE.Size = new System.Drawing.Size(109, 44);
            this.btnAnnulerFACTURE.TabIndex = 86;
            this.btnAnnulerFACTURE.Text = "Annuler";
            this.btnAnnulerFACTURE.UseVisualStyleBackColor = false;
            this.btnAnnulerFACTURE.Click += new System.EventHandler(this.btnAnnulerFACTURE_Click);
            // 
            // txtbxNomCOMM_cmd
            // 
            this.txtbxNomCOMM_cmd.Enabled = false;
            this.txtbxNomCOMM_cmd.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNomCOMM_cmd.Location = new System.Drawing.Point(255, 113);
            this.txtbxNomCOMM_cmd.Name = "txtbxNomCOMM_cmd";
            this.txtbxNomCOMM_cmd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtbxNomCOMM_cmd.Size = new System.Drawing.Size(197, 32);
            this.txtbxNomCOMM_cmd.TabIndex = 81;
            // 
            // txtbxNumFACT_cmd
            // 
            this.txtbxNumFACT_cmd.Enabled = false;
            this.txtbxNumFACT_cmd.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNumFACT_cmd.Location = new System.Drawing.Point(255, 31);
            this.txtbxNumFACT_cmd.Name = "txtbxNumFACT_cmd";
            this.txtbxNumFACT_cmd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtbxNumFACT_cmd.Size = new System.Drawing.Size(197, 32);
            this.txtbxNumFACT_cmd.TabIndex = 79;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 23);
            this.label8.TabIndex = 77;
            this.label8.Text = "Date Facture";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 23);
            this.label9.TabIndex = 76;
            this.label9.Text = "Nom Commerciale";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(44, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 23);
            this.label10.TabIndex = 78;
            this.label10.Text = "Numero Facture";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(31, 867);
            this.panel2.TabIndex = 85;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1392, 27);
            this.panel1.TabIndex = 84;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(486, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(390, 35);
            this.label5.TabIndex = 87;
            this.label5.Text = "Ajouter Une Commande";
            // 
            // groupBoxCLT
            // 
            this.groupBoxCLT.Controls.Add(this.txtbxville);
            this.groupBoxCLT.Controls.Add(this.btnClickClt);
            this.groupBoxCLT.Controls.Add(this.label1);
            this.groupBoxCLT.Controls.Add(this.label2);
            this.groupBoxCLT.Controls.Add(this.label6);
            this.groupBoxCLT.Controls.Add(this.label3);
            this.groupBoxCLT.Controls.Add(this.txtbxnumClt);
            this.groupBoxCLT.Controls.Add(this.label4);
            this.groupBoxCLT.Controls.Add(this.label7);
            this.groupBoxCLT.Controls.Add(this.txtbxNomClt);
            this.groupBoxCLT.Controls.Add(this.txtbxemailClt);
            this.groupBoxCLT.Controls.Add(this.txtbxPrenomClt);
            this.groupBoxCLT.Controls.Add(this.txtxbxNumTelClt);
            this.groupBoxCLT.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCLT.Location = new System.Drawing.Point(47, 135);
            this.groupBoxCLT.Name = "groupBoxCLT";
            this.groupBoxCLT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxCLT.Size = new System.Drawing.Size(651, 316);
            this.groupBoxCLT.TabIndex = 88;
            this.groupBoxCLT.TabStop = false;
            this.groupBoxCLT.Text = "Donnée Client";
            this.groupBoxCLT.Visible = false;
            // 
            // txtbxville
            // 
            this.txtbxville.Enabled = false;
            this.txtbxville.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxville.Location = new System.Drawing.Point(232, 245);
            this.txtbxville.Multiline = true;
            this.txtbxville.Name = "txtbxville";
            this.txtbxville.Size = new System.Drawing.Size(248, 32);
            this.txtbxville.TabIndex = 82;
            this.txtbxville.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClickClt
            // 
            this.btnClickClt.BackColor = System.Drawing.Color.White;
            this.btnClickClt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClickClt.BackgroundImage")));
            this.btnClickClt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClickClt.Location = new System.Drawing.Point(420, 50);
            this.btnClickClt.Name = "btnClickClt";
            this.btnClickClt.Size = new System.Drawing.Size(60, 32);
            this.btnClickClt.TabIndex = 81;
            this.btnClickClt.UseVisualStyleBackColor = false;
            this.btnClickClt.Click += new System.EventHandler(this.btnClickClt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 68;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 67;
            this.label2.Text = "Prenom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 75;
            this.label6.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 66;
            this.label3.Text = "Telephone";
            // 
            // txtbxnumClt
            // 
            this.txtbxnumClt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtbxnumClt.Enabled = false;
            this.txtbxnumClt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxnumClt.Location = new System.Drawing.Point(232, 50);
            this.txtbxnumClt.Multiline = true;
            this.txtbxnumClt.Name = "txtbxnumClt";
            this.txtbxnumClt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtbxnumClt.Size = new System.Drawing.Size(182, 32);
            this.txtbxnumClt.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 65;
            this.label4.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(90, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 23);
            this.label7.TabIndex = 78;
            this.label7.Text = "Ville";
            // 
            // txtbxNomClt
            // 
            this.txtbxNomClt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtbxNomClt.Enabled = false;
            this.txtbxNomClt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNomClt.Location = new System.Drawing.Point(232, 87);
            this.txtbxNomClt.Multiline = true;
            this.txtbxNomClt.Name = "txtbxNomClt";
            this.txtbxNomClt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtbxNomClt.Size = new System.Drawing.Size(248, 32);
            this.txtbxNomClt.TabIndex = 71;
            // 
            // txtbxemailClt
            // 
            this.txtbxemailClt.Enabled = false;
            this.txtbxemailClt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxemailClt.Location = new System.Drawing.Point(232, 203);
            this.txtbxemailClt.Multiline = true;
            this.txtbxemailClt.Name = "txtbxemailClt";
            this.txtbxemailClt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtbxemailClt.Size = new System.Drawing.Size(248, 32);
            this.txtbxemailClt.TabIndex = 77;
            // 
            // txtbxPrenomClt
            // 
            this.txtbxPrenomClt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtbxPrenomClt.Enabled = false;
            this.txtbxPrenomClt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPrenomClt.Location = new System.Drawing.Point(232, 126);
            this.txtbxPrenomClt.Multiline = true;
            this.txtbxPrenomClt.Name = "txtbxPrenomClt";
            this.txtbxPrenomClt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtbxPrenomClt.Size = new System.Drawing.Size(248, 32);
            this.txtbxPrenomClt.TabIndex = 70;
            // 
            // txtxbxNumTelClt
            // 
            this.txtxbxNumTelClt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtxbxNumTelClt.Enabled = false;
            this.txtxbxNumTelClt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxbxNumTelClt.Location = new System.Drawing.Point(232, 164);
            this.txtxbxNumTelClt.Multiline = true;
            this.txtxbxNumTelClt.Name = "txtxbxNumTelClt";
            this.txtxbxNumTelClt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtxbxNumTelClt.Size = new System.Drawing.Size(248, 32);
            this.txtxbxNumTelClt.TabIndex = 69;
            // 
            // groupBoxProduit
            // 
            this.groupBoxProduit.Controls.Add(this.txtbxcategorie);
            this.groupBoxProduit.Controls.Add(this.txtxbxTotal);
            this.groupBoxProduit.Controls.Add(this.label20);
            this.groupBoxProduit.Controls.Add(this.btnterminerProduit);
            this.groupBoxProduit.Controls.Add(this.txtbxQteVendu);
            this.groupBoxProduit.Controls.Add(this.label19);
            this.groupBoxProduit.Controls.Add(this.btnClickPRD);
            this.groupBoxProduit.Controls.Add(this.label15);
            this.groupBoxProduit.Controls.Add(this.txtbxnumProduit);
            this.groupBoxProduit.Controls.Add(this.btnValiderProduit);
            this.groupBoxProduit.Controls.Add(this.label13);
            this.groupBoxProduit.Controls.Add(this.label14);
            this.groupBoxProduit.Controls.Add(this.txtbxremise);
            this.groupBoxProduit.Controls.Add(this.txtbxprixVente);
            this.groupBoxProduit.Controls.Add(this.txtbxQteStock);
            this.groupBoxProduit.Controls.Add(this.txtbxNomProduit);
            this.groupBoxProduit.Controls.Add(this.label16);
            this.groupBoxProduit.Controls.Add(this.label17);
            this.groupBoxProduit.Controls.Add(this.label18);
            this.groupBoxProduit.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProduit.Location = new System.Drawing.Point(47, 456);
            this.groupBoxProduit.Name = "groupBoxProduit";
            this.groupBoxProduit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxProduit.Size = new System.Drawing.Size(1280, 177);
            this.groupBoxProduit.TabIndex = 89;
            this.groupBoxProduit.TabStop = false;
            this.groupBoxProduit.Text = "Donnée Produit";
            this.groupBoxProduit.Visible = false;
            // 
            // txtbxcategorie
            // 
            this.txtbxcategorie.Enabled = false;
            this.txtbxcategorie.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxcategorie.Location = new System.Drawing.Point(129, 73);
            this.txtbxcategorie.Name = "txtbxcategorie";
            this.txtbxcategorie.Size = new System.Drawing.Size(175, 32);
            this.txtbxcategorie.TabIndex = 89;
            this.txtbxcategorie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtxbxTotal
            // 
            this.txtxbxTotal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtxbxTotal.Enabled = false;
            this.txtxbxTotal.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxbxTotal.Location = new System.Drawing.Point(877, 110);
            this.txtxbxTotal.Multiline = true;
            this.txtxbxTotal.Name = "txtxbxTotal";
            this.txtxbxTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtxbxTotal.Size = new System.Drawing.Size(175, 32);
            this.txtxbxTotal.TabIndex = 88;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Cursor = System.Windows.Forms.Cursors.Default;
            this.label20.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(717, 113);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 23);
            this.label20.TabIndex = 87;
            this.label20.Text = "Totale";
            // 
            // btnterminerProduit
            // 
            this.btnterminerProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnterminerProduit.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnterminerProduit.ForeColor = System.Drawing.Color.White;
            this.btnterminerProduit.Location = new System.Drawing.Point(526, 114);
            this.btnterminerProduit.Name = "btnterminerProduit";
            this.btnterminerProduit.Size = new System.Drawing.Size(125, 40);
            this.btnterminerProduit.TabIndex = 86;
            this.btnterminerProduit.Text = "Terminer";
            this.btnterminerProduit.UseVisualStyleBackColor = false;
            this.btnterminerProduit.Visible = false;
            this.btnterminerProduit.Click += new System.EventHandler(this.btnterminerProduit_Click);
            // 
            // txtbxQteVendu
            // 
            this.txtbxQteVendu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtbxQteVendu.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxQteVendu.Location = new System.Drawing.Point(488, 74);
            this.txtbxQteVendu.Multiline = true;
            this.txtbxQteVendu.Name = "txtbxQteVendu";
            this.txtbxQteVendu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtbxQteVendu.Size = new System.Drawing.Size(175, 32);
            this.txtbxQteVendu.TabIndex = 84;
            this.txtbxQteVendu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxQteVendu_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Cursor = System.Windows.Forms.Cursors.Default;
            this.label19.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(375, 77);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 23);
            this.label19.TabIndex = 83;
            this.label19.Text = "Qte Vendu";
            // 
            // btnClickPRD
            // 
            this.btnClickPRD.BackColor = System.Drawing.Color.White;
            this.btnClickPRD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClickPRD.BackgroundImage")));
            this.btnClickPRD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClickPRD.Location = new System.Drawing.Point(244, 32);
            this.btnClickPRD.Name = "btnClickPRD";
            this.btnClickPRD.Size = new System.Drawing.Size(60, 32);
            this.btnClickPRD.TabIndex = 82;
            this.btnClickPRD.UseVisualStyleBackColor = false;
            this.btnClickPRD.Click += new System.EventHandler(this.btnClickPRD_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Cursor = System.Windows.Forms.Cursors.Default;
            this.label15.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(713, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 23);
            this.label15.TabIndex = 65;
            this.label15.Text = "Prix Vente";
            // 
            // txtbxnumProduit
            // 
            this.txtbxnumProduit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtbxnumProduit.Enabled = false;
            this.txtbxnumProduit.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxnumProduit.Location = new System.Drawing.Point(129, 32);
            this.txtbxnumProduit.Multiline = true;
            this.txtbxnumProduit.Name = "txtbxnumProduit";
            this.txtbxnumProduit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtbxnumProduit.Size = new System.Drawing.Size(109, 32);
            this.txtbxnumProduit.TabIndex = 73;
            // 
            // btnValiderProduit
            // 
            this.btnValiderProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnValiderProduit.Enabled = false;
            this.btnValiderProduit.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderProduit.ForeColor = System.Drawing.Color.White;
            this.btnValiderProduit.Location = new System.Drawing.Point(399, 114);
            this.btnValiderProduit.Name = "btnValiderProduit";
            this.btnValiderProduit.Size = new System.Drawing.Size(125, 40);
            this.btnValiderProduit.TabIndex = 85;
            this.btnValiderProduit.Text = "Valider";
            this.btnValiderProduit.UseVisualStyleBackColor = false;
            this.btnValiderProduit.Click += new System.EventHandler(this.btnValiderProduit_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.label13.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 23);
            this.label13.TabIndex = 72;
            this.label13.Text = "Numero";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 23);
            this.label14.TabIndex = 75;
            this.label14.Text = "Categorie";
            // 
            // txtbxremise
            // 
            this.txtbxremise.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxremise.Location = new System.Drawing.Point(877, 70);
            this.txtbxremise.Multiline = true;
            this.txtbxremise.Name = "txtbxremise";
            this.txtbxremise.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtbxremise.Size = new System.Drawing.Size(175, 32);
            this.txtbxremise.TabIndex = 74;
            this.txtbxremise.Text = "0";
            this.txtbxremise.TextChanged += new System.EventHandler(this.txtbxremise_TextChanged);
            this.txtbxremise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxremise_KeyPress);
            // 
            // txtbxprixVente
            // 
            this.txtbxprixVente.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtbxprixVente.Enabled = false;
            this.txtbxprixVente.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxprixVente.Location = new System.Drawing.Point(877, 28);
            this.txtbxprixVente.Multiline = true;
            this.txtbxprixVente.Name = "txtbxprixVente";
            this.txtbxprixVente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtbxprixVente.Size = new System.Drawing.Size(175, 32);
            this.txtbxprixVente.TabIndex = 69;
            // 
            // txtbxQteStock
            // 
            this.txtbxQteStock.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtbxQteStock.Enabled = false;
            this.txtbxQteStock.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxQteStock.Location = new System.Drawing.Point(488, 31);
            this.txtbxQteStock.Multiline = true;
            this.txtbxQteStock.Name = "txtbxQteStock";
            this.txtbxQteStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtbxQteStock.Size = new System.Drawing.Size(175, 32);
            this.txtbxQteStock.TabIndex = 70;
            // 
            // txtbxNomProduit
            // 
            this.txtbxNomProduit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtbxNomProduit.Enabled = false;
            this.txtbxNomProduit.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNomProduit.Location = new System.Drawing.Point(129, 110);
            this.txtbxNomProduit.Multiline = true;
            this.txtbxNomProduit.Name = "txtbxNomProduit";
            this.txtbxNomProduit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtbxNomProduit.Size = new System.Drawing.Size(175, 32);
            this.txtbxNomProduit.TabIndex = 71;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Cursor = System.Windows.Forms.Cursors.Default;
            this.label16.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(717, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 23);
            this.label16.TabIndex = 66;
            this.label16.Text = "% Remise";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Cursor = System.Windows.Forms.Cursors.Default;
            this.label17.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(375, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 23);
            this.label17.TabIndex = 67;
            this.label17.Text = "Qte Stock";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Cursor = System.Windows.Forms.Cursors.Default;
            this.label18.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(16, 113);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 23);
            this.label18.TabIndex = 68;
            this.label18.Text = "Nom";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Produit,
            this.Nom_Produit,
            this.Num_Fact_cmd,
            this.Qte_Vendu_cmd,
            this.Qte_Stock_cmd,
            this.Prix_Vente_cmd,
            this.Remise,
            this.Total_Montant_cmd});
            this.dataGridView1.Location = new System.Drawing.Point(47, 650);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1290, 177);
            this.dataGridView1.TabIndex = 90;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBoxPaiement
            // 
            this.groupBoxPaiement.Controls.Add(this.label21);
            this.groupBoxPaiement.Controls.Add(this.btnValiderPaiement);
            this.groupBoxPaiement.Controls.Add(this.rdoNONpayer);
            this.groupBoxPaiement.Controls.Add(this.textBox1);
            this.groupBoxPaiement.Controls.Add(this.label11);
            this.groupBoxPaiement.Controls.Add(this.rdopayer);
            this.groupBoxPaiement.Controls.Add(this.txtbxRestClt);
            this.groupBoxPaiement.Controls.Add(this.label12);
            this.groupBoxPaiement.Controls.Add(this.txtbxAvanceClt);
            this.groupBoxPaiement.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPaiement.Location = new System.Drawing.Point(710, 306);
            this.groupBoxPaiement.Name = "groupBoxPaiement";
            this.groupBoxPaiement.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxPaiement.Size = new System.Drawing.Size(617, 153);
            this.groupBoxPaiement.TabIndex = 91;
            this.groupBoxPaiement.TabStop = false;
            this.groupBoxPaiement.Text = "Mode Paiement";
            this.groupBoxPaiement.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Cursor = System.Windows.Forms.Cursors.Default;
            this.label21.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(218, 39);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 23);
            this.label21.TabIndex = 89;
            this.label21.Text = "Montant";
            // 
            // btnValiderPaiement
            // 
            this.btnValiderPaiement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnValiderPaiement.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderPaiement.ForeColor = System.Drawing.Color.White;
            this.btnValiderPaiement.Location = new System.Drawing.Point(489, 67);
            this.btnValiderPaiement.Name = "btnValiderPaiement";
            this.btnValiderPaiement.Size = new System.Drawing.Size(109, 44);
            this.btnValiderPaiement.TabIndex = 87;
            this.btnValiderPaiement.Text = "Valider";
            this.btnValiderPaiement.UseVisualStyleBackColor = false;
            this.btnValiderPaiement.Click += new System.EventHandler(this.btnValiderPaiement_Click);
            // 
            // rdoNONpayer
            // 
            this.rdoNONpayer.AutoSize = true;
            this.rdoNONpayer.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNONpayer.Location = new System.Drawing.Point(19, 91);
            this.rdoNONpayer.Name = "rdoNONpayer";
            this.rdoNONpayer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdoNONpayer.Size = new System.Drawing.Size(129, 27);
            this.rdoNONpayer.TabIndex = 1;
            this.rdoNONpayer.TabStop = true;
            this.rdoNONpayer.Text = "Non Payer";
            this.rdoNONpayer.UseVisualStyleBackColor = true;
            this.rdoNONpayer.CheckedChanged += new System.EventHandler(this.rdoNONpayer_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(318, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(127, 32);
            this.textBox1.TabIndex = 88;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(218, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 23);
            this.label11.TabIndex = 79;
            this.label11.Text = "Reste";
            this.label11.Visible = false;
            // 
            // rdopayer
            // 
            this.rdopayer.AutoSize = true;
            this.rdopayer.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdopayer.Location = new System.Drawing.Point(19, 47);
            this.rdopayer.Name = "rdopayer";
            this.rdopayer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdopayer.Size = new System.Drawing.Size(85, 27);
            this.rdopayer.TabIndex = 0;
            this.rdopayer.TabStop = true;
            this.rdopayer.Text = "Payer";
            this.rdopayer.UseVisualStyleBackColor = true;
            this.rdopayer.CheckedChanged += new System.EventHandler(this.rdopayer_CheckedChanged);
            // 
            // txtbxRestClt
            // 
            this.txtbxRestClt.Enabled = false;
            this.txtbxRestClt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxRestClt.Location = new System.Drawing.Point(318, 110);
            this.txtbxRestClt.Name = "txtbxRestClt";
            this.txtbxRestClt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtbxRestClt.Size = new System.Drawing.Size(127, 32);
            this.txtbxRestClt.TabIndex = 3;
            this.txtbxRestClt.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.label12.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(218, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 23);
            this.label12.TabIndex = 80;
            this.label12.Text = "Avance";
            this.label12.Visible = false;
            // 
            // txtbxAvanceClt
            // 
            this.txtbxAvanceClt.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxAvanceClt.Location = new System.Drawing.Point(318, 74);
            this.txtbxAvanceClt.Name = "txtbxAvanceClt";
            this.txtbxAvanceClt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtbxAvanceClt.Size = new System.Drawing.Size(127, 32);
            this.txtbxAvanceClt.TabIndex = 2;
            this.txtbxAvanceClt.Visible = false;
            this.txtbxAvanceClt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxAvanceClt_KeyPress);
            // 
            // ID_Produit
            // 
            this.ID_Produit.HeaderText = "ID Produit";
            this.ID_Produit.Name = "ID_Produit";
            // 
            // Nom_Produit
            // 
            this.Nom_Produit.HeaderText = "Nom Produit";
            this.Nom_Produit.Name = "Nom_Produit";
            // 
            // Num_Fact_cmd
            // 
            this.Num_Fact_cmd.HeaderText = "Numero Facture";
            this.Num_Fact_cmd.Name = "Num_Fact_cmd";
            // 
            // Qte_Vendu_cmd
            // 
            this.Qte_Vendu_cmd.HeaderText = "Qte Vendu";
            this.Qte_Vendu_cmd.Name = "Qte_Vendu_cmd";
            // 
            // Qte_Stock_cmd
            // 
            this.Qte_Stock_cmd.HeaderText = "Qte Stock";
            this.Qte_Stock_cmd.Name = "Qte_Stock_cmd";
            // 
            // Prix_Vente_cmd
            // 
            this.Prix_Vente_cmd.HeaderText = "Prix Vente";
            this.Prix_Vente_cmd.Name = "Prix_Vente_cmd";
            // 
            // Remise
            // 
            this.Remise.HeaderText = "Remise %";
            this.Remise.Name = "Remise";
            // 
            // Total_Montant_cmd
            // 
            this.Total_Montant_cmd.HeaderText = "Montant Total";
            this.Total_Montant_cmd.Name = "Total_Montant_cmd";
            // 
            // commande_ajout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 839);
            this.Controls.Add(this.groupBoxPaiement);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxProduit);
            this.Controls.Add(this.groupBoxCLT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBoxFact);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "commande_ajout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "commande_ajout";
            this.Load += new System.EventHandler(this.commande_ajout_Load);
            this.groupBoxFact.ResumeLayout(false);
            this.groupBoxFact.PerformLayout();
            this.groupBoxCLT.ResumeLayout(false);
            this.groupBoxCLT.PerformLayout();
            this.groupBoxProduit.ResumeLayout(false);
            this.groupBoxProduit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxPaiement.ResumeLayout(false);
            this.groupBoxPaiement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBoxFact;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnValiderFacture;
        private System.Windows.Forms.Button btnAnnulerFACTURE;
        public System.Windows.Forms.TextBox txtbxNomCOMM_cmd;
        public System.Windows.Forms.TextBox txtbxNumFACT_cmd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.GroupBox groupBoxCLT;
        private System.Windows.Forms.Button btnClickClt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtbxnumClt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbxNomClt;
        private System.Windows.Forms.TextBox txtbxemailClt;
        private System.Windows.Forms.TextBox txtbxPrenomClt;
        private System.Windows.Forms.TextBox txtxbxNumTelClt;
        public System.Windows.Forms.GroupBox groupBoxProduit;
        private System.Windows.Forms.TextBox txtxbxTotal;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.Button btnterminerProduit;
        private System.Windows.Forms.TextBox txtbxQteVendu;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnClickPRD;
        private System.Windows.Forms.TextBox txtbxnumProduit;
        public System.Windows.Forms.Button btnValiderProduit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtbxremise;
        private System.Windows.Forms.TextBox txtbxQteStock;
        private System.Windows.Forms.TextBox txtbxNomProduit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbxprixVente;
        private System.Windows.Forms.GroupBox groupBoxPaiement;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnValiderPaiement;
        private System.Windows.Forms.RadioButton rdoNONpayer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rdopayer;
        private System.Windows.Forms.TextBox txtbxRestClt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtbxAvanceClt;
        private System.Windows.Forms.TextBox txtbxville;
        private System.Windows.Forms.TextBox txtbxcategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_Fact_cmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qte_Vendu_cmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qte_Stock_cmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix_Vente_cmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remise;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Montant_cmd;
    }
}