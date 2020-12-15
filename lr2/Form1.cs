using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            calculate();
        }

        public void calculate()
        {
            double k1 = GetNumber(textBox2.Text);
            double k2 = GetNumber(textBox3.Text);
            double Ak1 = GetNumber(textBox4.Text);
            double Ak2 = GetNumber(textBox9.Text);
            double Bk1 = GetNumber(textBox5.Text);
            double Bk2 = GetNumber(textBox8.Text);
            double Ck1 = GetNumber(textBox6.Text);
            double Ck2 = GetNumber(textBox7.Text);

            double A_res = k1 * Ak1 + k2 * Ak2;
            double B_res = k1 * Bk1 + k2 * Bk2;
            double C_res = k1 * Ck1 + k2 * Ck2;

            label19.Text = $"A={A_res}";
            label20.Text = $"A={B_res}";
            label21.Text = $"A={C_res}";

            double max_res = Math.Max(A_res, Math.Max(B_res, C_res));

            string answer = $"Комбінована вага найбільша у параметра ";

            if (max_res == A_res)
            {
                label19.BackColor = System.Drawing.Color.LightGreen;
                answer = answer + "A";
            }
            if (max_res == B_res)
            {
                label20.BackColor = System.Drawing.Color.LightGreen;
                answer = answer + "B";
            }
            if (max_res == C_res)
            {
                label21.BackColor = System.Drawing.Color.LightGreen;
                answer = answer + "C";
            }

            MessageBox.Show(answer);
        }

        static double GetNumber(string str)
        {
            double number;
            bool success = Double.TryParse(str, out number);

            if (success)
            {
                return number;
            }
            else
            {
                MessageBox.Show("Enter Number!!!");
                return 0;
            }
        }
    }
}
