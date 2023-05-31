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
    public partial class GiveBonus : Form
    {
        Controller controllerObj;
        public GiveBonus()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.retrun_all_employess();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "acc_ID";
            comboBox1.ValueMember = "SSN";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get the ssn from the employee id and then use it to update the bonus 
            int SSN = Convert.ToInt32(comboBox1.SelectedValue);
            int bonus = Convert.ToInt32(numericUpDown1.Value);
            int x=controllerObj.update_bonus(bonus, SSN);
            if (x == 1)
            {
                MessageBox.Show("The operation was successful");
            }
            else {
                MessageBox.Show("Please try again");
            }


        }
    }
}
