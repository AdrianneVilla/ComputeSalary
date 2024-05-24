namespace EmployeeApplication
{
    partial class frmComputeSalary
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
            this.label1 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.departmentTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.jobTitleTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RatePerHourTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalHoursWorked = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.basicSalary = new System.Windows.Forms.Label();
            this.basicSalaryTxt = new System.Windows.Forms.Label();
            this.firstNameTxt = new System.Windows.Forms.Label();
            this.lastNameTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(12, 41);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(152, 20);
            this.firstName.TabIndex = 1;
            // 
            // departmentTxt
            // 
            this.departmentTxt.Location = new System.Drawing.Point(12, 93);
            this.departmentTxt.Name = "departmentTxt";
            this.departmentTxt.Size = new System.Drawing.Size(152, 20);
            this.departmentTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(167, 41);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(152, 20);
            this.lastName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // jobTitleTxt
            // 
            this.jobTitleTxt.Location = new System.Drawing.Point(170, 93);
            this.jobTitleTxt.Name = "jobTitleTxt";
            this.jobTitleTxt.Size = new System.Drawing.Size(152, 20);
            this.jobTitleTxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Job Title";
            // 
            // RatePerHourTxt
            // 
            this.RatePerHourTxt.Location = new System.Drawing.Point(12, 193);
            this.RatePerHourTxt.Name = "RatePerHourTxt";
            this.RatePerHourTxt.Size = new System.Drawing.Size(152, 20);
            this.RatePerHourTxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rate per hour";
            // 
            // TotalHoursWorked
            // 
            this.TotalHoursWorked.Location = new System.Drawing.Point(170, 193);
            this.TotalHoursWorked.Name = "TotalHoursWorked";
            this.TotalHoursWorked.Size = new System.Drawing.Size(152, 20);
            this.TotalHoursWorked.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total hours worked";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Compute Salary";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "First Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Last Name:";
            // 
            // basicSalary
            // 
            this.basicSalary.AutoSize = true;
            this.basicSalary.Location = new System.Drawing.Point(12, 326);
            this.basicSalary.Name = "basicSalary";
            this.basicSalary.Size = new System.Drawing.Size(68, 13);
            this.basicSalary.TabIndex = 15;
            this.basicSalary.Text = "Basic Salary:";
            // 
            // basicSalaryTxt
            // 
            this.basicSalaryTxt.AutoSize = true;
            this.basicSalaryTxt.Location = new System.Drawing.Point(86, 326);
            this.basicSalaryTxt.Name = "basicSalaryTxt";
            this.basicSalaryTxt.Size = new System.Drawing.Size(0, 13);
            this.basicSalaryTxt.TabIndex = 16;
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.AutoSize = true;
            this.firstNameTxt.Location = new System.Drawing.Point(78, 280);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(0, 13);
            this.firstNameTxt.TabIndex = 17;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.AutoSize = true;
            this.lastNameTxt.Location = new System.Drawing.Point(76, 303);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(0, 13);
            this.lastNameTxt.TabIndex = 18;
            // 
            // frmComputeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 364);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.firstNameTxt);
            this.Controls.Add(this.basicSalaryTxt);
            this.Controls.Add(this.basicSalary);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TotalHoursWorked);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RatePerHourTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.jobTitleTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.departmentTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label1);
            this.Name = "frmComputeSalary";
            this.Text = "frmComputeSalary";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox departmentTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox jobTitleTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RatePerHourTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TotalHoursWorked;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label basicSalary;
        private System.Windows.Forms.Label basicSalaryTxt;
        private System.Windows.Forms.Label firstNameTxt;
        private System.Windows.Forms.Label lastNameTxt;
    }
}

