using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Droplet
{
    partial class produit : Form
    {
        /// Déclaration des composants manquants
        private Panel panel1;
        private Panel panel2;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private PictureBox pictureBox1;

        private void InitializeComponent()
        {
            /// Instanciation des composants
            panel1 = new Panel();
            panel2 = new Panel();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            pictureBox1 = new PictureBox();

            // Suspendre la mise en page pour éviter les bugs d'affichage
            SuspendLayout();

            // Configuration des composants
            ((ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();

            ((ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();

            ((ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();

            ((ISupportInitialize)pictureBox1).BeginInit();

            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Height = 100;
            panel1.BackColor = Color.LightGray;

            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.BackColor = Color.White;

            // 
            // pictureBox1
            // 
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Dock = DockStyle.Fill;

            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Orientation = Orientation.Vertical;
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel2.Controls.Add(splitContainer2);

            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Orientation = Orientation.Horizontal;
            splitContainer2.Panel1.Controls.Add(splitContainer3);
            splitContainer2.Panel2.Controls.Add(panel2);

            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Orientation = Orientation.Vertical;
            splitContainer3.Panel1.Controls.Add(pictureBox1);
            splitContainer3.Panel2.BackColor = Color.LightBlue; // Test d'affichage

            // 
            // produit (form)
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(splitContainer1);
            Name = "produit";
            Text = "Droplet NEGOSUD - Produits";

            // Finalisation des initialisations
            ((ISupportInitialize)pictureBox1).EndInit();
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.ResumeLayout(false);
            ((ISupportInitialize)splitContainer3).EndInit();

            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.ResumeLayout(false);
            ((ISupportInitialize)splitContainer2).EndInit();

            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.ResumeLayout(false);
            ((ISupportInitialize)splitContainer1).EndInit();

            ResumeLayout(false);
        }
    }
}
