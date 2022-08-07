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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resh s = new resh();
            s.Show();
            Hide(); //переход на окно задач
        }

        private void button3_Click(object sender, EventArgs e)
        {
            web s = new web();
            s.Show();
            Hide();//переход к браузеру
        }

        private void button2_Click(object sender, EventArgs e)
        {
            otzyv s = new otzyv();
            s.Show();
            Hide();//переход к окну отзывов
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit(); //выход
        }

        private void main_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + Data.login;  //отображение логина вошедшего пользователя
        }
    }
}
