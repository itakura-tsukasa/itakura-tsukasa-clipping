using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;


namespace clipping
{
    public partial class store : Form
    {
        public store()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Display_home();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if(textBox1.TextLength == 0)
            {
                MessageBox.Show("タイトルを入力してください",
                    "エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (textBox2.TextLength == 0)
            {
                MessageBox.Show("本文を入力してください",
                    "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox3.TextLength == 0)
            {
                MessageBox.Show("情報ソースを入力してください",
                    "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            XMLWriteArticle(textBox1.Text, textBox2.Text, textBox3.Text);

        }

        private void XMLWriteArticle (string title,string body,string source)
        {
            
            XElement xml = XElement.Load(@"./clip_article.xml");

            XElement data = new XElement("article",
                new XElement("title", title),
                new XElement("body", body),
                new XElement("source", source));

            xml.Add(data);

            xml.Save(@"./clip_article.xml");
        }
    }
}
