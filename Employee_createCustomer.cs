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
    public partial class Employee_createCustomer : Form
    {
        Controller controllerObj;
        public Employee_createCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "" || comboBox1.SelectedText == "")
                MessageBox.Show("Please enter all customer info");
            else
            {
                controllerObj = new Controller();
                string x = textBox1.Text;
                string y = textBox2.Text;
                int ID = Convert.ToInt32(numericUpDown1.Value);
                controllerObj.InsertCustomerAccount(ID, textBox4.Text, comboBox1.Text);

                controllerObj.InsertCustomer(ID, x, y);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
