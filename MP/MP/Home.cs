using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CreateMP newMp = new CreateMP();
            panel1.Controls.Add(newMp);
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UpdateMPP updateMp = new UpdateMPP();
            panel1.Controls.Add(updateMp);
        }

        private void CancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Do you really want to exit", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (msg==DialogResult.Yes)
            {
                
                Application.Exit();
            }
            else
            {
                return;
            }
          

        }
    }
}
