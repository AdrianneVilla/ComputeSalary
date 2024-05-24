using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee
                (
                firstName.Text,
                lastName.Text,
                departmentTxt.Text,
                jobTitleTxt.Text);

            partTimeEmployee.computeSalary
                (Convert.ToInt32(TotalHoursWorked.Text), Convert.ToDouble(RatePerHourTxt.Text));

            basicSalaryTxt.Text = Convert.ToString (partTimeEmployee.getBasicSalary());
            firstNameTxt.Text = partTimeEmployee.FirstName;
            lastNameTxt.Text = partTimeEmployee.LastName;

        }
    }
}
