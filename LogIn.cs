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
    public partial class LogIn : Form
    {
        Controller controllerObj;
        public LogIn()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user_name.Text == "" || password.Text == "")//validation part
            {
                MessageBox.Show("Please, insert both username and password");
            }
            else
            {
                controllerObj = new Controller();
                DataTable dt = controllerObj.take_password_return_acc_type(password.Text);
                if (dt == null)
                {
                    MessageBox.Show("Error! Enter password correctly");
                }
                else
                {
                    string accout_type_returned = Convert.ToString(dt.Rows[0][0]);
                    string ID_returned = Convert.ToString(dt.Rows[0][1]);
                    string name_returned = "";

                    switch (accout_type_returned)
                    {
                        case "M":
                            DataTable dt2 = controllerObj.take_account_type_return_username_M(Convert.ToInt32(ID_returned));
                            name_returned = Convert.ToString(dt2.Rows[0][0]);
                            if (name_returned == user_name.Text || name_returned.ToLower()== user_name.Text.ToLower() || name_returned.ToUpper() == user_name.Text.ToUpper())
                            {
                                ManagerFunctionalities f = new ManagerFunctionalities();
                                f.Show();
                            }
                            else
                            {
                                MessageBox.Show("Error! Enter username correctly");
                            }
                            break;
                        case "C":
                            DataTable dt3 = controllerObj.take_account_type_return_username_C(Convert.ToInt32(ID_returned));
                            name_returned = Convert.ToString(dt3.Rows[0][0]);
                            if (name_returned == user_name.Text || name_returned.ToLower() == user_name.Text.ToLower() || name_returned.ToUpper() == user_name.Text.ToUpper())
                            {
                                MemberFunctionalities f = new MemberFunctionalities(ID_returned);
                                f.Show();
                            }
                            else
                            {
                                MessageBox.Show("Error! Enter username correctly");
                            }
                            break;
                        case "E":
                            DataTable dt4 = controllerObj.take_account_type_return_username_E(Convert.ToInt32(ID_returned));
                            name_returned = Convert.ToString(dt4.Rows[0][0]);
                            if (name_returned == user_name.Text || name_returned.ToLower() == user_name.Text.ToLower() || name_returned.ToUpper() == user_name.Text.ToUpper())
                            {
                                EmployeeFunctionalities f = new EmployeeFunctionalities(ID_returned);
                                f.Show();
                            }
                            else
                            {
                                MessageBox.Show("Error! Enter username correctly");
                            }
                            break;

                    }
                }
            }
            



        }

        private void user_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
