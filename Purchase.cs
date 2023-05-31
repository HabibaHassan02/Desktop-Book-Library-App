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
    public partial class Purchase : Form
    {
        Controller controllerObj;
        string custID;
        string selected_title;
        public Purchase(string ID)
        {
            InitializeComponent();
            custID = ID;
            controllerObj = new Controller();
            DataTable dt = controllerObj.select_genres();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "genre";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            var zeroDate = DateTime.MinValue.AddHours(now.Hour).AddMinutes(now.Minute).AddSeconds(now.Second).AddMilliseconds(now.Millisecond);
            int purchase_id = (int)(zeroDate.Ticks / 10000);
            int r = controllerObj.InsertPurchase(purchase_id, DateTime.Now, 13, Convert.ToInt32(custID));
            if (r != 0)
            {
                DataTable dt = controllerObj.select_ISBN_byname(selected_title);
                int r2=controllerObj.InsertPurchasedBooks(purchase_id, dt.Rows[0]["ISBN"].ToString());
                MessageBox.Show("Please go to Mariam to pay for your purchase");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            DataTable dt = controllerObj.select_price_of_book(comboBox2.SelectedText.ToString());
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
