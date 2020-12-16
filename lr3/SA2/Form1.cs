using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr3
{
    public partial class Form1 : Form
    {
        private double[] m;
        private int n = 0;
        private double A = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox1.KeyUp += new KeyEventHandler(textBox1_KeyUp);
            this.textBox2.KeyUp += new KeyEventHandler(textBox2_KeyUp);
            this.textBox3.KeyUp += new KeyEventHandler(textBox3_KeyUp);
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Array input
                string text = textBox1.Text;
                String[] array = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                m = new double[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    m[i] = Convert.ToDouble(array[i]);
                }
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            //n input
            if (e.KeyCode == Keys.Enter)
            {
                n = Convert.ToInt32(textBox2.Text);
            }
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            //A input
            if (e.KeyCode == Keys.Enter)
            {
                A = Convert.ToDouble(textBox3.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearAnswers();
            string text = textBox1.Text;
            String[] array = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            m = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                m[i] = Convert.ToDouble(array[i]);
            }
            n = Convert.ToInt32(textBox2.Text);
            A = Convert.ToDouble(textBox3.Text);
            clearAnswers();

            double result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += m[m.Length - i];
            }
            result /= n;

            label5.Text = Convert.ToString(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearAnswers();
            string text = textBox1.Text;
            String[] array = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            m = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                m[i] = Convert.ToDouble(array[i]);
            }
            n = Convert.ToInt32(textBox2.Text);
            A = Convert.ToDouble(textBox3.Text);
            
            double[] m1 = new double[m.Length];
            m1[0] = m[0];

            for (int i = 1; i < m.Length; i++)
            {
                m1[i] = (m[i] * A) + ((1 - A) * m1[i - 1]);  
            }

            string result = Convert.ToString(m1[m1.Length-1]);
            label5.Text = result;

            result = "";
            for (int i = 0; i < m1.Length; i++)
            {
                result += Convert.ToString(Math.Round(m1[i],4));
                result += "   ";
            }

            label6.Text = result;
        }

        private void clearAnswers()
        {
            label5.Text = "";
            label6.Text = "";
        }

    }
}
