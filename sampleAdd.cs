﻿using System;
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
    public partial class sampleAdd : Form
    {
        public sampleAdd()
        {
            InitializeComponent();
        }

        public virtual void btnSave_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
