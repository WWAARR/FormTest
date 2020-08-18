using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormTest
{
    public partial class Form1 : Form
    {
        int count = 0; //номер вопроса
        int max = 2; //количество вопросов(записаных при созданиие массива вопросов)
        int res; //количество правильных ответов
        Questions[] q1;

        class Questions //класс в котором будет храниться вопрос, варианты ответа и правильный ответ
        {
            private string qustion;  // вопрос

            public string Qustion
            {
                get { return qustion; }
                set { qustion = value; }
            }
            private string answer1;   //ответ а)

            public string Answer1
            {
                get { return answer1; }
                set { answer1 = value; }
            }
            private string answer2;   //ответ б)

            public string Answer2
            {
                get { return answer2; }
                set { answer2 = value; }
            }
            private string answer3;   // ответ в)

            public string Answer3
            {
                get { return answer3; }
                set { answer3 = value; }
            }
            private string answer4;  // ответ г)

            public string Answer4
            {
                get { return answer4; }
                set { answer4 = value; }
            }
            private string res;      //правильный ответ

            public string Res
            {
                get { return res; }
                set { res = value; }
            }

            public Questions(string _question, string a, string b, string c, string d, string r)
            {
                this.qustion = _question;
                this.answer1 = a;
                this.answer2 = b;
                this.answer3 = c;
                this.answer4 = d;
                this.res = r;
            }
        }
        public Form1()
        {
            InitializeComponent();
            //создаем массив с вопросами, вариантами ответов и правильным ответом
            Questions[] q = { new Questions("В каком году родился, автор данной темы?", "a.1989 год", "b.1988 год", "c.1986 год", "d.1990 год", "b"),
                            new Questions("Кто президент Украины?", "a.Янукович", "b.Тимошенко", "c.Кучма", "d.Мороз", "a")};
            q1 = q;
            //задаем первый вопрос
            label1.Text = q[0].Qustion;
            //варианты ответа
            radioButton1.Text = q[0].Answer1;
            radioButton2.Text = q[0].Answer2;
            radioButton3.Text = q[0].Answer3;
            radioButton4.Text = q[0].Answer4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count < max) //проверям количество заданых вопросов(больше чем есть в массиве задать не можем)
            {
                // сравниваем выбраный вариант с правильным
                if (radioButton1.Checked == true)
                {
                    if (q1[count].Res == "a")
                    { res++; } //если совпали, то количество правильных вопросов увеличиваем на 1
                }
                if (radioButton2.Checked == true)
                {
                    if (q1[count].Res == "b")
                    { res++; }
                }
                if (radioButton3.Checked == true)
                {
                    if (q1[count].Res == "c")
                    { res++; }
                }
                if (radioButton4.Checked == true)
                {
                    if (q1[count].Res == "d")
                    { res++; }
                }
                count++;
                if (count < max)
                {
                    label1.Text = q1[count].Qustion; //задаем слудующий вопрос
                    radioButton1.Text = q1[count].Answer1;
                    radioButton2.Text = q1[count].Answer2;
                    radioButton3.Text = q1[count].Answer3;
                    radioButton4.Text = q1[count].Answer4;
                }
                else
                {
                    button1.Enabled = false; // делаем кнопку на рабочей
                    label2.Text = "Количество правильных ответов: " + Convert.ToString(res);//выводим результат
                }

            }

        }
    }
}
