
namespace DBapplication
{
    partial class CreateEmpoyeeAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label121 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Name_employe = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.ComboBox();
            this.label123 = new System.Windows.Forms.Label();
            this.SSN = new System.Windows.Forms.NumericUpDown();
            this.Salary = new System.Windows.Forms.NumericUpDown();
            this.ID_account = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.SSN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_account)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 343);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(335, 343);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(132, 22);
            this.Password.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 435);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Location = new System.Drawing.Point(117, 112);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(36, 17);
            this.label121.TabIndex = 11;
            this.label121.Text = "SSN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Salary";
            // 
            // Gender
            // 
            this.Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.Gender.Location = new System.Drawing.Point(370, 155);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(57, 24);
            this.Gender.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Account ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Name";
            // 
            // Name_employe
            // 
            this.Name_employe.Location = new System.Drawing.Point(335, 64);
            this.Name_employe.Name = "Name_employe";
            this.Name_employe.Size = new System.Drawing.Size(132, 22);
            this.Name_employe.TabIndex = 17;
            this.Name_employe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_employe_KeyPress);
            // 
            // status
            // 
            this.status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Activated",
            "Deactivated"});
            this.status.Location = new System.Drawing.Point(335, 302);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(132, 24);
            this.status.TabIndex = 19;
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(127, 305);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(48, 17);
            this.label123.TabIndex = 20;
            this.label123.Text = "Status";
            // 
            // SSN
            // 
            this.SSN.Location = new System.Drawing.Point(347, 107);
            this.SSN.Name = "SSN";
            this.SSN.Size = new System.Drawing.Size(120, 22);
            this.SSN.TabIndex = 21;
            // 
            // Salary
            // 
            this.Salary.Location = new System.Drawing.Point(347, 205);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(120, 22);
            this.Salary.TabIndex = 22;
            // 
            // ID_account
            // 
            this.ID_account.Location = new System.Drawing.Point(347, 256);
            this.ID_account.Name = "ID_account";
            this.ID_account.Size = new System.Drawing.Size(120, 22);
            this.ID_account.TabIndex = 23;
            // 
            // CreateEmpoyeeAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 554);
            this.Controls.Add(this.ID_account);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.SSN);
            this.Controls.Add(this.label123);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Name_employe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label121);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateEmpoyeeAccount";
            this.Text = "CreateEmpoyeeAccount";
            ((System.ComponentModel.ISupportInitialize)(this.SSN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_account)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Name_employe;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.NumericUpDown SSN;
        private System.Windows.Forms.NumericUpDown Salary;
        private System.Windows.Forms.NumericUpDown ID_account;
    }
}