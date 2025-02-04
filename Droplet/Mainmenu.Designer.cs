namespace Droplet
{
    partial class Mainmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainmenu));
            goProduit = new Button();
            goStock = new Button();
            goFournisseur = new Button();
            goClient = new Button();
            goExpedition = new Button();
            goStats = new Button();
            panel1 = new Panel();
            date = new Label();
            dateReel = new Label();
            label3 = new Label();
            idUser = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // goProduit
            // 
            goProduit.Location = new Point(159, 154);
            goProduit.Name = "goProduit";
            goProduit.Size = new Size(100, 100);
            goProduit.TabIndex = 0;
            goProduit.Text = "Produit";
            goProduit.UseVisualStyleBackColor = true;
            goProduit.Click += goProduit_Click;
            // 
            // goStock
            // 
            goStock.Location = new Point(282, 154);
            goStock.Name = "goStock";
            goStock.Size = new Size(100, 100);
            goStock.TabIndex = 1;
            goStock.Text = "Stock";
            goStock.UseVisualStyleBackColor = true;
            goStock.Click += goStock_Click;
            // 
            // goFournisseur
            // 
            goFournisseur.Location = new Point(407, 154);
            goFournisseur.Name = "goFournisseur";
            goFournisseur.Size = new Size(100, 100);
            goFournisseur.TabIndex = 2;
            goFournisseur.Text = "Fournisseur";
            goFournisseur.UseVisualStyleBackColor = true;
            goFournisseur.Click += goFournisseur_Click;
            // 
            // goClient
            // 
            goClient.Location = new Point(536, 154);
            goClient.Name = "goClient";
            goClient.Size = new Size(100, 100);
            goClient.TabIndex = 3;
            goClient.Text = "Client";
            goClient.UseVisualStyleBackColor = true;
            goClient.Click += goClient_Click;
            // 
            // goExpedition
            // 
            goExpedition.Font = new Font("Segoe UI", 9F, FontStyle.Strikeout, GraphicsUnit.Point, 0);
            goExpedition.Location = new Point(282, 278);
            goExpedition.Name = "goExpedition";
            goExpedition.Size = new Size(100, 100);
            goExpedition.TabIndex = 4;
            goExpedition.Text = "Expedition";
            goExpedition.UseVisualStyleBackColor = true;
            goExpedition.Click += goExpedition_Click;
            // 
            // goStats
            // 
            goStats.Font = new Font("Segoe UI", 9F, FontStyle.Strikeout, GraphicsUnit.Point, 0);
            goStats.Location = new Point(407, 278);
            goStats.Name = "goStats";
            goStats.Size = new Size(100, 100);
            goStats.TabIndex = 5;
            goStats.Text = "Statistique";
            goStats.UseVisualStyleBackColor = true;
            goStats.Click += goStats_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSlateBlue;
            panel1.Controls.Add(date);
            panel1.Controls.Add(dateReel);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(idUser);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 70);
            panel1.TabIndex = 6;
            // 
            // date
            // 
            date.AutoSize = true;
            date.ForeColor = Color.White;
            date.Location = new Point(654, 45);
            date.Name = "date";
            date.Size = new Size(49, 20);
            date.TabIndex = 6;
            date.Text = "Heure";
            // 
            // dateReel
            // 
            dateReel.AutoSize = true;
            dateReel.ForeColor = Color.White;
            dateReel.Location = new Point(662, 23);
            dateReel.Name = "dateReel";
            dateReel.Size = new Size(41, 20);
            dateReel.TabIndex = 5;
            dateReel.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(678, 3);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 4;
            label3.Text = "Date / Heure";
            // 
            // idUser
            // 
            idUser.AutoSize = true;
            idUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            idUser.ForeColor = SystemColors.ButtonFace;
            idUser.Location = new Point(181, 38);
            idUser.Name = "idUser";
            idUser.Size = new Size(25, 20);
            idUser.TabIndex = 3;
            idUser.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(85, 38);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 2;
            label2.Text = "Utilisateur :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(82, 3);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 1;
            label1.Text = "Droplet NEGOSUD";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Mainmenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(goStats);
            Controls.Add(goExpedition);
            Controls.Add(goClient);
            Controls.Add(goFournisseur);
            Controls.Add(goStock);
            Controls.Add(goProduit);
            Name = "Mainmenu";
            Text = "Droplet NEGOSUD - Menu Principal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button goProduit;
        private Button goStock;
        private Button goFournisseur;
        private Button goClient;
        private Button goExpedition;
        private Button goStats;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label idUser;
        private Label label2;
        private Label dateReel;
        private Label label3;
        private Label date;
    }
}