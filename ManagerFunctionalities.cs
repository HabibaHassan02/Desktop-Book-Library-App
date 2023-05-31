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
    public partial class ManagerFunctionalities : Form
    {
        public ManagerFunctionalities()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Manager_changeStatus f = new Manager_changeStatus();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManagerAccount managerAccount = new ManagerAccount();
            managerAccount.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GiveBonus giveBonus = new GiveBonus();
            giveBonus.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddBook add = new AddBook();
            add.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreateEmpoyeeAccount create = new CreateEmpoyeeAccount();
            create.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager_assignSalary f = new Manager_assignSalary();
            f.Show();
        }

        private void ManagerFunctionalities_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }
    }
}
