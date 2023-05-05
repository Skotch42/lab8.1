using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random generator = new Random();
            int number = generator.Next(1, 100);
            label1.Visible = true;

            if (textBox1.Text.Length == 0)
            {
                label1.ForeColor = Color.Blue;
                label1.Text = "Сначала введите вопрос!";
            }
            else
            {
                if (number < 60)
                {
                    label1.ForeColor = Color.Green;
                    label1.Text = "Да!";
                }
                else
                {
                    label1.ForeColor = Color.IndianRed;
                    label1.Text = "Нет!";
                }
            }
        }
    }
}
