using System;
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

    public partial class home : Form
    {
        public static ApplicationContext main_form;   //メインフォーム用の変数   

        public home()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Program.Display_store();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.Display_view();
            this.Close();
        }

    }
}
