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
    public partial class MemberFunctionalities : Form
    {
        Controller controllerObj;
        string cust_ID;
        public MemberFunctionalities(string ID)
        {
            InitializeComponent();
            controllerObj = new Controller();
            cust_ID = ID;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase(cust_ID);
            purchase.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReservationOrLending reservation = new ReservationOrLending(cust_ID);
            reservation.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchBook searchBook= new SearchBook();
            searchBook.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerAccount customerAccount = new CustomerAccount(cust_ID);
            customerAccount.Show();
        }
    }
}
