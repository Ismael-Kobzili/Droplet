namespace Droplet
{
    public partial class connect : Form
    {
        public connect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = id_admin.Text.Trim();
            string password = mdp_admin.Text.Trim();

            //if (string.IsNullOrEmpty(username))
            //{
            //    MessageBox.Show("Veuillez entrer un nom d'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    id_admin.Focus();
            //    return;
            //}

            //if (string.IsNullOrEmpty(password))
            //{
            //    MessageBox.Show("Veuillez entrer un mot de passe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    mdp_admin.Focus();
            //    return;
            //}

            if (username == "" && password == "")
            {
                MessageBox.Show("Connexion réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Mainmenu nextForm = new Mainmenu();
                this.Hide();
                nextForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void connect_Load(object sender, EventArgs e)
        {

        }
    }
}
