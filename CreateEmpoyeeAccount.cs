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
   
    public partial class CreateEmpoyeeAccount : Form
    {
        Controller controllerObj;
        public CreateEmpoyeeAccount()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
          int x=  controllerObj.InsertAccountEmployee(Convert.ToInt32(ID_account.Value), Password.Text, status.Text);
           int y= controllerObj.InsertEmployee(Convert.ToInt32(SSN.Value),Name_employe.Text,Gender.Text,Convert.ToInt32( Salary.Value), Convert.ToInt32(ID_account.Text));
            if (x==1&&y==1) {
                if (x == 1)
                {
                    MessageBox.Show("The operation was successful");
                }
                else
                {
                    MessageBox.Show("Please try again");
                }

            }
        }

        private void Name_employe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
