﻿using System;
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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // add a new row to the DataGridView from inputs
            dataGridView1.Columns.Add("Column1", "ID");
            dataGridView1.Columns.Add("Column2", "First Name");
            dataGridView1.Columns.Add("Column3", "Last Name");
            dataGridView1.Columns.Add("Column4", "Adress");
            dataGridView1.Columns.Add("Column5", "Gender");

            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text,
                textBox4.Text, comboBox1.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
        }
    }
}