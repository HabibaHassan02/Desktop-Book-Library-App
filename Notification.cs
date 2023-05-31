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
    public partial class Notification : Form
    {
        Controller controller;
        string employeeID;
        string customerID;
        public Notification(string custID, string empID)
        {
            InitializeComponent();
            controller = new Controller();
            employeeID = empID;
            customerID = custID;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Please enter content");
            else
            {
                DataTable dt = controller.select_SSN_by_empID(Convert.ToInt32(employeeID));
                int r = controller.InsetNotificationContent(Convert.ToInt32(customerID), comboBox1.Text, textBox1.Text, dt.Rows[0]["SSN"].ToString());
                if (r != 0)
                {
                    MessageBox.Show("Notification is sent successfully");
                }
                else
                {
                    MessageBox.Show("No notification is sent");
                }
            }
        }
    }
}
