using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class frmStudentGradeProgram : Form
    {
        public frmStudentGradeProgram()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double English, Math, Science, Filipino, History, avg;
            string name = textBox1.Text;
            English = Convert.ToDouble(textBox2.Text);
            Math = Convert.ToDouble(textBox3.Text);
            Science = Convert.ToDouble(textBox4.Text);
            Filipino = Convert.ToDouble(textBox6.Text);
            History = Convert.ToDouble(textBox7.Text);

            avg = Convert.ToDouble((English + Math + Science + Filipino + History) / 5);
            label8.TextAlign = ContentAlignment.TopCenter;
            label8.Text = avg >= 75.00 ? "The student passed." : "The student failed.";
            label9.Text = "The general average of " + name + " is " + avg + ".";
        }
    }
}
