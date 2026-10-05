using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewbarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewbarang.Rows.Add("BRG-001", "Buku tulis", "4.500", 42, 10, "Aman");
            dataGridViewbarang.Rows.Add("BRG-002", "Pulpen hitam", "3.500", 60, 15, "Aman");
            dataGridViewbarang.Rows.Add("BRG-003", "Mi instan", "3.200", 9, 15, "Menipis");
            dataGridViewbarang.Rows.Add("BRG-004", "Beras 5 kg", "68.000", 3, 10, "Menipis");


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Dash = new Form1();
            Dash.FormClosed += (s, args) => Application.Exit();
            Dash.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
