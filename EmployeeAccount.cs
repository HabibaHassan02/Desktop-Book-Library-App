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
    public partial class EmployeeAccount : Form
    {
        string employee_ID;
        Controller controller;
        public EmployeeAccount(string employeeID)
        {
            InitializeComponent();
            controller = new Controller();
            employee_ID = employeeID;
            DataTable dt1 = controller.select_SSN_by_empID(Convert.ToInt32(employeeID));
            DataTable dt = controller.ReturnEmployeeInfo(dt1.Rows[0]["SSN"].ToString());
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
