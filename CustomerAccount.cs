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
    public partial class CustomerAccount : Form
    {
        Controller controllerObj;
        string cust_ID;
        public CustomerAccount(string ID)
        {
            InitializeComponent();
            controllerObj = new Controller();
            cust_ID = ID;
            DataTable dt = controllerObj.get_all_customer_info(Convert.ToInt32(cust_ID));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = controllerObj.update_password(textBox1.Text, Convert.ToInt32(cust_ID));
            if (r != 0)
            {
                DataTable dt = controllerObj.get_all_customer_info(Convert.ToInt32(cust_ID));
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                MessageBox.Show("Password updated successfully");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase(cust_ID);
            purchase.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchBook search = new SearchBook();
            search.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int r = controllerObj.cancelMembership(Convert.ToInt32(cust_ID));
            if (r != 0)
            {
                dataGridView1.DataSource=null;
                dataGridView1.Refresh();
                MessageBox.Show("Your membership in the library was cancelled");
                Application.Exit();
            }
        }
    }
}
