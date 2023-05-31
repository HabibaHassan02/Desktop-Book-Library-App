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
    public partial class EmployeeViewOfCustomerAccount : Form
    {
        Controller controller;
        string cust_ID;
        string employee_ID;
        public EmployeeViewOfCustomerAccount(string Emp_ID,string customer_ID)
        {
            InitializeComponent();
            controller = new Controller();
            cust_ID = customer_ID;
            employee_ID = Emp_ID;
            DataTable dt = controller.get_all_customer_info(Convert.ToInt32(cust_ID));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Notification notification = new Notification(cust_ID,employee_ID);
            notification.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReserveOrLend r = new ReserveOrLend(employee_ID,cust_ID);
            r.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReserveOrLend l = new ReserveOrLend(employee_ID,cust_ID);
            l.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = controller.UpdateCustomerInfo(textBox1.Text);
            if (result == 0)
            {
                MessageBox.Show("No update");
            }
            else
            {
                MessageBox.Show("The address is updated successfully");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r = controller.cancelMembership(Convert.ToInt32(cust_ID));
            if (r != 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                MessageBox.Show("The customer membership in the library was cancelled");
            }
        }
    }
}
