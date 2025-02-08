using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegexDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Tag = Tuple.Create(textBox1, "^(\\+38)?0[5-79]\\d(\\d{3}-?\\d{2}-?\\d{2})$", labelNumber);
            button2.Tag = Tuple.Create(textBox2, "^([А-ЯІЇ]{2}\\d{6}|\\d{8}-\\d{5})$", labelPassport);
            button3.Tag = Tuple.Create(textBox3, "^(1031[1-9]|103[2-9]\\d|10[4-9]\\d{2}|1[1-9]\\d{3}|[2-7]\\d{4}|8964[0-5]|896[0-3]\\d|89[0-5]\\d{2}|8[0-8]\\d{3})$", labelInterval);
            button4.Tag = Tuple.Create(textBox4, "^[А-ЯІЇ][а-яії']+$", labelName);
            button5.Tag = Tuple.Create(textBox5, "^([0-1]\\d|2[0-3]):[0-5]\\d$", labelTime);
            button6.Tag = Tuple.Create(textBox6, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$", labelEmail);

            button1.Click += Button_Click;
            button2.Click += Button_Click;
            button3.Click += Button_Click;
            button4.Click += Button_Click;
            button5.Click += Button_Click;
            button6.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is Tuple<TextBox, string, Label> data)
            {
                Check(data.Item1, data.Item2, data.Item3);
            }
        }

        private void Check(TextBox box, string regex, Label res)
        {
            if (Regex.IsMatch(box.Text, regex))
            {
                res.Text = "YES";
                res.ForeColor = Color.Green;
            }
            else
            {
                res.Text = "NO";
                res.ForeColor = Color.Red;
            }
        }
    }
}
