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
    public partial class AddBook : Form
    {
        Controller controllerObj;
        public AddBook()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.retrun_all_sections();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "section_ID";
            comboBox1.ValueMember = "section_ID";

            DataTable dt2 = controllerObj.retrun_all_racks();
            comboBox2.DataSource = dt2;
            comboBox2.DisplayMember = "Rack_ID";
            comboBox2.ValueMember = "Rack_ID";


        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Book_name.Text == "" || Book_genre.Text == "" || Book_ISBN.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all data");
            }
            else
            {
                controllerObj = new Controller();
                string price = "$" + Convert.ToInt32(bookPrice.Value);
                int x = controllerObj.InsertBook(Book_name.Text, Book_genre.Text, Book_ISBN.Text, Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox1.SelectedValue), price);
                if (x == 1)
                {
                    MessageBox.Show("The operation was successful");
                }
                else
                {
                    MessageBox.Show("Please try again");
                }
            }
        }

        private void Book_ISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void Book_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void Book_genre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void Book_ISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
