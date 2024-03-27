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

            //xmlファイル読み込み;
            XElement xml = XElement.Load(xmlFilePath);

            IEnumerable<XElement> infos = from item in xml.Elements("article")
                                      select item;

            listView1.Items.Clear();

            //listViewに登録;
            foreach (XElement i in infos)
            {
                //データ取得;
                XElement title = i.Element("title");
                XElement body = i.Element("body");
                XElement time = i.Element("time");
                XElement index = i.Element("serial");

                string head;
                //本文が全角10文字よりなら10文字取り出し、後ろに...をつける;
                if(body.Value.Length > 20)
                {
                    head = body.Value.Substring(0, 10);
                    head += "...";
                }else{
                    head = body.Value;
                }

                //listViewに書き込み;
                listView1.Items.Add(new ListViewItem(new string[] { title.Value, head, time.Value, index.Value }));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Display_home();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection nowSelect = listView1.SelectedItems;
            if (nowSelect.Count == 0)
            {
                MessageBox.Show("閲覧したいクリップを選択してください", "エラー",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
