using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.Modeling;
//using Microsoft.VisualStudio.Modeling.Diagrams;
using System.Drawing;
using System.Data;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projet_de_groupe
{
    public partial class Login : Form
    {
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // ON va creer la base de donné et la table 
            if (MainClass.IsValidUser(txtUser.Text, txtPass.Text) == false)
            {
                guna2MessageDialog1.Show("Invalid Username or Password ");
                return;
            }
            else
            {
                this.Hide();
                pageprinciaple pgp = new pageprinciaple();
                pgp.Show();
            }
        }
        //create property for username



        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

