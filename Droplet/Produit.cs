using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Droplet.Models;
using Droplet;



namespace Droplet
{
    public partial class Produit : Form
    {
        private ProduitService productsService = new ProduitService();
        public Produit()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Nom", "Nom");
            dataGridView1.Columns.Add("Annee", "Année");
            dataGridView1.Columns.Add("Famille", "Famille");
            FillDataGridView();

        }

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void goMenu_Click(object sender, EventArgs e)
        {
            Mainmenu MainMenu = new Mainmenu();
            MainMenu.Show();
            this.Hide();
        }

        private void FillDataGridView()
        {
            var produits = productsService.GetProducts();

            // Vider les lignes existantes dans la DataGridView (si nécessaire)
            dataGridView1.Rows.Clear();

            // Ajouter les produits dans la DataGridView
            foreach (var produit in produits)
            {
                // Ajouter une nouvelle ligne pour chaque produit
                dataGridView1.Rows.Add(produit.Nom, produit.Annee, produit.Famille);
            }

        }
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Produit));
            panel1 = new Panel();
            label28 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            splitContainer1 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            label9 = new Label();
            FournisseurParProduit = new Label();
            DgreAlcProduit = new Label();
            BioProduit = new Label();
            PrixProduit = new Label();
            DescriptionProduit = new Label();
            button3 = new Button();
            AppellationProduit = new Label();
            ContenanceProduit = new Label();
            FamilleProduit = new Label();
            AnneeProduit = new Label();
            NomProduit = new Label();
            button2 = new Button();
            label8 = new Label();
            DegreeAlcProduit = new Label();
            BioYesNo = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            AppellationParProduit = new Label();
            ContenanceDuProduit = new Label();
            FamilleDuProduit = new Label();
            AnneeDuProduit = new Label();
            label3 = new Label();
            QuantiteEnCommande = new Label();
            QuantiteEnStock = new Label();
            label2 = new Label();
            label1 = new Label();
            splitContainer2 = new SplitContainer();
            dataGridView1 = new DataGridView();
            label11 = new Label();
            textBox1 = new TextBox();
            label10 = new Label();
            button5 = new Button();
            InpAppelProduit = new TextBox();
            InpContProduit = new TextBox();
            GetFournisseur = new ComboBox();
            label27 = new Label();
            InpDegreProduit = new TextBox();
            label26 = new Label();
            InpTarifProduit = new TextBox();
            DescrProduit = new TextBox();
            InpFamilleProduit = new TextBox();
            InpAnneeProduit = new TextBox();
            InpNomProduit = new TextBox();
            button4 = new Button();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            IsBio = new RadioButton();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            panel1.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(label28);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-4, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 125);
            panel1.TabIndex = 0;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label28.ForeColor = Color.White;
            label28.Location = new Point(108, 11);
            label28.Name = "label28";
            label28.Size = new Size(138, 20);
            label28.TabIndex = 2;
            label28.Text = "Droplet NEGOSUD";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(1197, 39);
            panel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(16, 7);
            button1.Name = "button1";
            button1.Size = new Size(127, 29);
            button1.TabIndex = 0;
            button1.Text = "Retour au Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(-4, 129);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1197, 629);
            splitContainer1.SplitterDistance = 399;
            splitContainer1.TabIndex = 1;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(label9);
            splitContainer3.Panel1.Controls.Add(FournisseurParProduit);
            splitContainer3.Panel1.Controls.Add(DgreAlcProduit);
            splitContainer3.Panel1.Controls.Add(BioProduit);
            splitContainer3.Panel1.Controls.Add(PrixProduit);
            splitContainer3.Panel1.Controls.Add(DescriptionProduit);
            splitContainer3.Panel1.Controls.Add(button3);
            splitContainer3.Panel1.Controls.Add(AppellationProduit);
            splitContainer3.Panel1.Controls.Add(ContenanceProduit);
            splitContainer3.Panel1.Controls.Add(FamilleProduit);
            splitContainer3.Panel1.Controls.Add(AnneeProduit);
            splitContainer3.Panel1.Controls.Add(NomProduit);
            splitContainer3.Panel1.Controls.Add(button2);
            splitContainer3.Panel1.Controls.Add(label8);
            splitContainer3.Panel1.Controls.Add(DegreeAlcProduit);
            splitContainer3.Panel1.Controls.Add(BioYesNo);
            splitContainer3.Panel1.Controls.Add(label7);
            splitContainer3.Panel1.Controls.Add(label6);
            splitContainer3.Panel1.Controls.Add(label5);
            splitContainer3.Panel1.Controls.Add(label4);
            splitContainer3.Panel1.Controls.Add(AppellationParProduit);
            splitContainer3.Panel1.Controls.Add(ContenanceDuProduit);
            splitContainer3.Panel1.Controls.Add(FamilleDuProduit);
            splitContainer3.Panel1.Controls.Add(AnneeDuProduit);
            splitContainer3.Panel1.Controls.Add(label3);
            splitContainer3.Panel1.Paint += splitContainer3_Panel1_Paint_1;
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(QuantiteEnCommande);
            splitContainer3.Panel2.Controls.Add(QuantiteEnStock);
            splitContainer3.Panel2.Controls.Add(label2);
            splitContainer3.Panel2.Controls.Add(label1);
            splitContainer3.Size = new Size(399, 629);
            splitContainer3.SplitterDistance = 491;
            splitContainer3.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(16, 12);
            label9.Name = "label9";
            label9.Size = new Size(377, 20);
            label9.TabIndex = 24;
            label9.Text = "Informations sur le produit (Selectionnez sur la liste)";
            // 
            // FournisseurParProduit
            // 
            FournisseurParProduit.AutoSize = true;
            FournisseurParProduit.Location = new Point(132, 411);
            FournisseurParProduit.Name = "FournisseurParProduit";
            FournisseurParProduit.Size = new Size(30, 20);
            FournisseurParProduit.TabIndex = 23;
            FournisseurParProduit.Text = "???";
            // 
            // DgreAlcProduit
            // 
            DgreAlcProduit.AutoSize = true;
            DgreAlcProduit.Location = new Point(133, 377);
            DgreAlcProduit.Name = "DgreAlcProduit";
            DgreAlcProduit.Size = new Size(30, 20);
            DgreAlcProduit.TabIndex = 22;
            DgreAlcProduit.Text = "???";
            // 
            // BioProduit
            // 
            BioProduit.AutoSize = true;
            BioProduit.Location = new Point(65, 342);
            BioProduit.Name = "BioProduit";
            BioProduit.Size = new Size(30, 20);
            BioProduit.TabIndex = 21;
            BioProduit.Text = "???";
            // 
            // PrixProduit
            // 
            PrixProduit.AutoSize = true;
            PrixProduit.Location = new Point(127, 318);
            PrixProduit.Name = "PrixProduit";
            PrixProduit.Size = new Size(30, 20);
            PrixProduit.TabIndex = 20;
            PrixProduit.Text = "???";
            // 
            // DescriptionProduit
            // 
            DescriptionProduit.AutoSize = true;
            DescriptionProduit.Location = new Point(19, 267);
            DescriptionProduit.Name = "DescriptionProduit";
            DescriptionProduit.Size = new Size(163, 20);
            DescriptionProduit.TabIndex = 19;
            DescriptionProduit.Text = "??????????????????????";
            // 
            // button3
            // 
            button3.Location = new Point(85, 201);
            button3.Name = "button3";
            button3.Size = new Size(155, 29);
            button3.TabIndex = 18;
            button3.Text = "Choisir une image ...";
            button3.UseVisualStyleBackColor = true;
            // 
            // AppellationProduit
            // 
            AppellationProduit.AutoSize = true;
            AppellationProduit.Location = new Point(120, 173);
            AppellationProduit.Name = "AppellationProduit";
            AppellationProduit.Size = new Size(30, 20);
            AppellationProduit.TabIndex = 17;
            AppellationProduit.Text = "???";
            // 
            // ContenanceProduit
            // 
            ContenanceProduit.AutoSize = true;
            ContenanceProduit.Location = new Point(120, 145);
            ContenanceProduit.Name = "ContenanceProduit";
            ContenanceProduit.Size = new Size(30, 20);
            ContenanceProduit.TabIndex = 16;
            ContenanceProduit.Text = "???";
            // 
            // FamilleProduit
            // 
            FamilleProduit.AutoSize = true;
            FamilleProduit.Location = new Point(90, 112);
            FamilleProduit.Name = "FamilleProduit";
            FamilleProduit.Size = new Size(30, 20);
            FamilleProduit.TabIndex = 15;
            FamilleProduit.Text = "???";
            // 
            // AnneeProduit
            // 
            AnneeProduit.AutoSize = true;
            AnneeProduit.Location = new Point(85, 87);
            AnneeProduit.Name = "AnneeProduit";
            AnneeProduit.Size = new Size(30, 20);
            AnneeProduit.TabIndex = 14;
            AnneeProduit.Text = "???";
            // 
            // NomProduit
            // 
            NomProduit.AutoSize = true;
            NomProduit.Location = new Point(155, 53);
            NomProduit.Name = "NomProduit";
            NomProduit.Size = new Size(30, 20);
            NomProduit.TabIndex = 13;
            NomProduit.Text = "???";
            // 
            // button2
            // 
            button2.Location = new Point(108, 445);
            button2.Name = "button2";
            button2.Size = new Size(169, 29);
            button2.TabIndex = 12;
            button2.Text = "Modifier le produit";
            button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(18, 410);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 11;
            label8.Text = "Fournisseur :";
            // 
            // DegreeAlcProduit
            // 
            DegreeAlcProduit.AutoSize = true;
            DegreeAlcProduit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DegreeAlcProduit.Location = new Point(19, 375);
            DegreeAlcProduit.Name = "DegreeAlcProduit";
            DegreeAlcProduit.Size = new Size(107, 20);
            DegreeAlcProduit.TabIndex = 10;
            DegreeAlcProduit.Text = "Degré Alcool :";
            // 
            // BioYesNo
            // 
            BioYesNo.AutoSize = true;
            BioYesNo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BioYesNo.Location = new Point(19, 342);
            BioYesNo.Name = "BioYesNo";
            BioYesNo.Size = new Size(40, 20);
            BioYesNo.TabIndex = 9;
            BioYesNo.Text = "Bio :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 262);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(19, 314);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 7;
            label6.Text = "Prix Unitaire :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(19, 237);
            label5.Name = "label5";
            label5.Size = new Size(175, 20);
            label5.TabIndex = 6;
            label5.Text = "Description du produit :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(19, 205);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 5;
            label4.Text = "Image :";
            // 
            // AppellationParProduit
            // 
            AppellationParProduit.AutoSize = true;
            AppellationParProduit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AppellationParProduit.Location = new Point(19, 173);
            AppellationParProduit.Name = "AppellationParProduit";
            AppellationParProduit.Size = new Size(98, 20);
            AppellationParProduit.TabIndex = 4;
            AppellationParProduit.Text = "Appellation :";
            // 
            // ContenanceDuProduit
            // 
            ContenanceDuProduit.AutoSize = true;
            ContenanceDuProduit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ContenanceDuProduit.Location = new Point(19, 144);
            ContenanceDuProduit.Name = "ContenanceDuProduit";
            ContenanceDuProduit.Size = new Size(99, 20);
            ContenanceDuProduit.TabIndex = 3;
            ContenanceDuProduit.Text = "Contenance :";
            // 
            // FamilleDuProduit
            // 
            FamilleDuProduit.AutoSize = true;
            FamilleDuProduit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FamilleDuProduit.Location = new Point(19, 114);
            FamilleDuProduit.Name = "FamilleDuProduit";
            FamilleDuProduit.Size = new Size(67, 20);
            FamilleDuProduit.TabIndex = 2;
            FamilleDuProduit.Text = "Famille :";
            // 
            // AnneeDuProduit
            // 
            AnneeDuProduit.AutoSize = true;
            AnneeDuProduit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AnneeDuProduit.Location = new Point(19, 84);
            AnneeDuProduit.Name = "AnneeDuProduit";
            AnneeDuProduit.Size = new Size(62, 20);
            AnneeDuProduit.TabIndex = 1;
            AnneeDuProduit.Text = "Année :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(19, 53);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 0;
            label3.Text = "Nom du produit :";
            // 
            // QuantiteEnCommande
            // 
            QuantiteEnCommande.AutoSize = true;
            QuantiteEnCommande.Location = new Point(195, 88);
            QuantiteEnCommande.Name = "QuantiteEnCommande";
            QuantiteEnCommande.Size = new Size(30, 20);
            QuantiteEnCommande.TabIndex = 3;
            QuantiteEnCommande.Text = "???";
            // 
            // QuantiteEnStock
            // 
            QuantiteEnStock.AutoSize = true;
            QuantiteEnStock.Location = new Point(165, 17);
            QuantiteEnStock.Name = "QuantiteEnStock";
            QuantiteEnStock.Size = new Size(30, 20);
            QuantiteEnStock.TabIndex = 2;
            QuantiteEnStock.Text = "???";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 88);
            label2.Name = "label2";
            label2.Size = new Size(175, 20);
            label2.TabIndex = 1;
            label2.Text = "Quantié en commande :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 17);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 0;
            label1.Text = "Quantité en stock :";
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(dataGridView1);
            splitContainer2.Panel1.Controls.Add(label11);
            splitContainer2.Panel1.Controls.Add(textBox1);
            splitContainer2.Panel1.Controls.Add(label10);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(button5);
            splitContainer2.Panel2.Controls.Add(InpAppelProduit);
            splitContainer2.Panel2.Controls.Add(InpContProduit);
            splitContainer2.Panel2.Controls.Add(GetFournisseur);
            splitContainer2.Panel2.Controls.Add(label27);
            splitContainer2.Panel2.Controls.Add(InpDegreProduit);
            splitContainer2.Panel2.Controls.Add(label26);
            splitContainer2.Panel2.Controls.Add(InpTarifProduit);
            splitContainer2.Panel2.Controls.Add(DescrProduit);
            splitContainer2.Panel2.Controls.Add(InpFamilleProduit);
            splitContainer2.Panel2.Controls.Add(InpAnneeProduit);
            splitContainer2.Panel2.Controls.Add(InpNomProduit);
            splitContainer2.Panel2.Controls.Add(button4);
            splitContainer2.Panel2.Controls.Add(label25);
            splitContainer2.Panel2.Controls.Add(label24);
            splitContainer2.Panel2.Controls.Add(label23);
            splitContainer2.Panel2.Controls.Add(IsBio);
            splitContainer2.Panel2.Controls.Add(label22);
            splitContainer2.Panel2.Controls.Add(label21);
            splitContainer2.Panel2.Controls.Add(label20);
            splitContainer2.Panel2.Controls.Add(label19);
            splitContainer2.Panel2.Controls.Add(label18);
            splitContainer2.Panel2.Controls.Add(label17);
            splitContainer2.Panel2.Controls.Add(label16);
            splitContainer2.Panel2.Controls.Add(label15);
            splitContainer2.Panel2.Controls.Add(label14);
            splitContainer2.Panel2.Controls.Add(label13);
            splitContainer2.Panel2.Controls.Add(label12);
            splitContainer2.Size = new Size(794, 629);
            splitContainer2.SplitterDistance = 387;
            splitContainer2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(44, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 458);
            dataGridView1.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(54, 58);
            label11.Name = "label11";
            label11.Size = new Size(162, 20);
            label11.TabIndex = 3;
            label11.Text = "Rechercher un produit";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(54, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(121, 12);
            label10.Name = "label10";
            label10.Size = new Size(133, 20);
            label10.TabIndex = 0;
            label10.Text = "Liste des produits";
            // 
            // button5
            // 
            button5.Location = new Point(97, 210);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 27;
            button5.Text = "Parcourir...";
            button5.UseVisualStyleBackColor = true;
            // 
            // InpAppelProduit
            // 
            InpAppelProduit.Location = new Point(197, 186);
            InpAppelProduit.Name = "InpAppelProduit";
            InpAppelProduit.Size = new Size(125, 27);
            InpAppelProduit.TabIndex = 26;
            // 
            // InpContProduit
            // 
            InpContProduit.Location = new Point(196, 153);
            InpContProduit.Name = "InpContProduit";
            InpContProduit.Size = new Size(125, 27);
            InpContProduit.TabIndex = 25;
            // 
            // GetFournisseur
            // 
            GetFournisseur.FormattingEnabled = true;
            GetFournisseur.Location = new Point(36, 488);
            GetFournisseur.Name = "GetFournisseur";
            GetFournisseur.Size = new Size(306, 28);
            GetFournisseur.TabIndex = 24;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.Location = new Point(228, 428);
            label27.Name = "label27";
            label27.Size = new Size(15, 20);
            label27.TabIndex = 23;
            label27.Text = "°";
            // 
            // InpDegreProduit
            // 
            InpDegreProduit.Location = new Point(149, 428);
            InpDegreProduit.Name = "InpDegreProduit";
            InpDegreProduit.Size = new Size(73, 27);
            InpDegreProduit.TabIndex = 22;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.Location = new Point(228, 368);
            label26.Name = "label26";
            label26.Size = new Size(18, 20);
            label26.TabIndex = 21;
            label26.Text = "€";
            // 
            // InpTarifProduit
            // 
            InpTarifProduit.Location = new Point(149, 365);
            InpTarifProduit.Name = "InpTarifProduit";
            InpTarifProduit.Size = new Size(73, 27);
            InpTarifProduit.TabIndex = 20;
            // 
            // DescrProduit
            // 
            DescrProduit.Location = new Point(36, 279);
            DescrProduit.Multiline = true;
            DescrProduit.Name = "DescrProduit";
            DescrProduit.Size = new Size(306, 73);
            DescrProduit.TabIndex = 19;
            // 
            // InpFamilleProduit
            // 
            InpFamilleProduit.Location = new Point(198, 122);
            InpFamilleProduit.Name = "InpFamilleProduit";
            InpFamilleProduit.Size = new Size(125, 27);
            InpFamilleProduit.TabIndex = 18;
            // 
            // InpAnneeProduit
            // 
            InpAnneeProduit.Location = new Point(196, 90);
            InpAnneeProduit.Name = "InpAnneeProduit";
            InpAnneeProduit.Size = new Size(125, 27);
            InpAnneeProduit.TabIndex = 17;
            // 
            // InpNomProduit
            // 
            InpNomProduit.Location = new Point(194, 59);
            InpNomProduit.Name = "InpNomProduit";
            InpNomProduit.Size = new Size(125, 27);
            InpNomProduit.TabIndex = 16;
            // 
            // button4
            // 
            button4.Location = new Point(55, 583);
            button4.Name = "button4";
            button4.Size = new Size(287, 29);
            button4.TabIndex = 15;
            button4.Text = "Ajouter ce produit maintenant";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.ForeColor = Color.Red;
            label25.Location = new Point(19, 546);
            label25.Name = "label25";
            label25.Size = new Size(340, 12);
            label25.TabIndex = 14;
            label25.Text = "Vous devez d'abord avoir un fournisseur enregistrer avant de creer le produit";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(34, 465);
            label24.Name = "label24";
            label24.Size = new Size(99, 20);
            label24.TabIndex = 13;
            label24.Text = "Fournisseur :";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(33, 431);
            label23.Name = "label23";
            label23.Size = new Size(117, 20);
            label23.TabIndex = 12;
            label23.Text = "Degré d'alcool :";
            // 
            // IsBio
            // 
            IsBio.AutoSize = true;
            IsBio.Location = new Point(81, 400);
            IsBio.Name = "IsBio";
            IsBio.Size = new Size(53, 24);
            IsBio.TabIndex = 11;
            IsBio.TabStop = true;
            IsBio.Text = "Oui";
            IsBio.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(36, 399);
            label22.Name = "label22";
            label22.Size = new Size(40, 20);
            label22.TabIndex = 10;
            label22.Text = "Bio :";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(34, 365);
            label21.Name = "label21";
            label21.Size = new Size(104, 20);
            label21.TabIndex = 9;
            label21.Text = "Prix Unitaire :";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(41, 279);
            label20.Name = "label20";
            label20.Size = new Size(0, 20);
            label20.TabIndex = 8;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(34, 246);
            label19.Name = "label19";
            label19.Size = new Size(179, 20);
            label19.TabIndex = 7;
            label19.Text = "Description  du Produit :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(34, 214);
            label18.Name = "label18";
            label18.Size = new Size(61, 20);
            label18.TabIndex = 6;
            label18.Text = "Image :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(33, 184);
            label17.Name = "label17";
            label17.Size = new Size(98, 20);
            label17.TabIndex = 5;
            label17.Text = "Appellation :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(31, 154);
            label16.Name = "label16";
            label16.Size = new Size(99, 20);
            label16.TabIndex = 4;
            label16.Text = "Contenance :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(30, 124);
            label15.Name = "label15";
            label15.Size = new Size(59, 20);
            label15.TabIndex = 3;
            label15.Text = "Famille";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(30, 92);
            label14.Name = "label14";
            label14.Size = new Size(62, 20);
            label14.TabIndex = 2;
            label14.Text = "Année :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(29, 63);
            label13.Name = "label13";
            label13.Size = new Size(130, 20);
            label13.TabIndex = 1;
            label13.Text = "Nom du produit :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(140, 12);
            label12.Name = "label12";
            label12.Size = new Size(140, 20);
            label12.TabIndex = 0;
            label12.Text = "Ajouter un produit";
            // 
            // Produit
            // 
            ClientSize = new Size(1182, 753);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Name = "Produit";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel1.PerformLayout();
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.Panel2.PerformLayout();
            ((ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button1;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;

        private void splitContainer3_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private Label QuantiteEnStock;
        private Label label2;
        private Label label1;
        private Label AnneeDuProduit;
        private Label label3;
        private Label QuantiteEnCommande;
        private Label ContenanceDuProduit;
        private Label FamilleDuProduit;
        private Label label4;
        private Label AppellationParProduit;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label BioYesNo;
        private Button button2;
        private Label label8;
        private Label DegreeAlcProduit;
        private Label FamilleProduit;
        private Label AnneeProduit;
        private Label NomProduit;
        private Button button3;
        private Label AppellationProduit;
        private Label ContenanceProduit;
        private Label FournisseurParProduit;
        private Label DgreAlcProduit;
        private Label BioProduit;
        private Label PrixProduit;
        private Label DescriptionProduit;
        private Label label9;
        private TextBox textBox1;
        private Label label10;
        private Label label11;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label23;
        private RadioButton IsBio;
        private Label label22;
        private Button button4;
        private Label label25;
        private Label label24;
        private TextBox InpNomProduit;
        private TextBox InpAnneeProduit;
        private TextBox InpFamilleProduit;
        private TextBox InpTarifProduit;
        private TextBox DescrProduit;
        private Label label27;
        private TextBox InpDegreProduit;
        private Label label26;
        private Label label28;
        private TextBox InpAppelProduit;
        private TextBox InpContProduit;
        private ComboBox GetFournisseur;
        private Button button5;
        private DataGridView dataGridView1;



        private void button4_Click(object sender, EventArgs e)
        {
            ProduitEntity produitEntity = new ProduitEntity
            {
                Id = 12,
                Nom = InpNomProduit.Text,
                Annee = int.Parse(InpAnneeProduit.Text),
                Famille = "Bordeaux",
                Contenance = 75,
                Appellation = "AOC",
                Image = "chateau_riviere.jpg",
                Description = "Un vin rouge de Bordeaux",
                PrixUnitaire = 15,
                Bio = false,
                DegreAlcool = 12,
                Id_Fournisseur = 1
            };
            productsService.AddProduct(produitEntity);
            FillDataGridView();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                int i = 0;
                string searchText = textBox1.Text.ToLower();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Vérifier si la ligne est la dernière ligne vide (NewRow)
                    if (row.IsNewRow)
                        continue; // Ignore cette ligne et passe à la suivante

                    if (row.Cells["Nom"].Value != null && row.Cells["Nom"].Value.ToString().ToLower().Contains(searchText))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
