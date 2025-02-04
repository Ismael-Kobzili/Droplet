namespace Droplet
{
    partial class connect
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(connect));
            id_admin = new TextBox();
            mdp_admin = new TextBox();
            labelAdmin = new Label();
            labelMdp = new Label();
            logoProg = new PictureBox();
            button1 = new Button();
            cesi = new Label();
            nomLogiciel = new Label();
            ((System.ComponentModel.ISupportInitialize)logoProg).BeginInit();
            SuspendLayout();
            // 
            // id_admin
            // 
            id_admin.Location = new Point(114, 235);
            id_admin.Name = "id_admin";
            id_admin.Size = new Size(160, 27);
            id_admin.TabIndex = 0;
            // 
            // mdp_admin
            // 
            mdp_admin.Location = new Point(114, 294);
            mdp_admin.Name = "mdp_admin";
            mdp_admin.Size = new Size(160, 27);
            mdp_admin.TabIndex = 1;
            // 
            // labelAdmin
            // 
            labelAdmin.AutoSize = true;
            labelAdmin.ForeColor = Color.White;
            labelAdmin.Location = new Point(134, 212);
            labelAdmin.Name = "labelAdmin";
            labelAdmin.Size = new Size(125, 20);
            labelAdmin.TabIndex = 2;
            labelAdmin.Text = "Identifiant Admin";
            // 
            // labelMdp
            // 
            labelMdp.AutoSize = true;
            labelMdp.ForeColor = Color.White;
            labelMdp.Location = new Point(144, 271);
            labelMdp.Name = "labelMdp";
            labelMdp.Size = new Size(98, 20);
            labelMdp.TabIndex = 3;
            labelMdp.Text = "Mot de passe";
            // 
            // logoProg
            // 
            logoProg.Image = (Image)resources.GetObject("logoProg.Image");
            logoProg.Location = new Point(134, 34);
            logoProg.Name = "logoProg";
            logoProg.Size = new Size(125, 125);
            logoProg.SizeMode = PictureBoxSizeMode.StretchImage;
            logoProg.TabIndex = 4;
            logoProg.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(133, 336);
            button1.Name = "button1";
            button1.Size = new Size(126, 29);
            button1.TabIndex = 5;
            button1.Text = "Se connecter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cesi
            // 
            cesi.AutoSize = true;
            cesi.ForeColor = Color.White;
            cesi.Location = new Point(9, 425);
            cesi.Name = "cesi";
            cesi.Size = new Size(371, 20);
            cesi.TabIndex = 6;
            cesi.Text = "Logiciel developper par Cesi (Yassine Sohail et Ismaël).";
            // 
            // nomLogiciel
            // 
            nomLogiciel.AutoSize = true;
            nomLogiciel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nomLogiciel.ForeColor = Color.White;
            nomLogiciel.Location = new Point(128, 174);
            nomLogiciel.Name = "nomLogiciel";
            nomLogiciel.Size = new Size(138, 20);
            nomLogiciel.TabIndex = 7;
            nomLogiciel.Text = "Droplet NEGOSUD";
            // 
            // connect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(382, 453);
            Controls.Add(nomLogiciel);
            Controls.Add(cesi);
            Controls.Add(button1);
            Controls.Add(logoProg);
            Controls.Add(labelMdp);
            Controls.Add(labelAdmin);
            Controls.Add(mdp_admin);
            Controls.Add(id_admin);
            Name = "connect";
            Text = "Droplet Negosud";
            Load += connect_Load;
            ((System.ComponentModel.ISupportInitialize)logoProg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox id_admin;
        private TextBox mdp_admin;
        private Label labelAdmin;
        private Label labelMdp;
        private PictureBox logoProg;
        private Button button1;
        private Label cesi;
        private Label nomLogiciel;
    }
}
