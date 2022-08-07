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
    public partial class auto : Form
    {
        public auto()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            this.ShowInTaskbar = false;//скрытие пароля
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                Data.login = textBox1.Text;//сохранение логина пользователя в глобальную перменную
                axWindowsMediaPlayer1.Ctlcontrols.play();//включение музыки
                main s = new main();
                s.Show();
                Hide();//переход в меню
            }
            else {
                MessageBox.Show("Неправильный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);//сообщение об ошибке
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*') { textBox2.PasswordChar = '\0'; } else { textBox2.PasswordChar = '*'; }//скрытие пароля и отображение оригинальных символов
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void auto_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop(); //остановка музыки
        }
    }
    static class Data
    {
        public static string login { get; set; }//объявление глобальной переменной

    }
}
