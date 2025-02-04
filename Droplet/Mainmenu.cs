using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Droplet
{
    public partial class Mainmenu : Form
    {
        public Mainmenu()
        {
            InitializeComponent();
        }

        private void goProduit_Click(object sender, EventArgs e)
        {
            Produit produitForm = new Produit(); 
            produitForm.Show(); 
            this.Hide(); 
        }


        private void goStock_Click(object sender, EventArgs e)
        {
            //Stock stockForm = new Stock(); 
            //stockForm.Show(); 
            //this.Close(); 
        }

        private void goFournisseur_Click(object sender, EventArgs e)
        {
            //Fournisseur fournisseurForm = new Fournisseur(); 
            //fournisseurForm.Show(); 
            //this.Close(); 
        }

        private void goClient_Click(object sender, EventArgs e)
        {
            //Client clientForm = new Client(); 
            //clientForm.Show(); 
            //this.Close(); 
        }

        private void goExpedition_Click(object sender, EventArgs e)
        {
            //Expedition expeditionForm = new Expedition(); 
            //expeditionForm.Show(); 
            //this.Close(); 
        }

        private void goStats_Click(object sender, EventArgs e)
        {
            //Statistiques statsForm = new Statistiques(); 
            //statsForm.Show(); 
            //this.Close(); 
        }

    }
}
