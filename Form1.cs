using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formtest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            student obj = new student();
            string name=  textBox1.Text;
            string clas = textBox2.Text;
            int roll =  Convert.ToInt32 (textBox3.Text);
            obj.set(name, roll, clas);
            Form1 form1 = new Form1();
            Form2 form2 = new Form2(obj);
            form1.Hide();
            form2.Show();
        }
    }
}
