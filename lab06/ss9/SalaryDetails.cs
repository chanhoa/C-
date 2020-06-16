using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class SalaryDetails
    {
        private string _empName;
        public string EmployeeName
        {
            get
            {
                return _empName;
            }
            set
            {
                _empName = value;
            }
        }
        static void Main(string[] args)
        {
            SalaryDetails objSal = new SalaryDetails();
            objSal.EmployeeName = "Patrick Johnson";
            Console.WriteLine("Employee Name: " + objSal.EmployeeName);
            Console.Read();
        }
    }
}
