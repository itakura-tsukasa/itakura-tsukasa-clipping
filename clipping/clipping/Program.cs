using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clipping
{
    static class Program
    {
        public static ApplicationContext main_form;   //1,メインフォーム用の変数   
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //2,初めに生成されているコードをコメントアウトする
            //Application.Run(new Form1());
            //3,メインフォーム用の変数をApplication.Runの引数に設定
            main_form = new ApplicationContext();
            main_form.MainForm = new home();
            Application.Run(main_form);
        }

        public static void Display_home()
        {
            //homeへ遷移;
            main_form.MainForm = new home();
            main_form.MainForm.Show();
        }
        public static void Display_store()
        {
            //保存へ遷移;
            main_form.MainForm = new store();
            main_form.MainForm.Show();
        }
        public static void Display_view()
        {
            //表示へ遷移;
            main_form.MainForm = new view();
            main_form.MainForm.Show();
        }
    }
}
