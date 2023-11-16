using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_de_groupe
{
    public partial class pageprinciaple : Form
    {
        public pageprinciaple()
        {
            InitializeComponent();
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        // Method to add controls in Main form

        public void AddControls(Form f)
        {


            CenterPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            CenterPanel.Controls.Add(f);
            f.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void pageprinciaple_Load(object sender, EventArgs e)
        {
            unamee.Text = MainClass.USER;
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void CenterPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CenterPanel_Paint_1(object sender, PaintEventArgs e)
        {


        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            AddControls(new Home());
        }
    }
}