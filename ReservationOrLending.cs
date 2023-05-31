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
    public partial class ReservationOrLending : Form
    {
        Controller controllerObj;
        string cust_ID;
        string selected_title;
        public ReservationOrLending(string ID)
        {
            InitializeComponent();
            controllerObj = new Controller();
            cust_ID = ID;
            DataTable dt = controllerObj.select_genres();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "genre";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                var now = DateTime.Now;
                var zeroDate = DateTime.MinValue.AddHours(now.Hour).AddMinutes(now.Minute).AddSeconds(now.Second).AddMilliseconds(now.Millisecond);
                int reservation_id = (int)(zeroDate.Ticks / 10000);
                DataTable dt = controllerObj.select_ISBN_byname(selected_title);
                int r = controllerObj.InsertCustReservation(reservation_id, DateTime.Now, dt.Rows[0]["ISBN"].ToString(), Convert.ToInt32(cust_ID));
                if (r != 0)
                {
                    dt = controllerObj.select_reservation(reservation_id);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    MessageBox.Show("Reservation done successfully");
                }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.select_titles_of_genres(comboBox1.SelectedText.ToString());
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "title";
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selected_title = comboBox2.SelectedText.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                var now = DateTime.Now;
                var zeroDate = DateTime.MinValue.AddHours(now.Hour).AddMinutes(now.Minute).AddSeconds(now.Second).AddMilliseconds(now.Millisecond);
                int lending_id = (int)(zeroDate.Ticks / 10000);
                DataTable dt = controllerObj.select_ISBN_byname(comboBox2.SelectedText.ToString());
                int r = controllerObj.InsertCustLending(lending_id, DateTime.Now, dt.Rows[0]["ISBN"].ToString(), Convert.ToInt32(cust_ID));
                if (r != 0)
                {
                    dt = controllerObj.select_lending(lending_id);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    MessageBox.Show("Lending order done successfully");
                }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
