using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace clipping
{
    public partial class view : Form
    {
        private const string xmlFilePath = "./clip_article.xml";

        public view()
        {
            InitializeComponent();

            //XElement xml = XElement.Load(xmlFilePath);

            //IEnumerable<XElement> infos = from item in xml.Elements("article")
            //                          select item;

            //listView1.Items.Clear();

            listView1.Items.Add(new ListViewItem(new string[] { "5", "6", "7" }));
            listView1.Items.Add(new ListViewItem(new string[] { "5", "6", "7" }));
            listView1.Items.Add(new ListViewItem(new string[] { "5", "6", "7" }));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Display_home();
            this.Close();
        }

    }
}
