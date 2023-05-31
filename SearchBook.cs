using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class SearchBook : Form
    {
        Controller controllerObj;
        public SearchBook()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void SearchBook_Load(object sender, EventArgs e)
        {
            //this.textBox1.Enter += new EventHandler(textBox1_Enter);
            //this.textBox1.Leave += new EventHandler(textBox1_Leave);
            textBox1_SetText();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        protected void textBox1_SetText()
        {
            textBox1.Text = "Search for a book by its name";
            textBox1.ForeColor = Color.Gray;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.ForeColor == Color.Black)
                return;
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
                textBox1_SetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ""||textBox1.Text== "Search for a book by its name")
                MessageBox.Show("Please enter book name");
            else
            {
                DataTable dt = controllerObj.select_book_byname(textBox1.Text);
                if (dt == null)
                {
                    MessageBox.Show("Sorry! Book is not available.");
                }
                else
                {
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
