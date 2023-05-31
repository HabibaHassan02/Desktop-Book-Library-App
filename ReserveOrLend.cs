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
    public partial class ReserveOrLend : Form
    {
        Controller controller;
        string cust_ID;
        string employee_ID;
        string selected_title;
        public ReserveOrLend(string emp_ID,string customerID)
        {
            InitializeComponent();
            controller = new Controller();
            cust_ID = customerID;
            employee_ID = emp_ID;
            DataTable dt = controller.select_genres();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "genre";
            // comboBox1.ValueMember = "genre";
        }

        private void button2_Click(object sender, EventArgs e)
        {
                var now = DateTime.Now;
                var zeroDate = DateTime.MinValue.AddHours(now.Hour).AddMinutes(now.Minute).AddSeconds(now.Second).AddMilliseconds(now.Millisecond);
                int lending_id = (int)(zeroDate.Ticks / 10000);
                DataTable dt = controller.select_ISBN_byname(selected_title);
                DataTable dt2 = controller.select_SSN_by_empID(Convert.ToInt32(employee_ID));
                int r = controller.InsertEmployeeLending(lending_id, DateTime.Now, dt.Rows[0]["ISBN"].ToString(), dt2.Rows[0]["SSN"].ToString(), Convert.ToInt32(cust_ID));
                if (r != 0)
                {
                    dt = controller.select_lending(lending_id);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    MessageBox.Show("Lending done successfully");
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                var now = DateTime.Now;
                var zeroDate = DateTime.MinValue.AddHours(now.Hour).AddMinutes(now.Minute).AddSeconds(now.Second).AddMilliseconds(now.Millisecond);
                int reservation_id = (int)(zeroDate.Ticks / 10000);
                DataTable dt = controller.select_ISBN_byname(selected_title);
                DataTable dt2 = controller.select_SSN_by_empID(Convert.ToInt32(employee_ID));
                int r = controller.InsertEmployeeReservation(reservation_id, DateTime.Now, dt.Rows[0]["ISBN"].ToString(), dt2.Rows[0]["SSN"].ToString(), Convert.ToInt32(cust_ID));
                if (r != 0)
                {
                    dt = controller.select_reservation(reservation_id);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    MessageBox.Show("Reservation done successfully");
                }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }
        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            DataTable dt = controller.select_titles_of_genres(comboBox1.SelectedText.ToString());
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "title";
        }

        private void comboBox2_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            selected_title = comboBox2.SelectedText.ToString();
        }
    }
}
