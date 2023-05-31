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
    public partial class Manager_assignSalary : Form
    {
        Controller controllerObj;
        public Manager_assignSalary()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.retrun_all_employess();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

            controllerObj = new Controller();
            DataTable dt2 = controllerObj.retrun_all_employess();
            comboBox1.DataSource = dt2;
            comboBox1.DisplayMember = "acc_ID";
            comboBox1.ValueMember = "acc_ID";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            int x=controllerObj.update_salary(Convert.ToInt32( Salary.Value), Convert.ToInt32(comboBox1.SelectedValue));
            dataGridView1.Refresh();
            if (x!=0)
            {
                MessageBox.Show("The operation was successful");
            }
            else
            {
                MessageBox.Show("Please try again");
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Manager_assignSalary_Load(object sender, EventArgs e)
        {

        }
    }
}
