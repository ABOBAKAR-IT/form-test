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
    public partial class Form2 : Form
    {
        public Form2(student std)
        {
            InitializeComponent();
            label1.Text = " student name is " + std.name + " student roll no "+std.rollno+" calss is " +std.clas;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
