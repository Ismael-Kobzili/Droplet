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
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // client
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "client";
            this.ResumeLayout(false);
        }
    }
}
