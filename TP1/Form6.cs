using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // authentification
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                MessageBox.Show("Bravo");
                label3.Visible = false;
            }
            else
            {
                label3.Text = "Login et mot de passe erronés";
                label3.Visible = true;
            }
        }
    }
}
