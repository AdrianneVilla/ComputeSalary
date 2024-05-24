using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    internal class PartTimeEmployee : IEmployee
    {
        private string firstName;
        private string lastName;
        private string department;
        private string job_salary;
        private double basic_salary;
       
      

        public PartTimeEmployee(string firstName, string lastName, string department, string job_salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.department = department;
            this.job_salary = job_salary;
           
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }
        public string JobTitle
        {
            get
            {
                return job_salary;
            }
            set
            {
                job_salary = value;
            }
        }
        public double BasicSalary
        {
            get
            {
                return basic_salary;
            }
            set
            {
                basic_salary = value;
            }
        }

        public void computeSalary(int hoursWorked, double ratePerHour)
        {
            basic_salary = hoursWorked * ratePerHour; 
        }

        public double getBasicSalary()
        {
            return basic_salary;
        }
    }
}
