using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace math
{
    public partial class web : Form
    {
        public web()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripTextBox1.Text); //поиск в браузере
        }


        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();//перезагрузка браузера
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();//назад
        }

        private void web_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.ru");//объявление браузера в форме
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            main s = new main();
            s.Show();
            Hide();//переход на другую форму
        }
    }
}
