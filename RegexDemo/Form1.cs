using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegexDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static bool CheckRegex(string str, string reg)
        {
            Regex regex = new Regex(reg);
            return regex.IsMatch(str) ;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        void Check(TextBox box, String regex, Label res) {
            if (CheckRegex(box.Text, regex))
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
        private void button1_Click(object sender, EventArgs e)
        {
            Check(textBox1, "^(\\+38)?0[5-79]\\d(\\d{3}-?\\d{2}-?\\d{2})$", labelNumber);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Check(textBox2, "^([А-ЯІЇ]{2}\\d{6}|\\d{8}-\\d{5})$", labelPassport);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Check(textBox3, "^(1031[1-9]|103[2-9]\\d|10[4-9]\\d{2}|1[1-9]\\d{3}|[2-7]\\d{4}|8964[0-5]|896[0-3]\\d|89[0-5]\\d{2}|8[0-8]\\d{3})$", labelInterval);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Check(textBox4, "^[А-ЯІЇ][а-яії']+$", labelName);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Check(textBox5, "^([0-1]\\d|2[0-3]):[0-5]\\d$", labelTime);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Check(textBox6, "^[a-z1-9._]+@[a-z]+(\\.[a-z]+)+$", labelEmail);
        
        }
    }
}
