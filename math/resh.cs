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
    public partial class resh : Form
    {
        public resh()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            main s = new main();
            s.Show();
            Hide(); //переход на другую форму
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = Convert.ToSingle(textBox1.Text);//значение периода
            double b = 3.14 * 2 /a;//расчет по формуле
            richTextBox1.Text = "3.14*2/" + textBox1.Text + "=" + b.ToString();//вывод ответа
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float a = Convert.ToSingle(textBox2.Text);//значение частоты
            double b = 3.14 * 2 *a;//расчет по формуле
            richTextBox2.Text = "3.14*2*" + textBox2.Text + "=" + b.ToString();//вывод ответа

        }

        private void button3_Click(object sender, EventArgs e)
        {
            float a = Convert.ToSingle(textBox3.Text);
            float c = Convert.ToSingle(textBox4.Text);// значение ускорения и радиуса
            double b = Math.Sqrt(a/c);//расчет по формуле
            richTextBox3.Text = "√"+"(" +textBox3.Text+"/" + textBox4.Text+")"+"="+b.ToString();//вывод ответа
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            textBox1.Text = "";
            richTextBox2.Text = "";
            textBox2.Text = "";
            richTextBox3.Text = "";
            textBox3.Text = "";
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;  //отображение для задачи с периодом
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            textBox1.Text = "";
            richTextBox2.Text = "";
            textBox2.Text = "";
            richTextBox3.Text = "";
            textBox3.Text = "";
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false; //отображение задачи с частотой
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            textBox1.Text = "";
            richTextBox2.Text = "";
            textBox2.Text = "";
            richTextBox3.Text = "";
            textBox3.Text = "";
            panel1.Visible = false;
            panel2.Visible = false; // отображение задачи с ускорением и радиусом
            panel3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           double g1 =3.7;
           double g2 =8.87;
            double g3 = 9.8;
            double g4 =3.7;
            double g5 =24.8;
            double g6 =10.4;
            double g7 =8.87;
            double g8 =10.15;
            double g9 = 1.62;  //ускорение свободного падения на разных планетах
            double res1 = 0;
            double res2 = 0;
            double res3 = 0;
            double res4 = 0;
            double res5 = 0;
            double res6 = 0;
            double res7 = 0;
            double res8 = 0;
            double res9 = 0; //объявление переменных для результата массы
            int n = Convert.ToInt32(comboBox1.Text);//количество человек
            int b= Convert.ToInt32(textBox5.Text);//масса одного человека
            for (int i = 0; i < n; i++)//расчет для определенного количества людей
            {
                if (checkBox1.Checked) { res1 = res1 + g1 * b; }
                if (checkBox2.Checked) { res2 = res2 + g2 * b; }
                if (checkBox3.Checked) { res3 = res3 + g3 * b; }
                if (checkBox4.Checked) { res4 = res4 + g4 * b; }
                if (checkBox5.Checked) { res5 = res5 + g5* b; }
                if (checkBox6.Checked) { res6 = res6 + g6 * b; }
                if (checkBox7.Checked) { res7 = res7 + g7 * b; }
                if (checkBox8.Checked) { res8 = res8 + g8 * b; }
                if (checkBox9.Checked) { res9 = res9 + g9 * b; } //проверка на отмеченые поля и расчет массы на разных планетах
            }
            richTextBox4.Text = "";
            if (checkBox1.Checked) { richTextBox4.Text = richTextBox4.Text + "Вес на Меркурие " + res1 + "\n"; }
            if (checkBox2.Checked) { richTextBox4.Text = richTextBox4.Text + "Вес на Венере " + res2 + "\n"; }
            if (checkBox3.Checked) { richTextBox4.Text = richTextBox4.Text + "Вес на Земле " + res3 + "\n"; }
            if (checkBox4.Checked) { richTextBox4.Text = richTextBox4.Text + "Вес на Марсе " + res4 + "\n"; }
            if (checkBox5.Checked) { richTextBox4.Text = richTextBox4.Text + "Вес на Юпитере " + res5 + "\n"; }
            if (checkBox6.Checked) { richTextBox4.Text = richTextBox4.Text + "Вес на Сатурне " + res6 + "\n"; }
            if (checkBox7.Checked) { richTextBox4.Text = richTextBox4.Text + "Вес на Уране " + res7 + "\n"; }
            if (checkBox8.Checked) { richTextBox4.Text = richTextBox4.Text + "Вес на Нептуне " + res8 + "\n"; }
            if (checkBox9.Checked) { richTextBox4.Text = richTextBox4.Text + "Вес на Луне " + res9 + "\n"; } //проверка на отмеченые поля и вывод результатов массы на разных планетах

        }
    }
}
