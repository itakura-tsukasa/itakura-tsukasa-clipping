﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clipping
{
    public partial class view : Form
    {
        public view()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Display_home();
            this.Close();
        }

        private void view_Load(object sender, EventArgs e)
        {

        }
    }
}
