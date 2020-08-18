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
        int count = 0;
        int max = 5; 
        int res; 
        Questions[] q1;

        class Questions 
        {
            private string qustion;  

            public string Qustion
            {
                get { return qustion; }
                set { qustion = value; }
            }
            private string answer1;   //а

            public string Answer1
            {
                get { return answer1; }
                set { answer1 = value; }
            }
            private string answer2;   //б

            public string Answer2
            {
                get { return answer2; }
                set { answer2 = value; }
            }
            private string answer3;   //в

            public string Answer3
            {
                get { return answer3; }
                set { answer3 = value; }
            }
            private string answer4;  //г

            public string Answer4
            {
                get { return answer4; }
                set { answer4 = value; }
            }
            private string res;     

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
            Questions[] q = { new Questions("В какой из перечисленных спортивных игр не нужна сетка?", "a.тенис", "b.городки", "c.волейбол", "d.бадминтон(хз почему она здесь нужна)", "b"),
                            new Questions("Что из перечисленного не имеет резьбы?", "a.гайка", "b.шуруп", "c.шайба", "d.болт", "d"),
                            new Questions("Какое максимальное количество очков можно набрать одним броском при игре в дартс?", "a.20", "b.50", "c.25", "d.60", "d"),
                            new Questions("Какое слово произошло от латинского *правитель*?", "a.депутат", "b.делегат", "c.губернатор", "d.президент", "c"),
                            new Questions("Отгадайте загадку: Не лает, не кусает, а в дом не пускает", "a.жена", "b.замок", "c.совесть", "d.милиционер", "b")};
            q1 = q;

            label1.Text = q[0].Qustion;

            radioButton1.Text = q[0].Answer1;
            radioButton2.Text = q[0].Answer2;
            radioButton3.Text = q[0].Answer3;
            radioButton4.Text = q[0].Answer4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count < max) 
            {
                if (radioButton1.Checked == true)
                {
                    if (q1[count].Res == "a")
                    { res++; } 
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
                    label1.Text = q1[count].Qustion; 
                    radioButton1.Text = q1[count].Answer1;
                    radioButton2.Text = q1[count].Answer2;
                    radioButton3.Text = q1[count].Answer3;
                    radioButton4.Text = q1[count].Answer4;
                }
                else
                {
                    button1.Enabled = false; 
                    label2.Text = "Количество правильных ответов: " + Convert.ToString(res);
                }

            }

        }
    }
}
