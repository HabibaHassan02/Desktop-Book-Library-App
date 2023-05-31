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
    public partial class Manager_changeStatus : Form
    {
        Controller controllerObj;
        public Manager_changeStatus()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.retrun_all_accounts();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

            DataTable dt2 = controllerObj.retrun_all_accounts();
           ID_account.DataSource = dt2;
            ID_account.DisplayMember = "ID";
            ID_account.ValueMember = "ID";



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Status.SelectedText == "")
                MessageBox.Show("Please enter the status");
            else
            {
                controllerObj = new Controller();
                int x = controllerObj.update_status(Status.Text, Convert.ToInt32(ID_account.Text));
                dataGridView1.Refresh();
                if (x == 1)
                {
                    DataTable dt = controllerObj.retrun_all_accounts();
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    MessageBox.Show("The operation was successful");
                }
                else
                {
                    MessageBox.Show("Please try again");
                }
            }
        }

        private void ID_account_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
