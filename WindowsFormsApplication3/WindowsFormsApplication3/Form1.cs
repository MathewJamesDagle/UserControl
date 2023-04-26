using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string inputOneInputs
        {
            set
            {
                textBox1.Text = value;
            }
        }

        public string inputTwoInputs
        {
            set
            {
                textBox2.Text = value;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panelOne_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl11.BringToFront();

            userControl21.Hide();
        }

        private void panelTwo_Click(object sender, EventArgs e)
        {
            userControl21.Show();
            userControl21.BringToFront();

            userControl11.Hide();
        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }
    }
}
